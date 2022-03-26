using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class EquationSolverForm : Form
    {
        public double A
        {
            get { return Convert.ToDouble(TextBoxA.Text); }
            set { TextBoxA.Text = value.ToString(); }
        }
        
        public double B
        {
            get { return Convert.ToDouble(TextBoxB.Text); }
            set { TextBoxB.Text = value.ToString(); }
        }
        
        public double C
        {
            get { return Convert.ToDouble(TextBoxC.Text); }
            set { TextBoxC.Text = value.ToString(); }
        }

        public EquationSolverForm()
        {
            InitializeComponent();
        }
    }
}
