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
        public Player MainPlayer { get; set; }
        public int Score { get; set; }
        public int Time { get; set; }
        public int QuestionsPassed { get; set; }

        public int QuestionsSkipped { get; set; }

        public bool passedMaze { get; set; }
        public int Multiplier { get; set; }
        public PlayerDoc(Player p)
        {
            MainPlayer = p;
        }

        public void getTimeFromDifficulty()
        {
            if (MainPlayer.Difficulty.Equals("Easy"))
            {
                this.Time = 41;
            }
            if (MainPlayer.Difficulty.Equals("Normal"))
            {
                this.Time = 31;
            }
            if (MainPlayer.Difficulty.Equals("Hard"))
            {
                this.Time = 21;
            }
        }

        public void getScoreMultiplier()
        {
            if (MainPlayer.Difficulty.Equals("Easy"))
                Multiplier = 1;
            else if (MainPlayer.Difficulty.Equals("Normal"))
                Multiplier = 2;
            else if (MainPlayer.Difficulty.Equals("Hard"))
                Multiplier = 3;
        }

        public void updateScore(int answerPoints)
        {
            if (passedMaze)
            {
                Score += 100 + MazeFinale.passedTime;
            }

            Score += answerPoints * this.Multiplier;
        }
    }
}
