using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CProduct
    {
        private string barcode;
        private string name;
        private double price;
        

        public void setBarcode(string p)
        {
            barcode = p;
        }
        public void setName(string p)
        {
            name = p;
        }
        public void setPrice(double p)
        {
            price = p;
        }

        public string getBarcode()
        {
            return barcode;
        }

        public string getName()
        {
            return name;
        }


        public double getPrice()
        {
            if (price < 134.4) 
            {
                price = 134;
            }
            return price;

        }




    }
}
