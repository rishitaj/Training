using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
           //Assembly myAssembly = Assembly.LoadFile(@"E:\EuroTraining\Training\Training\ClassLibrary1\ClassLibrary1\bin\Debug\ClassLibrary1.dll");

            //Get type of object from loaded assembly

            Type myType = typeof(fruits);
            Console.WriteLine("Class: " + myType);
            MethodInfo[] method_name = myType.GetMethods();
            foreach (var item in method_name)
            {
                Console.WriteLine("Method Name: " + item);
            }

            Console.Read();

        }
    }
    class fruits
    {
        public static string fruitname { get; set; }

        public fruits(string fruitName)
        {
            fruitName = fruitname;
        }
        public void apple()
        {
            Console.WriteLine("Apple");
        }
        public void orange()
        {
            Console.WriteLine("orange");
        }
    }
}
