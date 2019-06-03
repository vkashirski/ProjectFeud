using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinkiFeud
{
    [Serializable]
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

        public override string ToString()
        {
            return string.Format("{0} : {1}", Name, Points);
        }
    }
}