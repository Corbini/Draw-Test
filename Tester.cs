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

        public void Run()
        {
            Debug.WriteLine("Test is starting");
            Debug.WriteLine($"Amount of loops: {testruns}");

            string result = "";

            Bitmap img = new Bitmap(this.image.Width, this.image.Height);
            Graphics graphic = Graphics.FromImage(img);

            if (methodes[0])
                result += run0(graphic);

            if (methodes[1])
                result += run1(graphic);

            if (methodes[2])
                result += run2(graphic);

            if (textbox != null)
            {
                textbox.Clear();
                textbox.AppendText(result);
            }
        }

        private string run0(Graphics graphic)
        {
            Debug.WriteLine($"Running: run0");

            // Initialize methode for the buffor

            Bitmap backBuffer = new Bitmap(this.image.Width, this.image.Height);
            Graphics drawingArea = Graphics.FromImage(backBuffer);

            // Test buffor
            long elapsedMs = 0;
            for (int i = 0; i < testruns; i++)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                //buffor call
                graphic.DrawImage(backBuffer, 0, 0);

                watch.Stop();
                elapsedMs += watch.ElapsedMilliseconds;
            }
            elapsedMs /= testruns;

            Debug.WriteLine($"Average time: {elapsedMs} Ms");

            return $"Methode run0\nAverage time: {elapsedMs} Ms\n";
        }

        private string run1(Graphics graphic)
        {
            Debug.WriteLine($"Running: run1");

            // Initialize methode for the buffor



            // Test buffor
            long elapsedMs = 0;
            for (int i = 0; i < testruns; i++)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                //buffor call

                watch.Stop();
                elapsedMs += watch.ElapsedMilliseconds;
            }
            elapsedMs /= testruns;

            Debug.WriteLine($"Average time: {elapsedMs} Ms");

            return $"Methode run1\nAverage time: {elapsedMs} Ms\n";
        }

        private string run2(Graphics graphic)
        {
            Debug.WriteLine($"Running: run2");

            // Initialize methode for the buffor



            // Test buffor
            long elapsedMs = 0;
            for (int i = 0; i < testruns; i++)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                //buffor call

                watch.Stop();
                elapsedMs += watch.ElapsedMilliseconds;
            }
            elapsedMs /= testruns;

            Debug.WriteLine($"Average time: {elapsedMs} Ms");

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
