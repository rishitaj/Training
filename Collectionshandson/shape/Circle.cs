using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Circle: Shape2
    {
        int radius = 10;
        public double area()
        {
            return 3.14 * radius * radius;
        }
        public double volume()
        {
            return 0;
        }
    }

}
