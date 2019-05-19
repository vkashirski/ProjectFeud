using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinkiFeud
{
    public partial class ChooseGame : Form
    {
        public static Team Team1;
        public static Team Team2;
        public ChooseGame()
        {
            InitializeComponent();
        }

        private void nudTeam1_ValueChanged(object sender, EventArgs e)
        {
            if (nudTeam1.Value >= 2)
            {
                tbTeam1Player2.ReadOnly = false;
            }
            else
            {
                tbTeam1Player2.ReadOnly = true;
            }
            if (nudTeam1.Value >= 3)
            {
                tbTeam1Player3.ReadOnly = false;
            }
            else
            {
                tbTeam1Player3.ReadOnly = true;
            }
            if (nudTeam1.Value >= 4)
            {
                tbTeam1Player4.ReadOnly = false;
            }
            else
            {
                tbTeam1Player4.ReadOnly = true;
            }

            
        }

        private void nudTeam2_ValueChanged(object sender, EventArgs e)
        {
            if (nudTeam2.Value >= 1)
            {
                tbTeam2Player1.ReadOnly = false;
            }
            else
            {
                tbTeam2Player1.ReadOnly = true;
            }
            if (nudTeam2.Value >= 2)
            {
                tbTeam2Player2.ReadOnly = false;
            }
            else
            {
                tbTeam2Player2.ReadOnly = true;
            }
            if (nudTeam2.Value >= 3)
            {
                tbTeam2Player3.ReadOnly = false;
            }
            else
            {
                tbTeam2Player3.ReadOnly = true;
            }
            if (nudTeam2.Value >= 4)
            {
                tbTeam2Player4.ReadOnly = false;
            }
            else
            {
                tbTeam2Player4.ReadOnly = true;
            }
            
        }

        private void pbTeam1Player1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbTeam1Player1.Image = new Bitmap(open.FileName);
            }
        }

        private void pbTeam1Player2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbTeam1Player2.Image = new Bitmap(open.FileName);
            }
        }

        private void pbTeam1Player3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbTeam1Player3.Image = new Bitmap(open.FileName);
            }
        }

        private void pbTeam1Player4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbTeam1Player4.Image = new Bitmap(open.FileName);
            }
        }

        private void pbTeam2Player1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbTeam2Player1.Image = new Bitmap(open.FileName);
            }
        }

        private void pbTeam2Player2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbTeam2Player2.Image = new Bitmap(open.FileName);
            }
        }

        private void pbTeam2Player3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbTeam2Player3.Image = new Bitmap(open.FileName);
            }
        }

        private void pbTeam2Player4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbTeam2Player4.Image = new Bitmap(open.FileName);

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            /* Team1 = new Team((int)nudTeam1.Value);
            if (nudTeam1.Value >= 1) {
                Team1.Players.Add(new Player(1, tbTeam1Player1.Text, pbTeam1Player1.Image));
            }
            if (nudTeam1.Value >= 2)
            {
                Team1.Players.Add(new Player(2, tbTeam1Player2.Text, pbTeam1Player2.Image));
            }
            if (nudTeam1.Value >= 3)
            {
                Team1.Players.Add(new Player(3, tbTeam1Player3.Text, pbTeam1Player3.Image));
            }
            if (nudTeam1.Value >= 4)
            {
                Team1.Players.Add(new Player(4, tbTeam1Player4.Text, pbTeam1Player4.Image));
            }
            if (nudTeam2.Value >= 1)
            {
                Team2.Players.Add(new Player(1, tbTeam2Player1.Text, pbTeam2Player1.Image));
            }
            if (nudTeam2.Value >= 2)
            {
                Team2.Players.Add(new Player(2, tbTeam2Player2.Text, pbTeam2Player2.Image));
            }
            if (nudTeam2.Value >= 3)
            {
                Team2.Players.Add(new Player(3, tbTeam2Player3.Text, pbTeam2Player3.Image));
            }
            if (nudTeam2.Value >= 4)
            {
                Team2.Players.Add(new Player(4, tbTeam2Player4.Text, pbTeam2Player4.Image));
            }*/
            MainGame game = new MainGame();
            this.Hide();
            game.Closed += (s, args) => this.Close();
            game.Show();

        }
    }
}
