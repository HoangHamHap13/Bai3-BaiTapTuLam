using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab3_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //tạo đối tượng Car
            Car myCar = new Car();

            //gán giá trị cho các trường của đối tượng
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.colour = "black";
            myCar.year = 1995;

            //hiển thị thông tin về đối tượng myCar
            System.Console.WriteLine("Details:");
            System.Console.WriteLine("Make: " + myCar.make);
            System.Console.WriteLine("Model: " + myCar.model);
            System.Console.WriteLine("Colour: " + myCar.colour);
            System.Console.WriteLine("Year of release: " + myCar.year);

            //gọi phương thức
            myCar.Start();
            myCar.Stop();










        }
    }
}
