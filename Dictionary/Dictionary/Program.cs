using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> d = new Dictionary<int, string>();
            d.Add(1, "Player5");
            d.Add(2, "Player1");
            d.Add(3, "Player3");
            d.Add(4, "Player2");
            d.Add(5, "Player4");

            Console.WriteLine("Total number of players are:" + d.Keys.Count);
            foreach (KeyValuePair<int, String> item in d)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Updated list is:");
            d[1] = "Player4";
            d[5] = "Player5";
            foreach (KeyValuePair<int, String> i in d)
            {
                Console.WriteLine("Key: {0}, Value: {1}", i.Key, i.Value);
            }
            d.Clear();
            Console.Read();
        }
    }
}
