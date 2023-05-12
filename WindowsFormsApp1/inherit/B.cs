using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.inherit
{
    public class B:A
    {
        public B() 
        {
            System.Windows.Forms.MessageBox.Show("這是B類別的建構子");
        }

        public B(int p):base(123)
        {
            System.Windows.Forms.MessageBox.Show("這是B類別的int建構子");
        }

        public void m1() 
        {
            System.Windows.Forms.MessageBox.Show("這是B類別的m1()方法");
        }

        public void m2()
        {
            base.m1();
        }


    }
}
