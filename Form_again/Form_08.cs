using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_again
{
    public partial class Form_08 : Form
    {
        public Form_08()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
        //this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
        buttonRegister01.Click += new EventHandler(buttonRegister01_Click);
        buttonRegister02.Click += ButtonRegister02_Click;
        }

        private void ButtonRegister02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register02");
        }

        private void buttonRegister01_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Register01");
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("你覺得IU正嗎","請回答下面的問題",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

            if( result== DialogResult.Yes)
            {
                MessageBox.Show("說得好!");

            }

            if ( result== DialogResult.No) 
            {
                MessageBox.Show("Are you sure about that?");
            }
        }
    }
}
