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
    public partial class DrawImageRun : TestRun
    {
        Bitmap backBuffer;
        Graphics drawingArea;

        public DrawImageRun(Image image) : base()
        {
            Size = new Size(image.Width, image.Height);

            backBuffer = new Bitmap(image.Width, image.Height);
            drawingArea = Graphics.FromImage(backBuffer);

            drawingArea.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            Show();
        }

        public override void Test(Image image)
        {
            drawingArea.DrawImage(image, 0, 0);
            CreateGraphics().DrawImage(backBuffer, 0, 0);
        }
    }
}
