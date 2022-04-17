using Business.İnterfaces;
using DataAccess;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using Utilities.Helper;

namespace Business.Services
{
    public class EmployeeService : IEmployee
    {
        public static int ID { get; set; }
        public EmployeeRepasitory _employeeRepasitory;
        public EmployeeService()
        {
            _employeeRepasitory = new EmployeeRepasitory();
        }
        public Employee AddEmployee(Employee employee)
        {
            ID++;
            employee.Id = ID;
            _employeeRepasitory.Create(employee);
            employee.ShareData = DateTime.Now;
            return employee;
        }

        public bool DeletAllEmployee(string hotelname)
        {
            List<Employee> isExist = _employeeRepasitory.GetAll(e => e.HotelName == hotelname);
            if (isExist == null)
            {
                Console.WriteLine("BOOOWDU");
                return false;


            }
            foreach (var item in isExist)
            {


                Extention.Print(ConsoleColor.Blue, $"ID: {item.Id} \n" +
                    $"Name: {item.Name} \n" +
                    $"Surname: {item.SurName} \n" +
                    $"HotelName: {item.HotelName} \n" +
                    $"Silindi..!");
                Extention.Print(ConsoleColor.Yellow, "-----------------");
                _employeeRepasitory.Delete(item);
            }
            return true;


        }

        public Employee DeleteEmployee(int id)
        {
            Employee isExist = _employeeRepasitory.GetOne(s => s.Id == id);
            if (isExist == null)
            {
                Extention.Print(ConsoleColor.Blue, "Bele bir Employee tapilmadi");
                
            }

            _employeeRepasitory.Delete(isExist);
            
            return isExist;
        }

        public List<Employee> GetAllEmployee(string Hotelname = null)
        {
            return _employeeRepasitory.GetAll(e => e.HotelName == Hotelname);
           

        }
        public List<Employee> GetAll()
        {
            return _employeeRepasitory.GetAll();
        }

        public Employee GetEmployee(int id)
        {

            Employee isExist = _employeeRepasitory.GetOne(e => e.Id == id);
            if (isExist == null)
            {
                Extention.Print(ConsoleColor.Red, "Axtardiqiniz ID-li Employee Tapilmadi..!");
                return null;
            }
            Extention.Print(ConsoleColor.Yellow, $"ID: {isExist.Id} \n" +
                $"Name: {isExist.Name} \n" +
                $"Surname: {isExist.SurName} \n" +
                $"Age: {isExist.Age} \n" +
                $"Position: {isExist.Position} \n" +
                $"Salary {isExist.Salary} \n" +
                $"HotelName: {isExist.HotelName} \n" +
                $"ShareData: {isExist.ShareData}");

            return isExist;
        }

       

        public Employee UpdateEmployeePosition(int id, string position)
        {

            Employee isExist = _employeeRepasitory.GetOne(e => e.Id == id);
            if (isExist != null)
            {
                isExist.Position = position;
                Extention.Print(ConsoleColor.Yellow, $"ID: {isExist.Id} \n" +
                 $"Name: {isExist.Name} \n" +
                 $"Surname: {isExist.SurName} \n" +
                 $"Age: {isExist.Age}");

                Extention.Print(ConsoleColor.Blue, $"Position: {isExist.Position}");
                Extention.Print(ConsoleColor.Yellow, $"Salary {isExist.Salary} \n" +
                    $"HotelName: {isExist.HotelName}");
                return isExist;
            }

            Extention.Print(ConsoleColor.Red, "Bele bir Employee Tapilmadi..!");
            return null;
        }
        public Employee UpdateEmployeeSalary(int id, int salary)
        {
            Employee isExist = _employeeRepasitory.GetOne(e => e.Id == id);
            if (isExist != null)
            {
                isExist.Salary = salary;
                Extention.Print(ConsoleColor.Yellow, $"ID: {isExist.Id} \n" +
                 $"Name: {isExist.Name} \n" +
                 $"Surname: {isExist.SurName} \n" +
                 $"Age: {isExist.Age} \n" +
                 $"Position: {isExist.Position}");
                Extention.Print(ConsoleColor.Blue, $"Salary {isExist.Salary}");
                Extention.Print(ConsoleColor.Yellow, $"HotelName: {isExist.HotelName}: {isExist.Position}");
                return isExist;
            }
            Extention.Print(ConsoleColor.Red, "Bele bir Employee Tapilmadi..!");
            return null;

        }

        public Employee UpdateEmployeeHotelname(int id, string hotelname)
        {
            Employee isExist = _employeeRepasitory.GetOne(e => e.Id == id);
            
            if (isExist != null)
            {
                
                foreach (var item in DataContext.Hotels)
                {
                    if (item.Name == hotelname)
                    {
                        Extention.Print(ConsoleColor.Yellow, $"ID: {isExist.Id} \n" +
                $"Name: {isExist.Name} \n" +
                $"Surname: {isExist.SurName} \n" +
                $"Age: {isExist.Age} \n" +
                $"Position: {isExist.Position} \n" +
                $"Salary: {isExist.Salary}");
                        Extention.Print(ConsoleColor.Blue, $"HotelName: {isExist.HotelName}");
                        return isExist;
                    }
                    
                }
               Extention.Print(ConsoleColor.Red, "Yazdiqiniz Namede Hotel tapilmadi..!");

            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Bele bir Employee Tapilmadi..!");
                return null;
            }
            return isExist;
        }
    }
}
