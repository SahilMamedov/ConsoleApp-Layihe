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
            try
            {
                Extention.Print(ConsoleColor.Green, "Employee Name daxil edin");
                string name = Extention.StringName();
                Extention.Print(ConsoleColor.Green, "Employee Surname daxil edin");
                string surname = Extention.StringName();
                Extention.Print(ConsoleColor.Green, "Employee Age daxil edin");
                int age = Extention.IntNum();
                Extention.Print(ConsoleColor.Green, "Employee Position daxil edin");
                string position = Extention.StringName();
                Extention.Print(ConsoleColor.Green, "Employee Salary daxil edin");
                int salary = Extention.IntCheck();
                Extention.Print(ConsoleColor.Green, "Employee HotelName daxil edin");
                string hotelname = Extention.StringName();

                foreach (var item in DataContext.Hotels)
                {
                    if (hotelname.ToLower() == item.Name)
                    {
                        Employee employee = new Employee()
                        {
                            Name = name.ToLower(),
                            SurName = surname.ToLower(),
                            Age = age,
                            Position = position.ToLower(),
                            Salary = salary,
                            HotelName = hotelname.ToLower(),

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
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public void RemoveEmployee()
        {
            try
            {
                Extention.Print(ConsoleColor.Green, "Silmey istediyiniz Employee-nin ID-sini daxil edin");
                int id = Extention.IntCheck();
                Extention.Print(ConsoleColor.Red, $"{employeeService.DeleteEmployee(id).Name} Silindi.");


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
        public void GetAllEmployee()
        {
            try
            {
               
                Extention.Print(ConsoleColor.Green, "Hotel Name Daxil edin");

                string hotelname = Extention.StringName();
                foreach (var item in DataContext.Hotels)
                {
                    if (hotelname.ToLower() == item.Name)
                    {

                        foreach (var item1 in employeeService.GetAllEmployee(hotelname.ToLower()))
                        {
                            

                            Extention.Print(ConsoleColor.Yellow, $"ID: {item.Id} \n" +
                                $"Name: {item1.Name} \n" +
                                $"Surname: {item1.SurName} \n" +
                                $"Age: {item1.Age} \n" +
                                $"Position: {item1.Position} \n" +
                                $"Salary: {item1.Salary} \n" +
                                $"HotelName: {item1.HotelName}");
                            Extention.Print(ConsoleColor.Blue, "--------------------");
                          
                        }
                       
                        
                           // Extention.Print(ConsoleColor.Red, "Otelinizde Employee Yoxdur..!");

                        

                    }
                    else
                    {
                        Extention.Print(ConsoleColor.Red, "Bele Otel yoxdur! adin duzgun qeyd edin");
                      
                    }

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        public void GetEmployee()
        {
            try
            {
                Extention.Print(ConsoleColor.Green, "Tapmaq istediyiniz Employee-nin ID-sini daxil edin");
                int id = Extention.IntCheck();
                
                employeeService.GetEmployee(id);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
        public void RemoveAllEmployee()
        {
            try
            {
           
                Extention.Print(ConsoleColor.Green, "Hotel Name Daxil edin");

                string hotelname = Extention.StringName();
                foreach (var item in DataContext.Hotels)
                {
                    if (hotelname.ToLower() == item.Name)
                    {
                        foreach (var item1 in employeeService.GetAllEmployee(hotelname.ToLower()))
                        {
                            Extention.Print(ConsoleColor.Yellow, $"ID: {item.Id} \n" +
                                $"Name: {item1.Name} \n" +
                                $"Surname: {item1.SurName} \n" +
                                $"Age: {item1.Age} \n" +
                                $"Position: {item1.Position} \n" +
                                $"Salary: {item1.Salary} \n" +
                                $"HotelName: {item1.HotelName} \n" +
                                $"Silindi..!");

                            Extention.Print(ConsoleColor.Blue, "--------------------");
                        }
                    }
                    else
                    {
                        Extention.Print(ConsoleColor.Red, "Bele Otel yoxdur! adin duzgun qeyd edin");
                      
                    }

                    employeeService.DeletAllEmployee(hotelname.ToLower());
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



        }

        public void UpdateEmployePosition()
        {
            try
            {
                Extention.Print(ConsoleColor.Green, "Position-u deyishmek istediyiniz Employeenin ID-sini daxil edin");

                int id = Extention.IntCheck();
                Extention.Print(ConsoleColor.Green, "Yeni Position-u qeyd edin");
                string position = Extention.StringName();
                employeeService.UpdateEmployeePosition(id, position.ToLower());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



        }
        public void UpdateEmployeeSalary()
        {
            try
            {
                Extention.Print(ConsoleColor.Green, "Salary-sin deyishmek istediyiniz Employeenin ID-sini daxil edin");
                int id = Extention.IntCheck();
                Extention.Print(ConsoleColor.Green, "Salary-sin daxil edin");
                int salary = Extention.IntCheck();
                employeeService.UpdateEmployeeSalary(id, salary);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
        public void UpdateEmployeeHotelname()
        {
            try
            {
                Extention.Print(ConsoleColor.Green, "Hotelname-in deyishmek istediyiniz Employeenin ID-sini daxil edin");
                int id = Extention.IntCheck();
                Extention.Print(ConsoleColor.Green, "Yeni HotelName-in daxil edin");
                string hotelname = Extention.StringName();

                employeeService.UpdateEmployeeHotelname(id, hotelname.ToLower());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
        public void UpdateEmployee()
        {
            try
            {
                while (true)
                {
                    Extention.Print(ConsoleColor.Cyan, $"1: Update Employe Position \n" +
                        $"2: Update Employee Salary \n" +
                        $"3: Update Employee HotelName \n" +
                        $"4: Quit");
                    int input = Extention.IntCheck();
                    if (input <= 4 && input > 0)
                    {
                        switch (input)
                        {
                            case (int)Extention.MenuUpdateEmployee.UpdateEmployeePosition:
                                UpdateEmployePosition();
                                break;
                            case (int)Extention.MenuUpdateEmployee.UpdateEmployeeSalary:
                                UpdateEmployeeSalary();
                                break;
                            case (int)Extention.MenuUpdateEmployee.UpdateEmployeeHotelName:
                                UpdateEmployeeHotelname();
                                break;
                        }

                    }
                    if (input == (int)Extention.MenuUpdateEmployee.Quit)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
    }
}
