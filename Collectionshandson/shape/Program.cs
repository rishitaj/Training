using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\na. Area\nb. PolymorphismTest");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice==1)
            {
                Rectangle rec = new Rectangle("red", 12, 3);
                rec.displayArea();
            }

            else 
            {
                Shape2[] ss = { new Circle(), new Cube() };
                for (int i = 0; i < ss.Length; i++)
                {
                    Console.WriteLine(ss[i].area());
                    Console.WriteLine(ss[i].volume());
                }
            }
            Console.Read();
        }
    }
}
