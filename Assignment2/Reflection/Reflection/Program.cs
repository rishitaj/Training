using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo f = new FileInfo(@"E:\EuroTraining\Training\Training\Assignment2\ChordFileGenerate\ChordFileGenerate\bin\Debug\ChordFileGenerate.dll");
            Assembly assembly = Assembly.LoadFrom(f.FullName);

            Type type = assembly.GetType("ChordFileGenerator.ChordFileGenerator");
            object obj = Activator.CreateInstance(type);

            Console.Write("Enter Song Name : ");
            string songName = Console.ReadLine();
            SetProperty(obj, "SongName", songName);

            Console.Write("Enter Artist of the entered Song : ");
            string artist = Console.ReadLine();

            SetProperty(obj, "Artist", artist);

            Console.Write("Enter File Type : ");
            string fileType = Console.ReadLine();

            Type EnumTypes = assembly.GetType("ChordFileGenerator.FileType");

            object fileTypeValue = GetEnumValue(EnumTypes, fileType);
            SetProperty(obj, "FileType", fileTypeValue);

            string lineType;
            do
            {

                Console.Write("Choose Line Type L or CL :\n1. Lyric(L) \n2. Chords and Lyric (CL)\n3. Save File\n ");
                lineType = Console.ReadLine();

                if (lineType == "L")
                {
                    string lyrics = Console.ReadLine();
                    InvokeMethod(obj, "AddLine", new object[] { lyrics });
                }
                else if (lineType == "CL")
                {
                    string chords = Console.ReadLine();
                    string lyrics = Console.ReadLine();

                    InvokeMethod(obj, "AddLine", new object[] { chords, lyrics });
                }
                else
                {
                    break;
                }
            } while (lineType == "L" || lineType == "CL");

            InvokeMethod(obj, "SaveFile", new object[] { "test.txt" });

            Console.WriteLine("Saved file!");

            Console.WriteLine(assembly);

            Console.ReadLine();
        }

        public static object GetProperty(object obj, string propertyName)
        {
            PropertyInfo property = obj.GetType().GetProperty(propertyName);

            return property.GetValue(obj);
        }
        public static void SetProperty(object obj, string Name, object value)
        {

            PropertyInfo property = obj.GetType().GetProperty(Name);

            property.SetValue(obj, value);
        }

        public static object InvokeMethod(object obj, string methodName, object[] arguments)
        {
            Type[] types = arguments.Select(x => x.GetType()).ToArray();

            MethodInfo method = obj.GetType().GetMethod(methodName, types);

            return method.Invoke(obj, arguments);
        }

        public static object GetEnumValue(Type enumType, string enumItemName)
        {
            Type enumUnderlyingType = enumType.GetEnumUnderlyingType();
            List<string> enumNames = enumType.GetEnumNames().ToList();

            Array enumValues = enumType.GetEnumValues();

            object enumValue = enumValues.GetValue(enumNames.IndexOf(enumItemName));

            return Convert.ChangeType(enumValue, enumUnderlyingType);
        }

    }
}
