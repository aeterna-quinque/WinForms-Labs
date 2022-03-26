using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsControlTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddPolygon(new Point[] { 
                new Point(Width/2, Height),
                new Point(Width, Height/2),
                new Point(Width/2, 0),
                new Point(0, Height/2)});
            Region myRegion = new Region(myPath);
            Region = myRegion;

            int xPos = Width / 2 - button1.Width / 2;
            int yPos = Height / 2 - button1.Height / 2;
            button1.Location = new Point(xPos, yPos);
        }
    }
}