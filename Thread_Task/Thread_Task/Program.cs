using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Reflection;

namespace Thread_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Even_odd obj = new Even_odd();
            obj.Even(n);
            Console.WriteLine("Multithreading");
            Thread t1 = new Thread(obj.Even);
            Thread t2 = new Thread(obj.Odd);
            t1.Start(n);
            t2.Start(n);
            Task evenfunc = new Task(n);

            Console.Read();
   
        }

    }

}
