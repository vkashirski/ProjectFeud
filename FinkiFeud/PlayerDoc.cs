using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinkiFeud
{
    [Serializable]
    public class PlayerDoc
    {
        public Player player { get; set; }
        public int HighScore { get; set; }

        public int QuestionsPassed { get; set; }

        public int QuestionsSkipped { get; set; }

        public PlayerDoc(Player p)
        {
            p = player;
        }
    }
}
