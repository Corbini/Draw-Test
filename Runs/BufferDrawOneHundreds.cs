using Draw_Test.Runs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace Draw_Test.Runs
{
    public partial class BufferedDrawOneHundredsRun : TestRun
    {
        BufferedGraphicsContext context;
        BufferedGraphics grafx;
        int count;
        Image imagePart;

        public BufferedDrawOneHundredsRun(Image image) : base()
        {
            Size = new Size(image.Width, image.Height);

            context = BufferedGraphicsManager.Current;
            context.MaximumBuffer = new Size(image.Width + 1, image.Height + 1);

            grafx = context.Allocate(CreateGraphics(),
                 new Rectangle(0, 0, image.Width, image.Height));

            grafx.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            grafx.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);

            count = 0;

            uint deviation = 10;
            int sizeX = Convert.ToInt32(image.Width / deviation);
            int sizeY = Convert.ToInt32(image.Height / deviation);

            Rectangle rect = new Rectangle(sizeX, sizeY, sizeX, sizeY);
            Bitmap tempBitmap = new Bitmap(image);

            imagePart = tempBitmap.Clone(rect, tempBitmap.PixelFormat);

            Show();
        }

        public override void Test(Image image)
        {
            grafx.Graphics.DrawImage(imagePart, 0, 0);

            grafx.Render(CreateGraphics());
        }
    }
}