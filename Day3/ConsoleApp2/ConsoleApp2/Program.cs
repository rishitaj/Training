using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            one obj = new one();

            obj.CreateFile();
            obj.DeleteFile();
            obj.FileCreated();
            obj.WriteFile();
            obj.WriteFile1();
            obj.ReadFile();
            obj.specificline();
            obj.countlines();


            Console.Read();
        }
    }
}
