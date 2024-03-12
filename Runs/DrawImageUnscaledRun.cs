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
    public partial class DrawImageUnscaledRun : TestRun
    {
        Bitmap backBuffer;
        Graphics drawingArea;

        public DrawImageUnscaledRun(Image image) : base()
        {
            Size = new Size(image.Width, image.Height);

            backBuffer = new Bitmap(image.Width, image.Height);
            drawingArea = Graphics.FromImage(backBuffer);

            Show();
        }

        public override void Test(Image image)
        {
            drawingArea.DrawImageUnscaled(image, 0, 0);
            CreateGraphics().DrawImageUnscaled(backBuffer, 0, 0);
        }
    }
}
