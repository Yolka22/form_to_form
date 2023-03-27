using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_to_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
            
            textBox1.ReadOnly = true;

            if (textBox1.Text != "")
            {
                Edit_Button.Enabled = true;
            }
            else Edit_Button.Enabled = false;
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            if (fileDialog.FileName != "")
            {
                Edit_Button.Enabled = true;

                StreamReader sr = new StreamReader(fileDialog.FileName);

                textBox1.Text = sr.ReadToEnd();

                sr.Close();
            }

        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            DataBank.Text = this.textBox1.Text;

            Form2 form2 = new Form2();
            form2.Show();
            form2.textBox1.Text = textBox1.Text;

            this.Hide();
        }
    }
}
