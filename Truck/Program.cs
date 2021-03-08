using System;
using System.Collections.Generic;

namespace Truck
{
    class Program
    {
        static void Main(string[] args)
        {
            Order NewOrd = new Order();
            Console.Write("Enter Your Name : ");
            NewOrd.Name = Console.ReadLine();
            Console.Write("Enter The Package Size : ");
            NewOrd.PackSize = int.Parse(Console.ReadLine());
            Console.Write("Enter a month : ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter a day : ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter a year : ");
            int year = int.Parse(Console.ReadLine());
            NewOrd.Date = new DateTime(year, month, day);
            var Orders = new List<Order> { };
            int x = Orders.Count + 1;
            int trucknum = 0;
            foreach ( var comp in Orders)
            {
                for (int i= 1; i == Orders.Count; i++) {
                    int compsize = 50;
                    int newsize = 0;
                     
                    while (newsize < compsize)
                    {
                        if (NewOrd.Date == comp.Date)
                        {
                            newsize = +comp.PackSize;
                        }
                         if (newsize >= compsize)
                        {
                            trucknum = +1;
                            newsize = comp.PackSize;
                        }
                    }
                   
                }

                
            }
            if (trucknum <= 10)
            {
                Orders.Add(new Order { ordernumber = x, Name = NewOrd.Name, PackSize = NewOrd.PackSize, Date = NewOrd.Date, Trucknum = trucknum + 1 });
                Console.WriteLine("your order number is :" + x);
            }
            else
            {
                Console.WriteLine("We are full at this date chosse another date");
            }
        }
    }

    public class Order
    {
        public int ordernumber { get; set; }
        public String Name { get; set; }
        public int PackSize { get; set; }
        public DateTime Date { get; set; }
        public int Trucknum { get; set; }
    }
}
