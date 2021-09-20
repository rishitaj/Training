using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public City City { get; set; }

        //Person obj = new Person();
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Name: " + Name);
            str.AppendLine("Age: " + Age);
            str.AppendLine("City: " + City.Name);
            str.AppendLine("Population: " + City.Population);
            return str.ToString();
        }
    }

    [Serializable]
    public class City
    {
        public String Name { get; set; }
        public int Population { get; set; }

    }
}
