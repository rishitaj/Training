using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;


namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Binary Serialization\n 2.XML serialization\nChoose one option.");
            int ch = Convert.ToInt32(Console.ReadLine());
            Person obj = new Person();
            Console.WriteLine("Name:");
            obj.Name = Console.ReadLine();
            Console.WriteLine("Age:");
            obj.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("City:");
            obj.City = new City();
            obj.City.Name = Console.ReadLine();
            Console.WriteLine("Population:");
            obj.City.Population = Convert.ToInt32(Console.ReadLine());


            if(ch==1)
            {
                //Serialize
                var binaryFormatter = new BinaryFormatter();
                Stream fs = new FileStream(@"E:\EuroTraining\Training\Training\Serialization\Serialization\file.txt", FileMode.Create, FileAccess.Write);
                binaryFormatter.Serialize(fs, obj);
                fs.Close();

                //DeSerialize
                fs = new FileStream(@"E:\EuroTraining\Training\Training\Serialization\Serialization\file.txt", FileMode.Open, FileAccess.Read);
                Person obj1 = (Person)binaryFormatter.Deserialize(fs);
            }

            else
            {
                var XMLFormatter = new XmlSerializer(typeof(Person));
                FileStream fs = new FileStream(@"E:\EuroTraining\Training\Training\Serialization\Serialization\file2.txt", FileMode.Create, FileAccess.Write);
                XMLFormatter.Serialize(fs, obj);
                fs.Close();

                fs = new FileStream(@"E:\EuroTraining\Training\Training\Serialization\Serialization\file2.txt", FileMode.Open, FileAccess.Read);
                Person obj1 = (Person)XMLFormatter.Deserialize(fs);
            }
            Console.WriteLine(obj.ToString());
            Console.Read();
        }
    }
}
