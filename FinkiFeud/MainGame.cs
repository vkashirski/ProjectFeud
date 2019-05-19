using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        public List<Player> players = new List<Player>();
        public String Diff;
        public int multiplier = 1;
        public int Points = 0;

        //This list will contain the answers of the questions
        public List<String> answers = new List<String>();

        public MainGame()
        {
            InitializeComponent();
            DoubleBuffered = true;
            //Load the first question
            nextQuestion();

            //The timer initialization
            timer1.Start();

            //create list of players from Players.txt
            String playersFile = File.ReadAllText("Players.txt");
            String[] playersAndPoints = playersFile.Split(new string[] { "\n" }, StringSplitOptions.None);
            String name = "";
            int points = 0;
            for (int i = 0; i < playersAndPoints.Length; i++)
            {
                String[] player = playersAndPoints[i].Split('-');
                points = Convert.ToInt32(player[1]);
                name = player[0];
                Player p1 = new Player(points, name, "",null);
                players.Add(p1);
            }

            //current player
            Player currentPlayer = new Player(ChooseGame.player.Points, ChooseGame.player.Name, ChooseGame.player.difficulty,ChooseGame.player.PlayerIcon);
            Diff = currentPlayer.difficulty;
            textBox2.Text = currentPlayer.Name;
            pbPlayerIcon.Image = currentPlayer.PlayerIcon;

            //points multiplier
            if (Diff.Equals("Easy"))
                multiplier = 1;
            else if (Diff.Equals("Normal"))
                multiplier = 2;
            else if (Diff.Equals("Hard"))
                multiplier = 4;

            //difficulty time setting
            if (Diff.Equals("Easy"))
            {
                Time = 61;
            }
            if (Diff.Equals("Normal"))
            {
                Time = 41;
            }
            if (Diff.Equals("Hard"))
            {
                Time = 21;
            }
        }

        public void gameDone()
        {
            //get new info
            String name = ChooseGame.player.Name;
            String points = Points.ToString();
            String playersInfo = File.ReadAllText("Players.txt");
            String playerInfo = name + "-" + points;
            String final = playersInfo + "\n" + playerInfo;

            //write
            using (StreamWriter sw = File.CreateText("Players.txt"))
            {
                sw.Write(final);
            }

            //close game
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

        private void MainGame_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void MainGame_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String triedAnswer = tbAnswer.Text.Trim();//Contains the answer entered by the user once the button is clicked


            //Check if the answer the user has entered is anywhere in the list answers
            foreach (String answer in answers)
            {
                //If the answer is anywhere in the list find the index of where the answer is in the list and place it in the appropriate field in the form
                if (answer.Trim().ToLower() == triedAnswer.ToLower()) //smeniv od .Contains vo .Equals, posho primer ako napishesh 5, ti dava odgovor i 5 i 50.
                {
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
                }
               
            }
            label2.Text = Points.ToString();
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
                    Time = 61;
                }
                if (Diff.Equals("Normal"))
                {
                    Time = 41;
                }
                if (Diff.Equals("Hard"))
                {
                    Time = 21;
                }
            }
            Time--;
            questionTime.Text = Time.ToString();
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
    }
}
