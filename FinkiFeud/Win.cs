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
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
            lbScore.Text = MainGame.finalScore.ToString();
            if (ChooseGame.windowedMode == false)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ChooseGame.goBack = true;
            this.Close();
        }
    }
}
