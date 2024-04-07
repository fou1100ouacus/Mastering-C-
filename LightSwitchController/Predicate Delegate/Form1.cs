using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Predicate_Delegate.frmsendbackcs;

namespace Predicate_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmsendbackcs frmsendbackcs = new frmsendbackcs();

            frmsendbackcs.databack += Databack;//subscribe to the event 
            // DatabackEventHandler ==> call the function
            frmsendbackcs.ShowDialog();
        } 
        private void Databack(object sender,int  id)
        {textBox1.Text= id.ToString();

        }
    }
}
