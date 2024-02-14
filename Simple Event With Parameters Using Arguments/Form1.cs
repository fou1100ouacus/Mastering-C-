using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Event_With_Parameters_Using_Arguments
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlCalculate1_OnCalculationComplete(object sender, ctrlCalculate.CalculationCompleteEventArgs e)
        {
            MessageBox.Show($"result{e.result} , val1 {e.val1} , val2 {e.val2} ");
        }



    }
}
