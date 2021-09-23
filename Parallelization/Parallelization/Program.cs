using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Parallelization
{
    class Program
    {
        private static int totalSize;
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the num: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Serial Programming");
            Console.WriteLine("Start Date and Time: " + DateTime.Now);
            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Even number: {i}, thread={Thread.CurrentThread.ManagedThreadId}");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine($"Odd number: {i}, thread={Thread.CurrentThread.ManagedThreadId}");
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine("End Date and Time: " + DateTime.Now);

            Console.WriteLine("********************");
            //Parallel programming
            DateTime start_date = DateTime.Now;
            Console.WriteLine("End Date and Time: " + DateTime.Now);
            Parallel.For(0, num, i =>
             {
                 if (i % 2 == 0)
                     Console.WriteLine($"Even number: {i}, thread={Thread.CurrentThread.ManagedThreadId}");
                 else
                     Console.WriteLine($"Odd number: {i}, thread={Thread.CurrentThread.ManagedThreadId}");
             });
            DateTime end_date = DateTime.Now;
            Console.WriteLine("End Date and Time: " + DateTime.Now);
            TimeSpan time = start_date - end_date;
            Console.WriteLine("Timespan: " + time);



            //if (!Directory.Exists(@"E:\EuroTraining")) 
            //{ 
            //    Console.WriteLine("The directory does not exist."); 
            //    return; 
            //}
            //String[] files = Directory.GetFiles(@"E:\EuroTraining"); 
            //Parallel.For(0, files.Length, index => 
            //{ 
            //    FileInfo fi = new FileInfo(files[index]); 
            //    long size = fi.Length; 
            //    Interlocked.Add(ref totalSize, (int)size); 
            //});
            //Console.WriteLine($"Thread:{Thread.CurrentThread.ManagedThreadId}");
            //Console.WriteLine("Directory '{0}':", @"E:\EuroTraining"); 
            //Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
            Console.Read();
        }
    }
}
