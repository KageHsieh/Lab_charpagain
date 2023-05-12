using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.polymophizm
{
    public class CCanvas
    {
        public void start(IShap p) 
        {
            p.paint();
        }

        public void fill(IColor p)
        {
            p.fillColor();
        }
    }
}
