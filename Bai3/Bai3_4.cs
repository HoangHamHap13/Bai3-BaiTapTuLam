using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenAcademy
{
    internal class Bai3_4
    {
        public void EmployeeInfo()
        {
            
            Employee emp0 = new Employee();
            emp0.id = 007;
            emp0.name = "Double Agent";
            emp0.yearOfBirth = 1995;
            emp0.salaryLevel = 20;
            emp0.basicSalary = 15000;

            emp0.GetIncome();
            emp0.Display();


            Employee emp1 = new Employee();
            Console.WriteLine("ID: "); emp1.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:"); emp1.name = Console.ReadLine();
            Console.WriteLine("Year of Birth:"); emp1.yearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Salary Level: "); emp1.salaryLevel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Basic Salary: "); emp1.basicSalary = Convert.ToDouble(Console.ReadLine());





        }
    }
}
