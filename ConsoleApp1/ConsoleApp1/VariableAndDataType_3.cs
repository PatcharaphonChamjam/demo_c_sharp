using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class VariableAndDataType_3
    {
        public void VariableDeclaration()
        {
            //กำหนดค่า 2020 ให้ตัวแปร year Type integer
            int year = 2022;
            //กำหนดค่า Thomas ให้ตัวแปร name Type string
            string name = "Thomas";
            //กำหนดค่า American ให้ตัวแปร nationality Type string
            string nationality = "American";

            //แสดงค่า His name is Thomas
            Console.WriteLine("His name is {0}", name);
            //แสดงค่า He was born in 2020
            Console.WriteLine("He was born in {0}",year);
            //แสดงค่า He is American
            Console.WriteLine("He is {0}",nationality);
        }

        public void Boolean()
        {
            //กำหนดค่า true ให้ตัวแปร isDay Type bool
            bool isDay = true;
            //กำหนดเงื่อนไข ถ้าหากเป็นจริง
            if(isDay)
            {
                //แสดงผล Good morning
                Console.WriteLine("Good morning");
            }
            //กำหนด ถ้าไม่เข้าเงื่อนไขด้านบน
            else
            {
                //แสดงผล Good night
                Console.WriteLine("Good night");
            }
            //กำหนดค่า false ให้ตัวแปร gameOver Type bool
            bool gameOver = false;
            //แสดงผล Game over = false
            Console.WriteLine("Game over = {0}",gameOver);
        }

        public void IntegerNumberType()
        {
            //กำหนดค่า 10 ให้ตัวแปร apple Type int
            int apple = 10;
            //กำหนดค่า 5 ให้ตัวแปร mango Type int
            int mango = 5;
            //กำหนด apple + mango ให้ตัวแปร totalFruit Type int
            int totalFruit = apple + mango;

            //แสดงผล We have 15 fruits in the basket
            Console.WriteLine("We have {0} fruits in the basket",totalFruit);

            //กำหนดค่า 12 ให้ตัวแปร month Type byte
            byte month = 12;
            //กำหนดค่า 20 ให้ตัวแปร day Type byte
            byte day = 20;
            //กำหนดค่า 2016 ให้ตัวแปร year Type short
            short year = 2016;

            //แสดงผล Date 12/20/2016
            Console.WriteLine("Date {0}/{1}/{2}",month,day,year);

            //กำหนดค่า 9460730472580800 ให้ตัวแปร bigNumber Type decimal
            decimal bigNumber = 9460730472580800;
            //แสดงผล 9.46073E15
            Console.WriteLine(bigNumber.ToString("0.00000E0"));

            //กำหนดค่า Int32.MaxValue ให้ตัวแปร max Type int
            int max = Int32.MaxValue;
            //แสดงผล 2147483647
            Console.WriteLine(max);
            //กำหนด max + 1 ให้ตัวแปร max
            max = max + 1;
            //แสดงผล -2147483648
            Console.WriteLine(max);
        }

        public void DoubleNumberType()
        {
            //กำหนดค่า 8.3 ให้ตัวแปร speed Type float
            float speed = 8.3f;
            //กำหนดค่า 10.25 ให้ตัวแปร time Type float
            float time = 10.25f;
            //กำหนด speed * time ให้ตัวแปร distance Type float
            float distance = speed * time;

            //แสดงผล Metro runs at speed 8.3 m/s in 10.25 seconds
            Console.WriteLine("Metro runs at speed {0} m/s in {1} seconds", speed, time);
            //แสดงผล Total run distance 85.075 meters
            Console.WriteLine("Total run distance {0} meters",distance);

            //กำหนดค่า 5.8786E12f ให้ตัวแปร lightSpeed Type float
            float lightSpeed = 5.8786E12f;
            //แสดงผล Light can travel 5.8786E+12 miles in 1 year
            Console.WriteLine("Light can travel {0} miles in 1 year",lightSpeed);

            //กำหนดค่า 365.25 ให้ตัวแปร day Type double
            double day = 365.25;
            //กำหนดค่า 1.674927471E-27 ให้ตัวแปร neutroMass Type double
            double neutroMass = 1.674927471E-27;
            //กำหนดค่า 22 / 7.0 ให้ตัวแปร pi Type double
            double pi = 22 / 7.0f;
            //แสดงผล Earth take about 365.25 day to orbit the sun
            Console.WriteLine("Earth take about {0} day to orbit the sun", day);
            //แสดงผล PI value = 3.14285707473755
            Console.WriteLine("PI value = {0}",pi);
            //แสดงผล Neutron Mass = 1.674927471E-27 kg
            Console.WriteLine("Neutron Mass = {0} kg", neutroMass);

        }
    }
}
