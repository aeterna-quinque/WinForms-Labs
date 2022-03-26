using System;
using System.Windows.Forms;

namespace WindowsFormsControlTask2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newChild = new Form1();
            newChild.Show();
        }
    }
}
