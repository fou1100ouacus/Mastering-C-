using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Price_Tracker
{
    internal class Program
    {
        public class stockprice : EventArgs
        {
            public double oldprice { get; }
            public double newprice { get; }
            public double diffrence { get; }

            public stockprice(double oldP,double newp )
            {
                oldprice = oldP;
                newprice = newp;
                diffrence=newprice-oldprice;
               
            }

          

        }
    
        public class Stock
        {
           double _currentprice;
            double _oldprice;
            public event EventHandler<stockprice> StockPriceChanged;

            public void setprice(double newpr)
            {
                if(newpr!=_currentprice)
                {
                    _oldprice = _currentprice;
                    _currentprice = newpr;
                    onstockpricechange(_oldprice,_currentprice);
                }
               
            }
            public void onstockpricechange(double oldp,double newp)
            {
                onstockpricechange(new stockprice ( oldp,newp));
            }
            public void onstockpricechange(stockprice s)
            {
                StockPriceChanged?.Invoke(this, s);

            }



        }


        public class Display
        {
            public void subscribe(Stock stock)
            {
                // event
              stock.StockPriceChanged += handlestockpricechanged;
            }


            public void handlestockpricechanged(object sender,stockprice e)
            {
                Console.WriteLine("\n\nStock Price changed:");
                Console.WriteLine($"Price changed from {e.oldprice}$");
                Console.WriteLine($"Price changed to  {e.newprice}$");
                Console.WriteLine($"Price Difference  {e.diffrence}$");

            }
        }


        static void Main(string[] args)
        {
           Stock stock = new Stock();
            Display display = new Display();
            display.subscribe(stock);
            stock.setprice(455);
            stock.setprice(4);
            stock.setprice(455);
            stock.setprice(455);

            stock.setprice(4);





        }
    }
}
