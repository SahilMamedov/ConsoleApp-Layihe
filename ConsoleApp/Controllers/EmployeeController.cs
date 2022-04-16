using Business.Services;
using DataAccess;
using Entities.Models;
using System;
using Utilities.Helper;

namespace ConsoleApp.Controllers
{
    public class EmployeeController
    {
        private EmployeeService employeeService;
        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }
        public void AddEmployee()
        {
            Extention.Print(ConsoleColor.Green, "Employee Name daxil edin");
            string name = Console.ReadLine();
            Extention.Print(ConsoleColor.Green, "Employee Surname daxil edin");
            string surname = Console.ReadLine();
        Enterage:
            Extention.Print(ConsoleColor.Green, "Employee Age daxil edin");
            int age = Convert.ToInt32(Console.ReadLine());
            if (Extention.AgeCheck(age)) ;
            else
            {
                goto Enterage;
            }

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
                        Position = position,
                        Salary = salary,
                        HotelName = hotelname,

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
                    return;

                }

            }
            Extention.Print(ConsoleColor.Red, "Bele bir Otel tapilmadi");
        }
        public void RemoveEmployee()
        {
            try
            {
                Extention.Print(ConsoleColor.Green, "Silmey istediyiniz Employee-nin ID-sini daxil edin");
                int id = Convert.ToInt32(Console.ReadLine());
                Extention.Print(ConsoleColor.Red, $"{employeeService.DeleteEmployee(id).Name} Silindi.");


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
        public void GetAllEmployee()
        {
        Enterhotelname:
            Extention.Print(ConsoleColor.Green, "Hotel Name Daxil edin");

            string hotelname = Console.ReadLine();
            foreach (var item in DataContext.Hotels)
            {
                if (hotelname == item.Name) ;
                else
                {
                    Extention.Print(ConsoleColor.Red, "Bele Otel yoxdur! adin duzgun qeyd edin");
                    goto Enterhotelname;
                }
            }
            foreach (var item in employeeService.GetAllEmployee(hotelname))
            {
                Extention.Print(ConsoleColor.Yellow, $"ID: {item.Id} \n" +
                    $"Name: {item.Name} \n" +
                    $"Surname: {item.SurName} \n" +
                    $"Age: {item.Age} \n" +
                    $"Position: {item.Position} \n" +
                    $"Salary: {item.Salary} \n" +
                    $"HotelName: {item.HotelName}");
                Extention.Print(ConsoleColor.Blue, "--------------------");
            }
        }
        public void GetEmployee()
        {
            Extention.Print(ConsoleColor.Green, "Tapmaq istediyiniz Employee-nin ID-sini daxil edin");
            int id = Convert.ToInt32(Console.ReadLine());
            employeeService.GetEmployee(id);


        }
        public void RemoveAllEmployee()
        {
        Enterhotelname:
            Extention.Print(ConsoleColor.Green, "Hotel Name Daxil edin");

            string hotelname = Console.ReadLine();
            foreach (var item in DataContext.Hotels)
            {
                if (hotelname == item.Name) ;
                else
                {
                    Extention.Print(ConsoleColor.Red, "Bele Otel yoxdur! adin duzgun qeyd edin");
                    goto Enterhotelname;
                }

                employeeService.DeletAllEmployee(hotelname);
            }
            //foreach (var item in employeeService.GetAllEmployee(hotelname))
            //{
            //    Extention.Print(ConsoleColor.Yellow, $"ID: {item.Id} \n" +
            //        $"Name: {item.Name} \n" +
            //        $"Surname: {item.SurName} \n" +
            //        $"Age: {item.Age} \n" +
            //        $"Position: {item.Position} \n" +
            //        $"Salary: {item.Salary} \n" +
            //        $"HotelName: {item.HotelName} \n" +
            //        $"Silindi..!");
                
            //    Extention.Print(ConsoleColor.Blue, "--------------------");

            //}

        }
    }
}
