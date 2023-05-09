using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cproduct2
    {
        private string _barcode;
        private string _name;
        private double _price;

        public string barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double price
        {
            get 
            {
                if (_price < 134.4)
                {
                    _price = 134;
                }
                
                return _price; 
            }
            set { _price = value; }
        }

    }
}
