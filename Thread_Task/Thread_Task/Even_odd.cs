using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Thread_Task
{
    public class Even_odd
    {
        public void Even(object a)
        {
            for (int i = 0; i < Convert.ToInt32(a); i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even number:" + i);
            }
        }
        public void Odd(object a)
        {
            for (int i = 0; i < Convert.ToInt32(a) ; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine("Odd number:" + i);
            }
        }

    }
}
