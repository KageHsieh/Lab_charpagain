using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_again
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonHelloForm_Click(object sender, EventArgs e)
        {
            helloForm frm = new helloForm();
            frm.Show();
        }

        private void buttonMethodPractice_Click(object sender, EventArgs e)
        {
            {
                M();
            }
            
                void M()
                {
                    string Name = "Kage";
                    MessageBox.Show("My name is " + Name + ", this is my first method.");

                }
            
        }

        private void buttonReturnPractice_Click(object sender, EventArgs e)
        {
            {
                string result = BirthYear(30);
                MessageBox.Show(result);
            }
            string BirthYear(int Age)
            {
                int birthYear = DateTime.Now.Year - Age;
                return "出生年為" + birthYear + "年";
            }
        }

        private void buttonMyNewClass_Click(object sender, EventArgs e)
        {
            MyNewClass mc = new MyNewClass();
            mc.Method03();
        }

        private void buttonEnc_Click(object sender, EventArgs e)
        {
            MyNewClass mc = new MyNewClass();
            mc.Method04();
        }

        private void buttonPartialClass_Click(object sender, EventArgs e)
        {
            MyNewClass mc = new MyNewClass();
            mc.method06();
        }
    }
}
