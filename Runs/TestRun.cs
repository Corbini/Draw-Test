using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_Test.Runs
{
    public partial class TestRun : Form
    {
        public TestRun() : base() { }

        public virtual void Test(Image image)
        {
            Debug.WriteLine("Test, TestRun: Run");
        }
    }
}