using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    public abstract class Shape
    {
        private string color;
        public void setColor(string c)
        {
            this.color = c;
        }
        public string getColor()
        {
            return color;
        }
        public abstract double Area(int l,int w);

    }
}
