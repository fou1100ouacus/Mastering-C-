using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NewOrderEventExample.Program;

namespace NewOrderEventExample
{


    public class OrderEventArgs : EventArgs
    {
        public int OrderID { get; }
        public int OrderTotalPrice { get; }
        public string ClientEmail { get; }

        public OrderEventArgs(int orderID, int OrderTotalPrice, string clientEmail)
        {
            this.OrderID = orderID;
            this.OrderTotalPrice = OrderTotalPrice;
            this.ClientEmail = clientEmail;
        }
    }

    public class Order
    {
        public event EventHandler<OrderEventArgs> OnOrderCreated;
        public void Create(int orderID, int OrderTotalPrice, string ClientEmail)
        {
            Console.WriteLine("New order created; now will notify everyone by raising the event.\n");

            if (OnOrderCreated != null)
            {
                OnOrderCreated(this, new OrderEventArgs(orderID, OrderTotalPrice, ClientEmail));
            }
        }
    }

    public class EmailService
    {

        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleNewOrder;
        }

        public void UnSubscribe(Order order)
        {
            order.OnOrderCreated -= HandleNewOrder;
        }


        public void HandleNewOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"----------------Email Service------------------");
            Console.WriteLine($"Email Service Object Recieved a new order event");
            Console.WriteLine($"Order ID: {e.OrderID}");
            Console.WriteLine($"Order Price: {e.OrderTotalPrice}");
            Console.WriteLine($"Email: {e.ClientEmail}");
            Console.WriteLine($"\nSend an Email");
            Console.WriteLine($"-----------------------------------------------");
            // write the code to send email
            Console.WriteLine();
        }
    }

    public class SMSService
    {
        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleNewOrder;
        }

        public void UnSubscribe(Order order)
        {
            order.OnOrderCreated -= HandleNewOrder;
        }


        public void HandleNewOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"----------------SMS Service------------------");
            Console.WriteLine($"SMS Service Object Recieved a new order event");
            Console.WriteLine($"Order ID: {e.OrderID}");
            Console.WriteLine($"Order Price: {e.OrderTotalPrice}");
            Console.WriteLine($"Email: {e.ClientEmail}");
            Console.WriteLine($"\nSend an SMS");
            Console.WriteLine($"-----------------------------------------------");
            // write the code to send SMS
            Console.WriteLine();
        }
    }

    public class ShippingService
    {
        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleNewOrder;
        }

        public void UnSubscribe(Order order)
        {
            order.OnOrderCreated -= HandleNewOrder;
        }


        public void HandleNewOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"----------------Shipping Service------------------");
            Console.WriteLine($"Shipping Service Object Recieved a new order event");
            Console.WriteLine($"Order ID: {e.OrderID}");
            Console.WriteLine($"Order Price: {e.OrderTotalPrice}");
            Console.WriteLine($"Email: {e.ClientEmail}");
            Console.WriteLine($"\nSend an Shipping");
            Console.WriteLine($"-----------------------------------------------");
            // write the code to send Shipping
            Console.WriteLine();
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            EmailService emailService = new EmailService();
            SMSService smsService = new SMSService();
            ShippingService shippingService = new ShippingService();

            emailService.Subscribe(order);
            smsService.Subscribe(order);
            shippingService.Subscribe(order);

            order.Create(10, 540, "Ahmed@gmail.com");
            order.Create(10, 540, "Ali@gmail.com");




            Console.ReadLine();
        }
    }






}
