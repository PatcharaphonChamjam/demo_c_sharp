using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Demo_Square
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //square
                Square square = new Square();

                Console.Write("Enter value length of square : ");
                square.SetDimension(double.Parse(Console.ReadLine()));

                Console.WriteLine("Formula is " + square.length + " * " + square.length + " The area of the square is : " + square.Calculate());

                //rectangle
                Rectangle rectangle = new Rectangle();

                Console.Write("Enter value width of rectangle : ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Enter value height of rectangle : ");
                double height = double.Parse(Console.ReadLine());

                rectangle.SetDimension(width, height);
                Console.WriteLine("Formula is " + rectangle.width + " * " + rectangle.height + " The area of the square is : " + rectangle.Calculate());
            }
            catch (FormatException formatex)
            {
                Console.WriteLine(" Catch FormatException " + formatex);
            }
        }
    }
}