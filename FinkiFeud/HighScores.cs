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
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
            dataGridHighscores.DataSource = null;
            dataGridHighscores.Rows.Clear();
            dataGridHighscores.Refresh();
        }

        private void HighScores_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridHighscores.DataSource = null;
            dataGridHighscores.Rows.Clear();
        }
    }
}
