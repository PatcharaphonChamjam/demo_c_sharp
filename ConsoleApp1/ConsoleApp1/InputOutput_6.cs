using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InputOutput_6
    {
        public void WriteConsole()
        {
            Console.Write("Hello Java");
            Console.Write("Hello C#");
            Console.Write("Hello C++");

        }

        public void WriteLine()
        {
            Console.Write("Hello C#\n");
            Console.WriteLine("Hello C#");
        }

        public void WriteLineVariable()
        {
            string name = "Marcus";
            string music = "Trip hop";
            string movie = "science";

            Console.WriteLine("My name is {0}.",name);
            Console.WriteLine("{0} is my favorite music style and {1} is movie style",music,movie);
        }

        public void Read()
        {
            Console.WriteLine(Console.Read());
        }

        public void ReadLine()
        {
            string name;
            int age;
            double height;

            Console.Write("Enter name :");
            name = Console.ReadLine();
            Console.Write("Enter age :");
            int.TryParse(Console.ReadLine(), out age);
            Console.Write("Enter height :");
            double.TryParse(Console.ReadLine(), out height);

            Console.WriteLine("Name: {0}",name);
            Console.WriteLine("Age: {0}",age);
            Console.WriteLine("Height: {0}",height);
        }
    }
}
