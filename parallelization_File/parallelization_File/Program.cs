using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace parallelization_File
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = System.IO.File.ReadLines(@"E:\EuroTraining\networklog.txt").ToList();
            Parallel.For(0,lines.Count, i =>
            //foreach (var item in lines)
            {
                Console.WriteLine(lines[i] + $" (thread = {Thread.CurrentThread.ManagedThreadId}));
            });
            Console.Read();
        }
    }
}
