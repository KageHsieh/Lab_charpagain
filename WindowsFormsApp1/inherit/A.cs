using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.inherit
{
    public class A
    {
        public A() 
        {
            System.Windows.Forms.MessageBox.Show("這是A類別的建構子");
        }
        public A(int p)
        {
            System.Windows.Forms.MessageBox.Show("這是A類別的int建構子");
        }
        public void m1()
        {
            System.Windows.Forms.MessageBox.Show("這是A類別的m1()方法");
        }

        private void m2()
        {
            System.Windows.Forms.MessageBox.Show("這是A類別的m2()方法");
        }
    }
}
