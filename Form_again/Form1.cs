using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Form_again
{
    public partial class helloForm : Form
    {
        public helloForm()
        {
            InitializeComponent();
        }

        private void buttonSayHello_Click(object sender, EventArgs e)
        {
            string Name = textBoxName.Text;
            MessageBox.Show("Hello!"+Name);
        }
    }
}
