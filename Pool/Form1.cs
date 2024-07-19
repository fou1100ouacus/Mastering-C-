using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8Pool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void poolTable4_Load(object sender, EventArgs e)
        {

        }

        private void poolTable_OnTableComplete(object sender, PoolTable.TableCompletedEventArgs e)
        {
            string TableResults = "";

            TableResults = "Time Consumed " + e.TimeText;
            TableResults = TableResults + ", Total Seconds= " + e.TimeInSeconds;
            TableResults = TableResults + ", HourlyRate=" + e.RatePerHour.ToString();
            TableResults = TableResults + ", Total Fees=" + e.TotalFees.ToString();

            MessageBox.Show(TableResults);
        }
    }
}
