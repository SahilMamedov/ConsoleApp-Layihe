using Business.Services;
using DataAccess;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace ConsoleApp.Controllers
{
   public class EmployeeController
    {
        public EmployeeService employeeService;
        public void AddEmployee()
        {
            Extention.Print(ConsoleColor.Green, "Employee Name daxil edin");
            string name = Console.ReadLine();
            Extention.Print(ConsoleColor.Green, "Employee Surname daxil edin");
            string surname = Console.ReadLine();
            Extention.Print(ConsoleColor.Green, "Employee Age daxil edin");
            int age = Convert.ToInt32(Console.ReadLine());
            Extention.Print(ConsoleColor.Green, "Employee Position daxil edin");
            string position = Console.ReadLine();
            Extention.Print(ConsoleColor.Green, "Employee Salary daxil edin");
            int salary = Convert.ToInt32(Console.ReadLine());
            Extention.Print(ConsoleColor.Green, "Employee HotelName daxil edin");
            string hotelname = Console.ReadLine();

            foreach (var item in DataContext.Hotels)
            {
                if (hotelname == item.Name)
                {
                    Employee employee = new Employee()
                    {
                        Name = name,
                        SurName = surname,
                        Age = age,
                        Position=position,
                        Salary=salary,
                        HotelName=hotelname,
    
                    };
                    employeeService.AddEmployee(employee);
                    Extention.Print(ConsoleColor.Yellow, $"ID: {employee.Id} \n" +
                        $"Name: {employee.Name} \n" +
                        $"Surname: {employee.SurName} \n" +
                        $"Age: {employee.Age} \n" +
                        $"Position: {employee.Position} \n" +
                        $"Salary: {employee.Salary} \n" +
                        $"HotelName: {employee.HotelName} \n" +
                        $"ShareData: {employee.ShareData}");

                }
                Extention.Print(ConsoleColor.Red, "Bele bir Otel tapilmadi");
            }

        }
        
    }
}
