using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinkiFeud
{
    public class MazePlayer: Player
    {
        public Point Location { get; set; }
        public MazePlayer(int num,string username, string difficulty, Image playerIcon,Point startLocation) : base(num, username, difficulty, playerIcon)
        {
            Location = startLocation;
        }

        public void Draw(Graphics g)
        {
           
            g.DrawImage(PlayerIcon,Location,new Rectangle(Location.X,Location.Y,108,108),new GraphicsUnit());
        }

        public void moveUp(int l,int t, int w, int h)
        {
            Location = new Point(Location.X, Location.Y + 10);
        }
        public void moveDown(int l, int t, int w, int h)
        {
            Location = new Point(Location.X, Location.Y -10);
        }
        public void moveLeft(int l, int t, int w, int h)
        {
            Location = new Point(Location.X-10, Location.Y);
        }
        public void moveRight(int l, int t, int w, int h)
        {
            Location = new Point(Location.X+10, Location.Y);
        }
    }
}
