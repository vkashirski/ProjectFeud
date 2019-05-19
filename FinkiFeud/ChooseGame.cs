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
        public static Player player = new Player(0, "", "",null);
        public ChooseGame()
        {
            InitializeComponent();
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
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            String name = tbTeam1Player1.Text;
            String diff = comboBox1.Text;
            int points = 0;
            Image playerIcon = pbTeam1Player1.Image;
            Player p1 = new Player(points, name, diff,playerIcon);
            player = p1;
            
            MainGame game = new MainGame();
            this.Hide();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }
    }
}
