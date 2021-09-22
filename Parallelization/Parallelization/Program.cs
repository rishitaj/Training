using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Parallelization
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the num: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Serial Programming
            for(int i=0;i<num;i++)
            {
                if(i%2==0)
                    Console.WriteLine($"Even number: {i}, thread={Thread.CurrentThread.ManagedThreadId}");
                else
                    Console.WriteLine($"Odd number: {i}, thread={Thread.CurrentThread.ManagedThreadId}");

            }

            Console.WriteLine("********************");
            //Parallel programming
            Parallel.For(0, num, i =>
             {
                  if (i % 2 == 0)
                      Console.WriteLine($"Even number: {i}, thread={Thread.CurrentThread.ManagedThreadId}");
                  else
                      Console.WriteLine($"Odd number: {i}, thread={Thread.CurrentThread.ManagedThreadId}");
             });
            Console.Read();
        }
    }
}
