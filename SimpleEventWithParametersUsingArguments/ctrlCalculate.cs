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
    public partial class ctrlCalculate : UserControl
    {
        public ctrlCalculate()
        {
            InitializeComponent();
        }
        public class CalculationCompleteEventArgs : EventArgs
        {

            public int Result { get; }
            public int Val1 { get; }
            public int Val2 { get; }

            public CalculationCompleteEventArgs(int Results, int Val1, int Val2)
            {
                this.Result = Results;
                this.Val1 = Val1;
                this.Val2 = Val2;
            }
        }

        public event EventHandler<CalculationCompleteEventArgs> OnCalculationComplete;

        protected virtual void RaiseOnCalculationComplete(CalculationCompleteEventArgs e)
        {
            OnCalculationComplete?.Invoke(this, e);
        }

        public void RaiseOnCalculationComplete(int Results, int Val1, int Val2)
        {
            RaiseOnCalculationComplete(new CalculationCompleteEventArgs(Results, Val1, Val2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Val1, Val2;
            Val1 = Convert.ToInt32(textBox1.Text);
            Val2 = Convert.ToInt32(textBox2.Text);

            int Result = Val1 + Val2;

            //   lblResult.Text = Result.ToString();

            if (OnCalculationComplete != null)
            {
                RaiseOnCalculationComplete(Result, Val1, Val2);


            }
        }
    }
}
