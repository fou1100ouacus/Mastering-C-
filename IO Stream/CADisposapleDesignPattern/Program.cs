using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CADisposapleDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        { // 1- Not Recommented
          //CurrencyServices currencyServices = new CurrencyServices();
          //var result = currencyServices.GetCurrency();
          //// Dispose
          //currencyServices.Dispose();
          //Console.WriteLine(result);

            // **************************************************************************
            //CurrencyServices currencyServices = null;
            ////2- Recommented  Try catch {}
            //try
            //{
            //  currencyServices = new CurrencyServices();
            //    var result = currencyServices.GetCurrency();
            //    Console.WriteLine(result);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error ");
            //    throw;
            //}
            //finally 
            //{ 
            //    currencyServices?.Dispose();

              
            
            //}

            // **************************************************************************
           
            //3- More Recommented  ==> USING


            using (CurrencyServices currency=new CurrencyServices())
            {
                var result = currency.GetCurrency();
                Console.WriteLine(result);
            }

            //4- using with no blocks
        }



        class CurrencyServices :IDisposable
        { //ctor 
           private bool _disposed = false;
            private readonly HttpClient httpclient; // httpclient is unmanged code ==> has a  disposaple 
            public CurrencyServices()
            {
                 httpclient = new HttpClient();
                    
            }
            ~CurrencyServices ()
            {
                Dispose(false);
            
            }
            protected virtual void Dispose(bool disposing)  
            { 
                if(_disposed)
                    return ;

                //Dispose logic
                _disposed = true;
                if(disposing)
                {
                    httpclient.Dispose(); // call Dispose to clean Manged and Unmanged code
                }
                _disposed = true;

            }
            public void Dispose()
            {
               Dispose(true);
                GC.SuppressFinalize(this);
            }

            public string GetCurrency()
            {

                 string Url = "https://json.org/example.html";

                var result=httpclient.GetStringAsync(Url).Result;//get content of json file

                return result;
            }
        }
    }
}
