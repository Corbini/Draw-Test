using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection.Metadata;
using Draw_Test.Runs;

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
            methodes = new bool[20];
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
                result += RunTest("DrawImage", new DrawImageRun(image));

            if (methodes[1])
                result += RunTest("DrawImageUnscaled", new DrawImageUnscaledRun(image));

            if (methodes[2])
                result += RunTest("BufferedGraphicDraw", new BufferedGraphicDrawRun(image));

            if (methodes[3])
                result += RunTest("BufferedGraphicRefresh", new BufferedGraphicRefreshRun(image));

            if (methodes[4])
                result += RunTest("BufferedGraphicDrawUnscaled", new BufferedGraphicDrawUnscaledRun(image));

            if (methodes[5])
                result += RunTest("BufferedDrawMatrix", new BufferedDrawMatrixRun(image));

            if (methodes[6])
                result += RunTest("BufferedDrawPartsMatrix", new BufferedDrawMatrixPartsRun(image));

            if (textbox != null)
            {
                textbox.Clear();
                textbox.AppendText(result);
            }
        }

        private string RunTest(string name, TestRun test)
        {
            Debug.WriteLine($"Running: {name}");

            // Test buffor
            long elapsedMs = 0;
            for (int i = 0; i < testruns; i++)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                test.Test(image);

                watch.Stop();
                elapsedMs += watch.ElapsedMilliseconds;
            }
            elapsedMs /= testruns;

            Debug.WriteLine($"Average time: {elapsedMs} Ms");

            test.Hide();

            return $"Test {name}\nAverage time: {elapsedMs} Ms\n";
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
            if (0 <= methodes.Length && methodes.Length < place)
            {
                Debug.WriteLine($"Can't change methode run: incorrect place {place}");
                return;
            }

            Debug.WriteLine($"Methode run at {place} change to: {run}");
            methodes[place] = run;
        }
    }
}
