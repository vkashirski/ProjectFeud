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
        public MainGame()
        {
            InitializeComponent();
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
                textBox4.Text = divided[0];
                button1.Text = divided[1];
                button3.Text = divided[2];
                button7.Text = divided[3];
                button10.Text = divided[4];
                button2.Text = divided[5];
                button6.Text = divided[6];
                button8.Text = divided[7];
                button11.Text = divided[8];
            }
            else
            {
                textBox4.Text = divided[1];
                button1.Text = divided[2];
                button3.Text = divided[3];
                button7.Text = divided[4];
                button10.Text = divided[5];
                button2.Text = divided[6];
                button6.Text = divided[7];
                button8.Text = divided[8];
                button11.Text = divided[9];
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
            nextQuestion();
        }
    }
}
