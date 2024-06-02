using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event
{
    public partial class ctrlCalclator : UserControl
    {
        public ctrlCalclator()
        {
            InitializeComponent();
        }
        public event Action<int> OnCalculationComplete;
        protected virtual void CalculationComplete(int PersonID)
        {
            Action<int> handler = OnCalculationComplete;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            if (OnCalculationComplete != null)

                CalculationComplete(result);

        }
    }
}
