using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class one
    {
        public string CreateFile()
        {
            FileStream fs = new FileStream(@"E:\EuroTraining\Day3\ConsoleApp2\ConsoleApp2\mytest.txt", FileMode.Create);
            //StreamReader sr = new StreamReader(fs);
            fs.Close();
            //sr.Close();
            return "file created";
        }
        public void DeleteFile()
        {
            //FileStream fs = new FileStream(@"E:\EuroTraining\Day3\ConsoleApp2\ConsoleApp2\mytest.txt", FileMode.Create);
            //StreamReader sr = new StreamReader(fs);
            string str = @"E:\EuroTraining\Day3\ConsoleApp2\ConsoleApp2\mytest.txt";
            //fs.Close();
            //sr.Close();
            if (File.Exists(str))
            {
                File.Delete(str);
                Console.WriteLine("File Deleted Successfully");
            }
            else
                Console.WriteLine("File does not exist");
        }
        public string FileCreated()
        {
            FileStream fs = new FileStream(@"E:\EuroTraining\Day3\ConsoleApp2\ConsoleApp2\mytest.txt", FileMode.OpenOrCreate);
            Console.WriteLine("file created with the name mytest.txt");
            fs.Close();

            return "File created";
        }
        public string WriteFile()
        {
            FileStream fs = new FileStream(@"E:\EuroTraining\Day3\ConsoleApp2\ConsoleApp2\mytest2.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("1. File Created");
            sw.WriteLine("2. Hello");
            sw.WriteLine("3. This is Rishita");
            sw.WriteLine("4. Thank you.");
            Console.WriteLine("A file Created with content name mytext2.txt");
            sw.Close();
            fs.Close();

            return "File Created";
        }
        public string WriteFile1()
        {
            FileStream fs = new FileStream(@"E:\EuroTraining\Day3\ConsoleApp2\ConsoleApp2\mytest3.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello and Welcome");
            sw.WriteLine("It is the first Content of the text file mytest3.txt");

            //Console.WriteLine("A file Created with content name mytext2.txt");
            sw.Close();
            fs.Close();

            return "file created";

        }

        public void ReadFile()
        {
            FileStream fs = new FileStream(@"E:\EuroTraining\Day3\ConsoleApp2\ConsoleApp2\mytest3.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            //string line = sr.ReadLine();
            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);

            }
            sr.Close();
            fs.Close();

        }
        public void specificline()
        {
            FileStream fs = new FileStream(@"E:\EuroTraining\Day3\ConsoleApp2\ConsoleApp2\newfile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            int n;
            Console.WriteLine("Input number of lines to write in the file: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input " + n + " string below:");
            string[] line = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Imput line " + (i + 1) + ":");
                line[i] = Console.ReadLine();
                sw.WriteLine(line[i]);
            }
            sw.Close();
            fs.Close();
            FileStream fs1 = new FileStream(@"E:\EuroTraining\Day3\ConsoleApp2\ConsoleApp2\newfile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs1);
            Console.WriteLine("enter which line you want to display: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The content of the line 3 of the file newfile.txt is: ");
            for (int j = 1; j <= n; j++)
            {
                string l = sr.ReadLine();
                if (j == x)
                {
                    Console.WriteLine(l);
                }
            }
            sr.Close();
            fs.Close();
        }
        public void countlines()
        {
            FileStream fs = new FileStream(@"E:\EuroTraining\Day3\ConsoleApp2\ConsoleApp2\newfile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Here is the content of the file newfile.txt");
            int c = 0;
            while (sr.Peek() > 0)
            {
                Console.WriteLine(sr.ReadLine());
                c++;
            }
            Console.WriteLine("The number of lines in the file newfile.txt is: " + c);
        }
    }
}
