using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_to_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Decline_Click(object sender, EventArgs e)
        {

            this.Close();

            Form1 form1 = new Form1();
            form1.textBox1.Text = DataBank.Text;
            form1.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DataBank.Text = this.textBox1.Text;
            this.Close();

            Form1 form1 = new Form1();
            form1.textBox1.Text = DataBank.Text;
            form1.Show();
        }
    }
}
