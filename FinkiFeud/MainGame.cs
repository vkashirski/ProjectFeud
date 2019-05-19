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
        public List<String> answers = new List<String>();
        public MainGame()
        {
            InitializeComponent();
            nextQuestion();
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

                }
                
            }
           
        }
    }
}
