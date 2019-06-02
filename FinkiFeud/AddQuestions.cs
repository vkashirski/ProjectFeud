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
    public partial class AddQuestions : Form
    {
        public AddQuestions()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbQuestion.Text))
            {
                errorQuestion.SetError(tbQuestion, "No Question Entered.");
            }
            //save question to Questions.txt
            else
            {
                String question = tbQuestion.Text;
                String answer1 = tbAnswer1.Text;
                String answer2 = tbAnswer2.Text;
                String answer3 = tbAnswer3.Text;
                String answer4 = tbAnswer4.Text;
                String answer5 = tbAnswer5.Text;
                String answer6 = tbAnswer6.Text;
                String answer7 = tbAnswer7.Text;
                String answer8 = tbAnswer8.Text;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine();
                sb.Append(question);
                sb.AppendLine();
                sb.Append(answer1);
                sb.AppendLine();
                sb.Append(answer2);
                sb.AppendLine();
                sb.Append(answer3);
                sb.AppendLine();
                sb.Append(answer4);
                sb.AppendLine();
                sb.Append(answer5);
                sb.AppendLine();
                sb.Append(answer6);
                sb.AppendLine();
                sb.Append(answer7);
                sb.AppendLine();
                sb.Append(answer8);
                sb.AppendLine();
                sb.Append("~");
                String final = sb.ToString();

                //read txt
                String questionsFile = File.ReadAllText("Questions.txt");

                //write
                String newQuestion = questionsFile + final;
                using (StreamWriter sw = File.CreateText("Questions.txt"))
                {
                    sw.Write(newQuestion);
                }

                //close
                this.Close();
            }
        }

        private void tbQuestion_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbQuestion.Text = "";
            tbAnswer1.Text = "/";
            tbAnswer2.Text = "/";
            tbAnswer3.Text = "/";
            tbAnswer4.Text = "/";
            tbAnswer5.Text = "/";
            tbAnswer6.Text = "/";
            tbAnswer7.Text = "/";
            tbAnswer8.Text = "/";
        }
    }
}
