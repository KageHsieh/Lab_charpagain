using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_again
{
    public partial class MyNewClass
    {
        void Method01()
        {
            MessageBox.Show("Method01");
            }

        private void Method02() 
        
       {
            MessageBox.Show("Method02");
        }

        public void Method03() 
        {
            MessageBox.Show("哈哈是我啦!");
        }
        public void Method04() 
        {
            Method01();
            Method02();
        }








    }
}
