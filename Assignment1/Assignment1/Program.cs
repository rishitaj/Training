using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.ReadLine();
            Console.WriteLine("Welcome!!!!");
            Console.WriteLine("This is FlyHIgh Airlines.\n");

            bookETicket bt = new bookETicket();
            bt.eticketbooking();
            bt.details();
            bt.price();
            luggage l = new luggage();
            l.Class();
            Console.WriteLine();
            ViewMaintenance a = new ViewMaintenance();
            a.Maintenance();
            Console.Read();
        }
    }
}
