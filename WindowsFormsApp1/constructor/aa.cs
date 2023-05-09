using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.constructor
{
    public class aa
    {
        public aa() {
            MessageBox.Show("這是aa類別，無參數的建構子");
        }

        public aa(int p)
        {
            MessageBox.Show("這是aa類別，有int參數的建構子");
        }

        

    }
}
