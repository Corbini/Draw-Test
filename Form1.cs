using System.Diagnostics;

namespace Draw_Test
{
    public partial class Form1 : Form
    {
        private Tester tester;


        public Form1(Tester tester)
        {
            this.tester = tester;

            InitializeComponent();
        }

        public RichTextBox getResultTextBox()
        {
            return richTextBox1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tester.Run();
        }

        // change Bitmap
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            tester.Load(openFileDialog1.FileName);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            this.tester.testruns = Convert.ToUInt32(this.numericUpDown1.Value);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.tester.Change(2, checkBox4.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.tester.Change(1, checkBox2.Checked);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.tester.Change(0, checkBox1.Checked);
        }
    }
}
