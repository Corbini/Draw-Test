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
    public partial class BufferedDrawMatrixPartsRun : TestRun
    {
        BufferedGraphicsContext context;
        BufferedGraphics grafx;
        int count;

        public BufferedDrawMatrixPartsRun(Image image) : base()
        {
            Size = new Size(image.Width, image.Height);

            context = BufferedGraphicsManager.Current;
            context.MaximumBuffer = new Size(image.Width + 1, image.Height + 1);

            grafx = context.Allocate(CreateGraphics(),
                 new Rectangle(0, 0, image.Width, image.Height));

            grafx.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            count = 0;

            Show();
        }

        public override void Test(Image image)
        {
            if (++count > 5)
            {
                count = 0;
                grafx.Graphics.FillRectangle(Brushes.Black, 0, 0, image.Width, image.Height);
            }

            uint deviation = 10;

            for (int i = 0; i < deviation; i++)
                for (int j = 0; j < deviation; j++)
                {
                    Rectangle rect = new Rectangle(0 + Convert.ToInt32(i * (image.Width / deviation)), 0 + Convert.ToInt32(j * (image.Height / deviation)),
                        Convert.ToInt32(image.Width / deviation), Convert.ToInt32(image.Height / deviation));
                    grafx.Graphics.DrawImage(image,
                        0 + i * (image.Width / deviation),
                        0 + j * (image.Height / deviation),
                        rect,
                        GraphicsUnit.Pixel
                        ) ;
                }

            grafx.Render(CreateGraphics());
        }
    }
}