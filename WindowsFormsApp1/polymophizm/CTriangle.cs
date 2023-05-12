using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.polymophizm
{
    public class CTriangle:IShap,IColor
    {
        public void fillColor()
        {
            MessageBox.Show("blue");
        }
        public void paint()
        {
            MessageBox.Show("劃出三角形");
        }
    }

}
