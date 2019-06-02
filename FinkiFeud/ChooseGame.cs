using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinkiFeud
{
    public partial class ChooseGame : Form
    {
        public static Player player = new Player(0, "", "",null);
        public static int counter = 1;
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

        private void button2_Click(object sender, EventArgs e)
        {
            AddQuestions add = new AddQuestions();
            
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String playersInfo = File.ReadAllText("Players.txt");
            String[] players = playersInfo.Split('~');
            foreach(String player in players)
            {
                String[] info = player.Split('-');
                String name = info[0];
                name = Regex.Replace(name, @"\t|\n|\r", "");
                int points = Convert.ToInt32(info[1]);
                Player p1 = new Player(points, name, null, null);
                MainGame.players.Add(p1);
            }
            List<Player> SortedPlayers = MainGame.players.OrderByDescending(o => o.Points).ToList();

            StringBuilder sb = new StringBuilder();
            sb.Append("Highscores:");
            foreach (Player p in SortedPlayers)
            {
                sb.AppendLine();
                sb.Append(counter++.ToString() + ". ");
                sb.Append(p.Name + " - " + p.Points);
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
