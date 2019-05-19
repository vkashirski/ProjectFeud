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
        public int Points { get; set; }
        public string Name { get; set; }
        public String difficulty { get; set; }
        public Image PlayerIcon { get; set; }
        public Player(int num, string name, String difficulty, Image playerIcon)
        {
            Points = num;
            Name = name;
            this.difficulty = difficulty;
            PlayerIcon = playerIcon;
        }
       
    }
}