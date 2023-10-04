using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab3_3
{
    internal class Car
    {
        //khai báo các trường với phạm vi public 
        public string make;
        public string model;
        public string colour;
        public int year;

        //định nghĩa phương thức Start
        public void Start()
        {
            System.Console.WriteLine(model + "khởi động");
        }

        //định nghĩa phương thức Stop
        public void Stop() 
        {
            System.Console.WriteLine(model + "dừng");
        }


    }
}
