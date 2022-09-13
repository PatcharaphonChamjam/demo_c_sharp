using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingNumber
{
    public class SortNumber
    {
        //กำหนด Prop Size Type int
        public int Size { get; set; }

        //กำหนดตัวแปร _store Type int
        private int _store;

        public void Ascending()
        {
            //กำหนด int array
            int[] array = new int[Size];
            //TODO รับเป็น string มาขั้นอะไรสักอย่าง อาจจะขุึ้นด้วย

            //กำหนดเงื่อนไขวนลูป i = 0 ;i < Size; i++ :: รับค่าจาก Keyboard ตามจำนวน Index
            for (int i = 0; i < Size; i++)
            {
                //แสดงผล array[(ตำแหน่ง Index)] :
                Console.Write("array[{0}] : ", i);
                //รับค่าจาก Keyboard set ค่า array[(ตำแหน่ง Index)]
                array[i] = int.Parse(Console.ReadLine());
            }
            //กำหนดเงื่อนไขวนลูป i = 0 ;i < Size; i++ :: เรียงจากน้อยไปมาก
            for (int i = 0; i < Size; i++)
            {//กำหนดเงื่อนไขวนลูป int j = i + 1; j < Size; j++
                for (int j = i + 1; j < Size; j++)
                {
                    //กำหนดเงื่อนไข ถ้าค่าของ array[j] น้อยกว่าค่าของ array[i]
                    if (array[j] < array[i])
                    {
                        //ให้ _store เก็บค่าของ array[i]
                        _store = array[i];
                        //ให้ array[i] เก็บค่าของ array[j]
                        array[i] = array[j];
                        //ให้ array[j] เก็บค่าของ _store
                        array[j] = _store;
                    }
                }
            }
            //แสดงผล Sorting number ASC :
            Console.Write("Sorting number ASC : ");
            //กำหนดเงื่อนไขวนลูปใน array
            foreach (int i in array)
            {
                //แสดงผลค่าใน array
                Console.Write("\t{0} ", i);
            }
        }
    }
}