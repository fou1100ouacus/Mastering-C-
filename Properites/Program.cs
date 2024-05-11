using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properites
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class DOllar
    {
        private decimal _amount;
        public decimal amount
        {
            get { return _amount; }
            set
            {
                if (value < 0)


                    _amount = 0;
                else
                    _amount = value;




            }


        }




    }



}