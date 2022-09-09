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
                double lengh;

                Square square = new Square();

                Console.Write("Enter value lengh of square : ");
                /*lengh = double.Parse(Console.ReadLine())*/
                ;
                square.SetDimension(double.Parse(Console.ReadLine()));

                Console.WriteLine("Formula is " + square.lenght + " * " + square.lenght + " The area of the square is : " + square.Calculate());

                //rectangle
                double width;
                double height;

                Rectangle rectangle = new Rectangle();

                Console.Write("Enter value width of rectangle : ");
                width = double.Parse(Console.ReadLine());
                Console.Write("Enter value height of rectangle : ");
                height = double.Parse(Console.ReadLine());

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