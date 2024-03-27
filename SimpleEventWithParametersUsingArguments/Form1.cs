using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEventWithParametersUsingArguments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlCalculate1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlCalculate1_OnCalculationComplete(object sender, ctrlCalculate.CalculationCompleteEventArgs e)
        {
            MessageBox.Show($"Results={e.Result},val1= {e.Val1},val2= {e.Val2}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
