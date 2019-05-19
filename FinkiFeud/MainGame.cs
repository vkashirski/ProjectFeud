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
        bool questionsAcessible = false;
        DateTime startTime;
        public List<String> answers = new List<String>();
        public MainGame()
        {
            InitializeComponent();
            nextQuestion();
            
            timer1.Tick += (s, ev) => { questionTime.Text = String.Format("{0:00}:{1:00}",0,(DateTime.Now - startTime).Seconds); };
            
            startTime = DateTime.Now;
            timer1.Interval = 100;       // every 1/10 of a second
            timer1.Start();
        }
        public void nextQuestion()
        {
           
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
                questionsAcessible = true;
            }
            else
            {
                tbQuestion.Text = divided[1];
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
                questionsAcessible = true;
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
            String triedAnswer = tbAnswer.Text.Trim();
            int count = 0;
            foreach (String answer in answers)
            {
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
            if (count >= 3) {
                answers.Clear();
                nextQuestion();
            }
           
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            count++;
            if (count == 300)  //or whatever your limit is
            {
                timer1.Stop();
                answers.Clear();
                resetImages();
                nextQuestion();
                count = 0;
                startTime = DateTime.Now;
                timer1.Start();
            }
        }


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
