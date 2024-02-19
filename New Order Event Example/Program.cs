using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Order_Event_Example
{//ا   publisher subscriber design pattern 
    internal class Program
    {
        public class OrderEventArgs : EventArgs
        {
            public int orderID { get; }
            public string ClientEmail { get; }
            public int OrderTotalPrice { get; }
            public OrderEventArgs(int orderID, int OrderTotalPrice, string clientEmail)
            {
                this.orderID = orderID;
                this.OrderTotalPrice = OrderTotalPrice;
                this.ClientEmail = clientEmail;
            }

        }


        public class Order
        {
            public event EventHandler<OrderEventArgs> OnOrderCreated;
         
            public void CreateOrder(int clientid,string clientemail ,int price)
            {
                Console.WriteLine("new order has been created , now you will be get notifications while event raising");
                if (OnOrderCreated != null)
                {
                    OnOrderCreated(this , new OrderEventArgs(clientid,price,clientemail));
                }

            }

        }


        public class EmailService
        {
            public void Subscribe(Order order)
            {

                order.OnOrderCreated += HandlenewOrder;
            }

            public void Unsubscribe(Order order)
            {
                order.OnOrderCreated -= HandlenewOrder;

            }

            public void HandlenewOrder(object sender, OrderEventArgs e)
            {
                Console.WriteLine($"----------------Email Service------------------");
                Console.WriteLine($"Email Service Object Recieved a new order event");
                Console.WriteLine($"Order ID: {e.orderID}");
                Console.WriteLine($"Order Price: {e.OrderTotalPrice}");
                Console.WriteLine($"Email: {e.ClientEmail}");
                Console.WriteLine($"\nSend an Email");
                Console.WriteLine($"-----------------------------------------------");
                // write the code to send email
                Console.WriteLine();

            }

        }
   
        partial class SMSservice
        {
            public void Subscribe(Order order)
            {
                order.OnOrderCreated += HandlenewOrder;
            }

            public void UnSubscribe(Order order)
            {
                order.OnOrderCreated -= HandlenewOrder;
            }


            public void HandlenewOrder (object sender, OrderEventArgs e)
            {

                Console.WriteLine($"----------------SMS Service------------------");
                Console.WriteLine($"SMS Service Object Recieved a new order event");
                Console.WriteLine($"Order ID: {e.orderID}");
                Console.WriteLine($"Order Price: {e.OrderTotalPrice}");
                Console.WriteLine($"Email: {e.ClientEmail}");
                Console.WriteLine($"\nSend an SMS");
                Console.WriteLine($"-----------------------------------------------");
                // write the code to send SMS
                Console.WriteLine();

            }
        }
        
        
        
        static void Main(string[] args)
        {



            Order order = new Order();
            EmailService service1 = new EmailService();
            EmailService service2 = new EmailService();
            EmailService service3 = new EmailService();

            SMSservice smsservice1 = new SMSservice();
            SMSservice smsservice2 = new SMSservice();
            

            service1.Subscribe(order);
            service3.Subscribe(order);

            service2.Subscribe(order);
            smsservice1.Subscribe(order);
            smsservice2.Subscribe(order);

            order.CreateOrder(1, "client1@gmail.com", 48);


            
            service1.Unsubscribe(order);
            service2.Unsubscribe(order);

            order.CreateOrder(2, "gmail.com", 7878);// 1 service3 2 sms, 
        }
    }
}
