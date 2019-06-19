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
    public partial class SplashScreen : Form
    {
        Player currentPlayer;
        public SplashScreen()
        {
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Start();
            
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            currentPlayer = new Player(ChooseGame.player.Points, ChooseGame.player.Name, ChooseGame.player.Difficulty, ChooseGame.player.PlayerIcon);
            label2.Text = currentPlayer.Name;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
