using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Array_9
    {
        public void Array1Dimention()
        {
            //กำหนดขนาด Array เท่ากับ 5 type Integer
            int[] array1 = new int[5];
            //กำหนดค่า 2 ใน index ที่ 0 ลงใน Array1
            array1[0] = 2;
            //กำหนดค่า 43 ใน index ที่ 1 ลงใน Array1
            array1[1] = 43;
            //กำหนดค่า 54 ใน index ที่ 2 ลงใน Array1
            array1[2] = 54;

            //กำหนดค่าลงใน Array2 type float
            float[] array2 = new float[] {1.2f,3.4f,5.0f,8.8f,10.5f};
            //แสดงค่า array2 ตำแหน่ง index ที่ 0 --> 1.2
            Console.WriteLine(array2[0]);
            //แสดงค่า array2 ตำแหน่ง index ที่ 4 --> 10.5
            Console.WriteLine(array2[4]);
        }

        public void ForLoopArray1Dimention()
        {
            //กำหนดขนาด Array เท่ากับ 10 type Integer
            int[] array1 = new int[10];
            //กำหนด Loop For ให้ i เท่ากับ 0 ,i น้อยกว่า 10 ,เพิ่มจำนวน i เรื่อยๆ (i = i + 1)
            for(int i = 0; i < 10; i++)
            {
                //กำหนดค่าใน Array ให้เท่ากับ (i + 1) * 5 ใน Index ที่ i 
                array1[i] = (i + 1) * 5;
                //แสดงค่าแบบไม่ขึ้นบรรทัดใหม่ของ array1 ใน Index ที่ i ตามด้วยเครื่องหมาย ,
                Console.Write(array1[i] + ",");
            }
        }

        public void Array2Dimention()
        {
            //กำหนดค่าใน array2 Type Integer 
            int[,] array2 = new int[,] { {1, 2, 3}, {4, 5, 6} };
            //แสดงค่า array2 ใน index ที่ 0(row) ,0(column)
            Console.WriteLine(array2[0, 0]);
            //แสดงค่า array2 ใน index ที่ 0(row) ,1(column)
            Console.WriteLine(array2[0, 1]);
            //แสดงค่า array2 ใน index ที่ 0(row) ,2(column)
            Console.WriteLine(array2[0, 2]);
            //แสดงค่า array2 ใน index ที่ 1(row) ,0(column)
            Console.WriteLine(array2[1, 0]);
            //แสดงค่า array2 ใน index ที่ 1(row) ,1(column)
            Console.WriteLine(array2[1, 1]);
            //แสดงค่า array2 ใน index ที่ 1(row) ,2(column)
            Console.WriteLine(array2[1, 2]);
        }

        public void ForLoopArray2Dimention()
        {
            //กำหนดค่าใน myArray Type Integer
            int[,] myArray = new int[,] { { 10, 43, -23, 5 }, { -5, 9, 15, 3 }, { 0,41,-30,-7} };
            //กำหนด Loop For ให้ i เท่ากับ 0 ,i น้อยกว่า 3 ,เพิ่มจำนวน i เรื่อยๆ (i = i + 1)
            for (int i=0; i<3; i++)
            {
                //กำหนด Loop For ให้ j เท่ากับ 0 ,j น้อยกว่า 4 ,เพิ่มจำนวน j เรื่อยๆ (j = j + 1)
                for (int j =0;j<4 ; j++)
                {
                    //แสดงค่า index ที่ i(row), แสดงค่า index ที่ j(column), แสดงค่าของ Array ตำแหน่ง index ที่ i(row) ,j(column)
                    Console.Write("[{0},{1}] = {2}\t" ,i,j,myArray[i,j]);
                }
            }
            Console.WriteLine();
        }

        public void JaggedArray()
        {
            //กำหนดขนาด Array เท่ากับ 4(row) type Integer
            int[][] jaggedArray = new int[4][];
            //กำหนด Loop For ให้ i เท่ากับ 0 ,i น้อยกว่าขนาด jaggedArray ,เพิ่มจำนวน i เรื่อยๆ (i = i + 1)
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                //กำหนดค่า (i * 3) + 1 ในตำแหน่ง Index ที่ i,
                //กำหนดค่า (i * 3) + 2 ในตำแหน่ง Index ที่ i,
                //กำหนดค่า (i * 3) + 3 ในตำแหน่ง Index ที่ i ตามลำดับ
                jaggedArray[i] = new int[] { (i * 3) + 1, (i * 3) + 2, (i * 3) + 3 };
            }
            //กำหนด Loop For ให้ i เท่ากับ 0 ,i น้อยกว่าขนาด jaggedArray ,เพิ่มจำนวน i เรื่อยๆ (i = i + 1)
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                //กำหนด Loop For ให้ j เท่ากับ 0 ,j น้อยกว่าขนาด jaggedArray[i] ,เพิ่มจำนวน j เรื่อยๆ (j = j + 1)
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    //แสดงค่า --> ตัวอย่าง array[0][0] = 1
                    Console.WriteLine("array[{0}][{1}] = {2}", i, j, jaggedArray[i][j]);
                }
            }
        }

        public void JaggedArray2()
        {
            //กำหนดตัวแปร jaggedArray Type Integer 
            int[][] jaggedArray = new int[][] {  
            //กำหนดค่าลงใน jaggedArray []
            new int[] { 1, 2, 3}, 
            //กำหนดค่าลงใน jaggedArray []
            new int[] { 4, 5, 6 }, 
            //กำหนดค่าลงใน jaggedArray []
            new int[] { 7, 8, 9 }, 
            //กำหนดค่าลงใน jaggedArray []
            new int[] { 10, 11, 12 }
        };

            //กำหนด Loop For ให้ i เท่ากับ 0 ,i น้อยกว่าขนาด jaggedArray ,เพิ่มจำนวน i เรื่อยๆ (i = i + 1)
            for (int i = 0; i < jaggedArray.Length; i++) {
                //กำหนด Loop For ให้ j เท่ากับ 0 ,j น้อยกว่าขนาด jaggedArray[i] ,เพิ่มจำนวน j เรื่อยๆ (j = j + 1)
                for (int j = 0; j < jaggedArray[i].Length; j++) {
                    //แสดงค่า --> ตัวอย่าง array[0][0] = 1
                    Console.WriteLine("array[{0}][{1}] = {2}", i, j, jaggedArray[i][j]);
            }
        }
        }
    }
}
