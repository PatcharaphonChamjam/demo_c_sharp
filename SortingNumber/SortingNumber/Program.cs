using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //แสดงผล Enter size of array
            Console.Write("Enter size of array : ");
            //สร้าง obj ใหม่จาก Class SortNumber
            SortNumber sortNumber = new SortNumber();
            //รับค่าจาก Keyboard set ค่า Size ใน Class SortNumber
            sortNumber.Size = int.Parse(Console.ReadLine());
            //เรียกใช้ Method Ascending
            sortNumber.Ascending();
        }
    }
}