using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collectionshandson
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            var word = new List<string> { "chino", "coho", "pink", "sockeye", "Rashi" };
            printwords(word);
            //1
            var num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = sumofevennos(num);
            Console.WriteLine("sum of Even Numbers Are: " + result);
            Console.Read();
        }
        public static int sumofevennos(List<int> lst)
        {
            int res = 0;
            foreach (var item in lst)
            {
                if((item % 2)==0)
                {
                    res = res + item;
                }
            }
            return res;
        }
        public static void printwords(List<string> mylist) 
        {
            Console.WriteLine("Enter length of the string :");
            int res = Convert.ToInt32(Console.ReadLine());
            foreach (var j in mylist)
            {
                string str = j;
                if (str.Length == res)
                    Console.WriteLine(str);
            }
        }
    }
}
