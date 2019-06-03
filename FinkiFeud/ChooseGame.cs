using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
        String FileName;
        MainGame game;
        public List<Player> SortedPlayers;
        public static bool windowedMode;
        public static bool backgroundMusic;
        public static bool backgroundSound;
        public ChooseGame()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            
            String playersInfo = File.ReadAllText("Players.txt");
            String[] players = playersInfo.Split('~');
            if (playersInfo!= null)
            {
                foreach (String player in players)
                {
                    String[] info = player.Split('-');
                    String name = info[0];
                    name = Regex.Replace(name, @"\t|\n|\r", "");
                    int points = Convert.ToInt32(info[1]);
                    Player p1 = new Player(points, name, null, null);
                    MainGame.players.Add(p1);
                }
            }
            SortedPlayers = MainGame.players.OrderByDescending(o => o.Points).ToList();
        }
        private void pbTeam1Player1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            FileName = "Untitled";

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
            Image playerIcon = null;
            if (pbTeam1Player1.Image != null)
            {
                playerIcon = pbTeam1Player1.Image;
            }
            else
            {
                playerIcon = Properties.Resources.avatar_generic;
            }
            Player p1 = new Player(points, name, diff,playerIcon);
            player = p1;
            windowedMode = rbWindowed.Checked;
            backgroundMusic = cbBackgroundMusic.Checked;
            backgroundSound = cbSounds.Checked;
            game = new MainGame();
            this.Hide();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestions add = new AddQuestions();           
            add.Show();
        }

        private void btnHighscores_Click(object sender, EventArgs e)
        {
            HighScores highScores = new HighScores();
            int count = 0;
            foreach (Player p in SortedPlayers)
            {
                if (count < 10) {
                    DataGridViewRow row = (DataGridViewRow)highScores.dataGridHighscores.Rows[0].Clone();
                    row.Cells[0].Value = p.Name;
                    row.Cells[1].Value = p.Points;
              
                    row.HeaderCell.Value = String.Format("{0}", count+1);
                    highScores.dataGridHighscores.Rows.Add(row);
                    count++;
                }


            }

            highScores.ShowDialog();
            /*String playersInfo = File.ReadAllText("Players.txt");
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
            */
        }

        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Circles doc file (*.crl)|*.crl";
            openFileDialog.Title = "Open Circles doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        player = (Player)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = "Untitled";
                    return;
                }
                Invalidate(true);
            }
        }

        private void loadPreviousGame_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void ChooseGame_Load(object sender, EventArgs e)
        {

        }
    }
}
