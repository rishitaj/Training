using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class bookTickets
    {
        private String Source, Dest, Date;
        private int price;
        public void details()
        {
            Console.WriteLine("Enter Source: ");
            Source = Console.ReadLine();
            Console.WriteLine("Enter Destination: ");
            Dest = Console.ReadLine();
            Console.WriteLine("Enter Date: ");
            Date = Console.ReadLine();
        }
        public int pricedetails()
        {
            if((Source== "Delhi" || Source== "Bangalore")&& (Dest=="Bangalore" || Dest == "Delhi"))
            {
                price = 20000;
            }
            if ((Source == "Delhi" || Source == "Kolkata") && (Dest == "Kolkata" || Dest == "Delhi"))
            {
                price = 15000;
            }
            return price;
        }
    }
    class bookETicket:bookTickets
    {
        public void eticketbooking()
        {
            Console.WriteLine("This method is used to perform e-ticket bookings for various flights.");
        }
        public void price()
        {
            int p=pricedetails();
            Console.WriteLine("The price for your journey is: Rs " + p);


        }
    }
}
