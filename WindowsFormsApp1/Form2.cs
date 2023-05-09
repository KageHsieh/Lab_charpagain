using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CProduct x = new CProduct();
            x.setBarcode("3141592653");
            x.setName("味全化學奶");
            x.setPrice(100);


            string msg = x.getName() + "(" + x.getBarcode() + ")\r\n================\r\n";
            msg += "價格:" + x.getPrice().ToString();
            MessageBox.Show(msg);

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cproduct2 x = new Cproduct2();
            x.barcode="3141592653";
            x.name="味全化學奶";
            x.price=100;


            string msg = x.name + "(" + x.barcode + ")\r\n================\r\n";
            msg += "價格:" + x.price.ToString();
            MessageBox.Show(msg);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            constructor.aa X=new constructor.aa();
        }
    }
}
