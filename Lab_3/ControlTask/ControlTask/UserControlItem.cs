using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTask
{
    public partial class UserControlItem : UserControl
    {
        public UserControlItem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле Имя не может содержать цифры");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле ID не может содержать буквы");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text += "Имя: " + this.textBox1.Text + "\n";
            this.richTextBox1.Text += "ID: " + this.textBox2.Text + "\n\n";

            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }
    }
}
