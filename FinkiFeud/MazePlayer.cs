using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinkiFeud
{
    public class MazePlayer: Player
    {
        public Point Location { get; set; }
        public int velocity;
        public MazePlayer(int num,string username, string difficulty, Image playerIcon,Point startLocation) : base(num, username, difficulty, playerIcon)
        {
            Location = startLocation;
            PlayerIcon = ResizeImage(PlayerIcon, 80, 80);
            velocity = 107;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(PlayerIcon,Location);
        }

        public void moveUp(int l,int t, int w, int h)
        {
            if (Location.Y-velocity-10 >= t -velocity)
            {
                Location = new Point(Location.X, Location.Y - velocity);
            }
            
        }
        public void moveDown(int l, int t, int w, int h)
        {
            if (Location.Y+velocity+10 <= t+ h-100+velocity)
            {
                Location = new Point(Location.X, Location.Y + velocity);
            }
        }
        public void moveLeft(int l, int t, int w, int h)
        {
            
            if (Location.X-velocity-10>= l+5-velocity)
            {
                Location = new Point(Location.X - velocity, Location.Y);
            }
        }
        public void moveRight(int l, int t, int w, int h)
        {
            if (Location.X+velocity+10 <= l+w-75+velocity)
            {
                Location = new Point(Location.X + velocity, Location.Y);
            }
        }

        //Need this function for resizing the avatar image to be able to draw it smaller in size.
        //Resource: https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp
        //Resource was available on Friday, June 14, 2019
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
