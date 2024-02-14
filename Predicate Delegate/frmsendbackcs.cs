using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predicate_Delegate
{
    public partial class frmsendbackcs : Form
    {
        public frmsendbackcs()
        {
            InitializeComponent();
        }
        public delegate void DatabackEventHandler(object sender,int id);
        public event DatabackEventHandler databack;

        private void button1_Click(object sender, EventArgs e)
        {



            databack?.Invoke(this,Convert.ToInt32(textBox1.Text));
            this.Close();
        }
    }
}
