using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FinkiFeud
{
    [Serializable]
    public class Team
    {
        public int NumberOfPlayers { get; set; }
        public List<Player> Players;

        public Team(int num)
        {
            NumberOfPlayers = num;
            Players = new List<Player>();
        }

        public void DrawPlayers(Graphics g)
        {
            if (NumberOfPlayers >= 1)
            {
                Players[0].Draw(g);
            }
            if (NumberOfPlayers >= 2)
            {
                Players[1].Draw(g);
            }
            if (NumberOfPlayers >= 3)
            {
                Players[2].Draw(g);
            }
            if (NumberOfPlayers >= 4)
            {
                Players[3].Draw(g);
            }
        }
    }
}
