using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.polymophizm
{
    public partial class FrmPolymophizm : Form, INotify
    {
        public FrmPolymophizm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CCanvas x = new CCanvas();
            CTriangle t = new CTriangle();
            x.start(t);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CCanvas x = new CCanvas();
            CTriangle t = new CTriangle();
            x.fill(t);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CCanvas y = new CCanvas();
            CQuater t = new CQuater();
            y.start(t);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CCanvas y = new CCanvas();
            CQuater t = new CQuater();
            y.fill(t);
        }

        public void success()
        {
            MessageBox.Show("資料儲存成功");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CCustomerManager x = new CCustomerManager();
            x.f = this;
            x.f2 = this.success;
            x.save();
        }
    }
}
