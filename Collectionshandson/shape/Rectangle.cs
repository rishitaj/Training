using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Rectangle : Shape
    {
        int length, width;
        public Rectangle(string c,int len, int wid)
        {
            setColor(c);
            this.length = len;
            this.width = wid;
        }
        public override double Area(int l, int w)
        {
            //throw new NotImplementedException();
            return l * w;
        }
        public void displayArea()
        {
            double area = Area(length, width);
            Console.WriteLine("Area of the Rectangle is: " + area);
        }
    }
}
