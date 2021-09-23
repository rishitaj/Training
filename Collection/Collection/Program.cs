using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<Data, BillGen> a = new Dictionary<Data, BillGen>();
            int i = 0;
            while(n!=0)
            {
                Console.WriteLine("Enter details of customer " + (i+1));
                Data d = new Data();
                Console.WriteLine("Enter Consumer number: ");
                d.ConsumerNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Consumer Name:");
                d.ConsumerName = Console.ReadLine();
                Console.WriteLine("Total unit consumed by the customer:");
                d.TotalUnits = Convert.ToInt32(Console.ReadLine());

                BillGen b = new BillGen();
                System.Random random = new System.Random();
                b.Bill_No = random.Next(1000000);
                Console.WriteLine("Enter Cost per unit");
                double cost_per_unit = Convert.ToDouble(Console.ReadLine());
                b.CostPerUnit = cost_per_unit;
                b.TotalAmt = b.CostPerUnit * d.TotalUnits;
                b.DueDate = DateTime.Today.AddDays(1);
                a.Add(d, b);
                Console.WriteLine();
                n--;    
            }
            Console.WriteLine("Bill Generated");
            Console.WriteLine();
            foreach (var item in a)
            {
                Console.WriteLine(item.Value.Bill_No);
                Console.WriteLine(item.Key.ConsumerNo);
                Console.WriteLine(item.Key.ConsumerName);
                Console.WriteLine(item.Key.TotalUnits);
                Console.WriteLine(item.Value.CostPerUnit);
                Console.WriteLine(item.Value.TotalAmt);
                Console.WriteLine(item.Value.DueDate);
                Console.WriteLine();

            }
            Console.Read();
        }
    }
}
