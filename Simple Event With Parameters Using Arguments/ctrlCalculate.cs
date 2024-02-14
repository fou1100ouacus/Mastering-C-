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
    public partial class ctrlCalculate : UserControl
    {
        public ctrlCalculate()
        {
            InitializeComponent();
        }

        public class CalculationCompleteEventArgs:EventArgs
        {
            public int result { get; }
            public int val1 { get;  }
            public int val2 {  get; }

            public CalculationCompleteEventArgs(int result,int val1,int val2)
            {   this.result = result;
                this.val1 = val1;
                this.val2 = val2;
            }
        }
        public event EventHandler  <CalculationCompleteEventArgs>  OnCalculationComplete;
        protected void RaiseOnCalculationComplete(CalculationCompleteEventArgs e)
        {
            OnCalculationComplete?.Invoke(this, e);
        }
        public void RaiseOnCalculationComplete(int result,int val1,int val2)
        {
            RaiseOnCalculationComplete(new CalculationCompleteEventArgs (result,val1,val2)    );

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int val1 = Convert.ToInt32(textBox1.Text);
            int val2 =Convert.ToInt32(textBox2.Text);
            int result=val1 + val2;

            txtresult.Text=result.ToString();
            if(OnCalculationComplete != null)
            {
                RaiseOnCalculationComplete(result,val1,val2);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
