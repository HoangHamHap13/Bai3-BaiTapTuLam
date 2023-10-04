using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenAcademy

{
    internal class Employee
    {
        public int id;
        public string name;
        public int yearOfBirth;
        public double salaryLevel;
        public double basicSalary;

        //phương thức GetIncome() trả về thu nhập của nhân viên. 
        //Thu nhập = bậc lương * lương cơ bản 
        public void GetIncome()
        {
            double income;
            income = salaryLevel * basicSalary;
            System.Console.WriteLine($"Lương nhận = {income}");
        }
        


        public void Display()
        {
            System.Console.WriteLine("ID: " + id);
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Year of Birth: " + yearOfBirth);
            System.Console.WriteLine("Lương cơ bản: " + basicSalary);
            System.Console.WriteLine("Bậc lương: " + salaryLevel);
            System.Console.WriteLine("Thu nhập: {0}", basicSalary * salaryLevel);
        }

    }
}
