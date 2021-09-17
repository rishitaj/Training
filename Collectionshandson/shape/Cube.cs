using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Cube : Shape2
    {
        int x = 10;
        public double area()
        {
            return 6 * x * x;
        }
        public double volume()
        {
            return x * x * x;
        }
    }
}
