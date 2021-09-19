using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class luggage
    {
        public void Class()
        {
            Console.WriteLine("Total Weight of the Luggage:");
            int tw = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.FirstClass\n2.Business Class\n3.Economy Class\nChoose a number:");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                int maxLug = 50, ew, amt;
                if (tw > maxLug)
                {
                    ew = tw - maxLug;
                    amt = 2 * ew;
                    Console.WriteLine("Maximum Weight Exceeded.");
                    Console.WriteLine("Total Amount to be paid: $" + amt);
                }
                else
                    Console.WriteLine("Welcome!");
            }
            else if(ch==2)
            {
                int maxLug = 40, ew, amt;
                if (tw > maxLug)
                {
                    ew = tw - maxLug;
                    amt = 2 * ew;
                    Console.WriteLine("Maximum Weight Exceeded.");
                    Console.WriteLine("Total Amount to be paid: $" + amt);
                }
                else
                    Console.WriteLine("Welcome!");
            }
            else
            {
                int maxLug = 20, ew, amt;
                if (tw > maxLug)
                {
                    ew = tw - maxLug;
                    amt = 2 * ew;
                    Console.WriteLine("Maximum Weight Exceeded.");
                    Console.WriteLine("Total Amount to be paid: $" + amt);
                }
                else
                    Console.WriteLine("Welcome!");
            }
        }
    }
}
