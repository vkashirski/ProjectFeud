using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinkiFeud
{
    public partial class MainGame : Form
    {
        public static int questionCounter = 1;
        public static List<int> questionIndex = new List<int>();
        public static int counter = 0;
        public bool flag = false;
        public static int Time = 60;
        public static List<Player> players = new List<Player>();
        public String Diff;
        public int multiplier = 1;
        public int Points = 0;
        public int flagPoints = 0;
        Player currentPlayer;
        String FileName;
        //This list will contain the answers of the questions
        public List<String> answers = new List<String>();
        SoundPlayer RevealSoundPlayer = new SoundPlayer();
        SoundPlayer TryAgainSoundPlayer = new SoundPlayer();
        SoundPlayer WrongSoundPlayer = new SoundPlayer();
        public MainGame()
        {
            //Show a loading Screen before starting the game
            SplashScreen splash = new SplashScreen();
            splash.ShowDialog();

            //Initialize the Component
            InitializeComponent();

            //Resolve Flickering
            this.DoubleBuffered = true;

            //Load the first question
            nextQuestion();
            FileName = "Untitled";

            //The timer initialization
            timer1.Start();

            //Full Screen mode
            if (ChooseGame.windowedMode == false)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            //Music and Sound
            if (ChooseGame.backgroundMusic == true)
            {
                Stream Theme = Properties.Resources.TV_Theme_Song;
                SoundPlayer ThemeSoundPlayer = new SoundPlayer(Theme);
                ThemeSoundPlayer.Play();
            }
            if (ChooseGame.backgroundSound==true)
            {
                Stream Reveal = Properties.Resources.CLANG__reveal_answer_on_board;
                Stream TryAgain = Properties.Resources.Try_Again1;
                Stream Wrong = Properties.Resources.STRIKE__wrong_answer;
                RevealSoundPlayer = new SoundPlayer(Reveal);
                TryAgainSoundPlayer = new SoundPlayer(TryAgain);
                WrongSoundPlayer = new SoundPlayer(Wrong);
            }

            //current player
            currentPlayer = new Player(ChooseGame.player.Points, ChooseGame.player.Name, ChooseGame.player.difficulty,ChooseGame.player.PlayerIcon);
            Diff = currentPlayer.difficulty;
            textBox2.Text = currentPlayer.Name;
            pbPlayerIcon.Image = currentPlayer.PlayerIcon;

            //points multiplier
            if (Diff.Equals("Easy"))
                multiplier = 1;
            else if (Diff.Equals("Normal"))
                multiplier = 2;
            else if (Diff.Equals("Hard"))
                multiplier = 3;

            //difficulty time setting
            if (Diff.Equals("Easy"))
            {
                Time = 41;
            }
            if (Diff.Equals("Normal"))
            {
                Time = 31;
            }
            if (Diff.Equals("Hard"))
            {
                Time = 21;
            }
        }
        private void saveFile()
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Circles doc file (*.crl)|*.crl";
                saveFileDialog.Title = "Save circles doc";
                saveFileDialog.FileName = FileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, currentPlayer);
                }
            }
        }
        public void gameDone()
        {
            //get new info
            String name = ChooseGame.player.Name;
            String points = Points.ToString();
            String difficulty = ChooseGame.player.difficulty;
            String playersInfo = File.ReadAllText("Players.txt");
            String playerInfo = name + "-" + points+"-"+ difficulty;
            String final = playersInfo + "~" + playerInfo;

            //write
            using (StreamWriter sw = File.CreateText("Players.txt"))
            {
                sw.Write(final);
            }

            //close game
            timer1.Stop();
            StringBuilder sb = new StringBuilder();
            sb.Append("Player name:");
            sb.AppendLine();
            sb.Append(name);
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("Player points:");
            sb.AppendLine();
            sb.Append(points);
            MessageBox.Show(sb.ToString());
            this.Close();
        }
        public void nextQuestion()
        {
            resetImages();
            //read questions txt
            String questionsFile = File.ReadAllText("Questions.txt");

            //split questions
            String[] questionsDivided = questionsFile.Split(new string[] { "~" }, StringSplitOptions.None);
            questionCounter = questionsDivided.Length - 1;

            //randomize questions
            Random random = new Random();
            int number;
            if (flag == false)
            {
                for (int i = 0; i < questionCounter; i++)
                {
                    do
                    {
                        number = random.Next(0, questionCounter);
                    } while (questionIndex.Contains(number));
                    questionIndex.Add(number);
                }
                flag = true;
            }

            //split question from answers
            String[] divided = questionsDivided[questionIndex[counter]].Split(new string[] { "\n" }, StringSplitOptions.None);

            //display questions and answers in appropriate places
            if (questionIndex[counter] == 0)
            {
                tbQuestion.Text = divided[0];
                //Add all the answers into the list
                for (int i = 1; i < divided.Length; i++)
                {
                    /*button1.Text = divided[1];
                    button3.Text = divided[2];
                    button7.Text = divided[3];
                    button10.Text = divided[4];
                    button2.Text = divided[5];
                    button6.Text = divided[6];
                    button8.Text = divided[7];
                    button11.Text = divided[8];*/
                    answers.Add(divided[i]);
                }
            }
            else
            {
                tbQuestion.Text = divided[1];
                //Add all the answers into the list
                for (int i = 2; i < divided.Length; i++)
                {
                    /*button1.Text = divided[1];
                    button3.Text = divided[2];
                    button7.Text = divided[3];
                    button10.Text = divided[4];
                    button2.Text = divided[5];
                    button6.Text = divided[6];
                    button8.Text = divided[7];
                    button11.Text = divided[8];*/
                    answers.Add(divided[i]);
                }
            }

            //counter and reset questions order
            counter++;
            if (counter == questionCounter)
            {
                flag = false;
                MessageBox.Show("No more Questions");
                gameDone();
            }
        }


        private void MainGame_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            //in this case I will show the form in my secondary screen.
            //var screen = Screen.AllScreens.Last();
            //this.Bounds = screen.Bounds;
         
            
            
        }
        String lastCorrectTriedAnswer = null;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool noAnswerFound = true;
            String triedAnswer = tbAnswer.Text.Trim();//Contains the answer entered by the user once the button is clicked
            if (!(tbAnswer.Text == "/"))
            {
                if (triedAnswer.ToLower() == lastCorrectTriedAnswer)
                {
                    tbAnswer.Text = "";
                    if (TryAgainSoundPlayer.IsLoadCompleted == true)
                    {
                        TryAgainSoundPlayer.Play();
                    }
                }
                else
                {
                    //Check if the answer the user has entered is anywhere in the list answers
                    foreach (String answer in answers)
                    {



                        //If the answer is anywhere in the list find the index of where the answer is in the list and place it in the appropriate field in the form
                        if (triedAnswer.ToLower() == answer.Trim().ToLower()) //smeniv od .Contains vo .Equals, posho primer ako napishesh 5, ti dava odgovor i 5 i 50.
                        {
                            if (RevealSoundPlayer.IsLoadCompleted == true)
                            {
                                RevealSoundPlayer.Play();
                            }
                            noAnswerFound = false;
                            int index = answers.IndexOf(answer);
                            if (index == 0)
                            {
                                answer1.Text = answer;
                                answer1.Image = null;
                                Points += 12 * multiplier;

                            }
                            if (index == 1)
                            {
                                answer2.Text = answer;
                                answer2.Image = null;
                                Points += 10 * multiplier;

                            }
                            if (index == 2)
                            {
                                answer3.Text = answer;
                                answer3.Image = null;
                                Points += 8 * multiplier;
                            }
                            if (index == 3)
                            {
                                answer4.Text = answer;
                                answer4.Image = null;
                                Points += 6 * multiplier;
                            }
                            if (index == 4)
                            {
                                answer5.Text = answer;
                                answer5.Image = null;
                                Points += 4 * multiplier;
                            }
                            if (index == 5)
                            {
                                answer6.Text = answer;
                                answer6.Image = null;
                                Points += 3 * multiplier;
                            }
                            if (index == 6)
                            {
                                answer7.Text = answer;
                                answer7.Image = null;
                                Points += 2 * multiplier;
                            }
                            if (index == 7)
                            {
                                answer8.Text = answer;
                                answer8.Image = null;
                                Points += 1 * multiplier;
                            }
                            tbAnswer.Text = "";
                            lastCorrectTriedAnswer = answer.Trim().ToLower();
                        }


                    }
                    if(noAnswerFound)
                        {
                        if (WrongSoundPlayer.IsLoadCompleted == true)
                        {
                            WrongSoundPlayer.Play();
                        }
                        tbAnswer.Text = "";
                        if (flagPoints == 0)
                        {
                            flagPoints = 1;
                            if (Points > 0)
                                Points -= 1;
                        }
                    }
                }
                label2.Text = Points.ToString();
                flagPoints = 0;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Time == 0)  //limit your timer according to the ticks the timer has done 300 ~= 35 seconds
            {
                //reset the timer and load a new question
                timer1.Stop();
                answers.Clear();
                nextQuestion();
                timer1.Start();
                if (Diff.Equals("Easy"))
                {
                    Time = 41;
                }
                if (Diff.Equals("Normal"))
                {
                    Time = 31;
                }
                if (Diff.Equals("Hard"))
                {
                    Time = 21;
                }
                tbAnswer.Text = "";
            }
            Time--;
            questionTime.Text = Time.ToString();
            if (Time < 10)
            {
                questionTime.ForeColor = Color.Red;
            }
            else
            {
                questionTime.ForeColor = Color.White;
            }
        }

        //Resets all the answers so they are not visible to the player, only used when the nextQuestion function is triggered
        private void resetImages()
        {
            answer1.Text = "";
            answer1.Image = Properties.Resources.QuestionMark;
            answer2.Text = "";
            answer2.Image = Properties.Resources.QuestionMark;
            answer3.Text = "";
            answer3.Image = Properties.Resources.QuestionMark;
            answer4.Text = "";
            answer4.Image = Properties.Resources.QuestionMark;
            answer5.Text = "";
            answer5.Image = Properties.Resources.QuestionMark;
            answer6.Text = "";
            answer6.Image = Properties.Resources.QuestionMark;
            answer7.Text = "";
            answer7.Image = Properties.Resources.QuestionMark;
            answer8.Text = "";
            answer8.Image = Properties.Resources.QuestionMark;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Time = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameDone();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void MainGame_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
