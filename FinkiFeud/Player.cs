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
        public String Difficulty { get; set; }
        public Image PlayerIcon { get; set; }
        public Player(int points, string name, String difficulty, Image playerIcon)
        {
            Points = points;
            Name = name;
            this.Difficulty = difficulty;
            PlayerIcon = playerIcon;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", Name, Points);
        }
    }
}