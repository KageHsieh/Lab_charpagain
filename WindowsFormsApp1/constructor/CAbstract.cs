using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.inherit;

namespace WindowsFormsApp1.constructor
{
    public abstract class CAbstract:C
    {
        public void m1()
        {
            System.Windows.Forms.MessageBox.Show("這是CAbstract類別的m1()方法");
        }
    }
}
