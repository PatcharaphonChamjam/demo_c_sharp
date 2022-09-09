using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Class1
    {
        //prop public ขึ้นต้นด้วยตัวใหญ่เสมอ (pascalcase)
        //prop private ขึ้นต้นด้วย _ตามด้วยตัวพิมม์เล็ก พยางค์ตามด้วยตัวพิมพ์ใหม่ (camelcase)
        public int Id { get; set; }

        private string _firstName = "";

        /* public int Id
         {
             get { return Id; }
             private set { Id = value; }
         }*/

        public void SetId(int value, string valueN)
        {
            /*Id = id;*/
            _firstName = valueN;
        }
    }
}