using System;

namespace EmployeeTest
{
    class Program
    {
        static void Main(string[] args)
        {
           Employee employee = new Employee("james","stuart",5000);
           Console.Write(employee.name + " " + employee.Lastname + " " + employee.Monthlysalary);
        }
    }
}
