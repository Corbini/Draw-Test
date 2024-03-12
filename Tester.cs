using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection.Metadata;

namespace Draw_Test
{
    public partial class Tester
    {
        public uint testruns;
        Image image;
        bool[] methodes;
        private RichTextBox? textbox;

        public Tester()
        {
            testruns = 10;
            image = Image.FromFile("test_screen.jpg");
            methodes = new bool[4];
        }

        public void SetTextBox(RichTextBox textbox)
        {
            this.textbox = textbox;
        }

        public void Run(bool debug = false)
        {
            Debug.WriteLine("Test is starting");
            Debug.WriteLine($"Amount of loops: {testruns}");

            string result = "";

            if (methodes[0])
                result += run0(debug);

            if (methodes[1])
                result += run1(debug);

            if (methodes[2])
                result += run2(debug);

            if (textbox != null)
            {
                textbox.Clear();
                textbox.AppendText(result);
            }
        }

        private string run0(bool debug = false)
        {
            Debug.WriteLine($"Running: run0");

            // Initialize methode for the buffor

            Form myform = new Form();
            myform.Size = new Size(this.image.Width, this.image.Height);
            myform.Show();

            Bitmap backBuffer = new Bitmap(this.image.Width, this.image.Height);
            Graphics drawingArea = Graphics.FromImage(backBuffer);

            // Test buffor
            long elapsedMs = 0;
            for (int i = 0; i < testruns; i++)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                drawingArea.DrawImage(image, 0, 0);
                

                myform.CreateGraphics().DrawImage(backBuffer, 0, 0);
                //buffor call

                watch.Stop();
                elapsedMs += watch.ElapsedMilliseconds;
            }
            elapsedMs /= testruns;

            Debug.WriteLine($"Average time: {elapsedMs} Ms");

            if (debug)
                myform.ShowDialog();

            myform.Hide();
            return $"Methode run0\nAverage time: {elapsedMs} Ms\n";
        }

        private string run1(bool debug = false)
        {
            Debug.WriteLine($"Running: run1");

            // Initialize methode for the buffor

            Form myform = new Form();
            myform.Size = new Size(this.image.Width, this.image.Height);
            myform.Show();

            BufferedGraphicsContext context = BufferedGraphicsManager.Current;
            context.MaximumBuffer = new Size(image.Width + 1, image.Height + 1);

            BufferedGraphics grafx = context.Allocate(myform.CreateGraphics(),
                 new Rectangle(0, 0, image.Width, image.Height));

            int count = 0;

            // Test buffor
            long elapsedMs = 0;
            for (int i = 0; i < testruns; i++)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                //buffor call

                // clear view as specified in documentation
                if (++count > 5)
                {
                    count = 0;
                    grafx.Graphics.FillRectangle(Brushes.Black, 0, 0, image.Width, image.Height);
                }

                grafx.Graphics.DrawImage(image, 0, 0);
                grafx.Render(myform.CreateGraphics());

                watch.Stop();
                elapsedMs += watch.ElapsedMilliseconds;
            }
            elapsedMs /= testruns;

            Debug.WriteLine($"Average time: {elapsedMs} Ms");

            if (debug)
                myform.ShowDialog();

            myform.Hide();
            return $"Methode run2\nAverage time: {elapsedMs} Ms\n";
        }
        public class BufferingExample : Form
        {
            public BufferedGraphics grafx;

            public BufferingExample(int width, int height) : base()
            {
                this.Size = new Size(width, height);

                BufferedGraphicsContext context = BufferedGraphicsManager.Current;
                context.MaximumBuffer = new Size(width + 1, height + 1);
                grafx = context.Allocate(this.CreateGraphics(),
                     new Rectangle(0, 0, width, height));
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                grafx.Render(e.Graphics);
            }
        }

        private string run2(bool debug = false)
        {
            Debug.WriteLine($"Running: run2");

            // Initialize methode for the buffor

            BufferingExample myform = new BufferingExample(this.image.Width, this.image.Height);
            myform.Show();

            int count = 0;

            // Test buffor
            long elapsedMs = 0;
            for (int i = 0; i < testruns; i++)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                //buffor call

                // clear view as specified in documentation
                if (++count > 5)
                {
                    count = 0;
                    myform.grafx.Graphics.FillRectangle(Brushes.Black, 0, 0, image.Width, image.Height);
                }

                myform.grafx.Graphics.DrawImage(image, 0, 0);
                myform.Refresh();

                watch.Stop();
                elapsedMs += watch.ElapsedMilliseconds;
            }
            elapsedMs /= testruns;

            Debug.WriteLine($"Average time: {elapsedMs} Ms");

            if (debug)
                myform.ShowDialog();

            myform.Hide();
            return $"Methode run2\nAverage time: {elapsedMs} Ms\n";
        }

        public void Load(string path)
        {
            Debug.WriteLine($"Opening file: {path}");
            try
            {
                image = Image.FromFile(path);
            }
            catch
            {
                Debug.WriteLine($"App can't open: {path}");
            }
        }

        public void Change(int place, bool run)
        {
            if (methodes.Length < place)
            {
                Debug.WriteLine($"Can't change methode run: incorrect place {place}");
                return;
            }

            Debug.WriteLine($"Methode run at {place} change to: {run}");
            methodes[place] = run;
        }

        static void TestRun(string run_name, string text)
        {
            Console.WriteLine("Testing: " + run_name);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(text);
            }
        }

        static void loadBitmap(string run_name, string text)
        {
            Console.WriteLine("Testing: " + run_name);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}
