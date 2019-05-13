using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinkiFeud
{
    public class Player
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public Image PlayerIcon { get; set; }

        public Player(int num, string name, Image img)
        {
            Number = num;
            Name = name;
            PlayerIcon = img;
        }

        public void Draw(Graphics g)
        {
            g.DrawImageUnscaled(PlayerIcon, 100, 100, 20, 20);

        }
    }
}