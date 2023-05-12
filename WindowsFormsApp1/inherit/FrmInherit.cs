using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.inherit
{
    public partial class FrmInherit : Form
    {
        public FrmInherit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            B x=new B();
            x.m1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            B x = new B(123);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            B x = new B(123);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            B x = new B();
            x.m1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            B x = new B();
            x.m2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            C x = new C();
            x.m1();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CDerivedFromAdstract x =new CDerivedFromAdstract();
            x.m1();
        }
    }
}
