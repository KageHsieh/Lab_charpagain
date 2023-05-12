using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.polymophizm
{
    public class CCustomerManager
    {
        public INotify f;
        public DNotify f2;
        public void save()
        {
            if (f != null) 
            f.success();
            if (f2 != null)
            f2();
        }
    }
}
