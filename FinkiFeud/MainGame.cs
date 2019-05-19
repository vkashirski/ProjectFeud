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
        DateTime startTime;

        //This list will contain the answers of the questions
        public List<String> answers = new List<String>();

        public MainGame()
        {
            InitializeComponent();
            DoubleBuffered = true;
            //Load the first question
            nextQuestion();
            
            //The timer initialization
            timer1.Tick += (s, ev) => { questionTime.Text = String.Format("{0:00}:{1:00}",0,(DateTime.Now - startTime).Seconds); };           
            startTime = DateTime.Now;
            timer1.Interval = 100;       // every 1/10 of a second
            timer1.Start();
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
                counter = 0;
                flag = false;
                MessageBox.Show("No more Questions");
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
                if (answer.Contains(triedAnswer))
                {
                    int index = answers.IndexOf(answer);
                    if (index == 0)
                    {
                        answer1.Text = answer;
                        answer1.Image = null;

                    }
                    if (index == 1)
                    {
                        answer2.Text = answer;
                        answer2.Image = null;

                    }
                    if (index == 2)
                    {
                        answer3.Text = answer;
                        answer3.Image = null;
                    }
                    if (index == 3)
                    {
                        answer4.Text = answer;
                        answer4.Image = null;
                    }
                    if (index == 4)
                    {
                        answer5.Text = answer;
                        answer5.Image = null;
                    }
                    if (index == 5)
                    {
                        answer6.Text = answer;
                        answer6.Image = null;
                    }
                    if (index == 6)
                    {
                        answer7.Text = answer;
                        answer7.Image = null;
                    }
                    if (index == 7)
                    {
                        answer8.Text = answer;
                        answer8.Image = null;
                    }
                    tbAnswer.Text = "";
                }
               
            }
           
        }

        //A counter for the timer
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           //Every tick increase the timer
            count++;
            if (count == 300)  //limit your timer according to the ticks the timer has done 300 ~= 35 seconds
            {
                //reset the timer and load a new question
                timer1.Stop();
                answers.Clear();
                nextQuestion();
                count = 0;
                startTime = DateTime.Now;
                timer1.Start();
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
    }
}
