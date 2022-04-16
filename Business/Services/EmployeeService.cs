using Business.İnterfaces;
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
              //  return false;
            }

            _employeeRepasitory.Delete(isExist);
            // return true;
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
        
         Employee isExist=_employeeRepasitory.GetOne(e => e.Id == id);
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

        //public Employee UpdateEmployee(int id, Employee employee)
        //{
        //    return _employeeRepasitory.GetOne(e => e.Name == employee.Name);
        //}

        public Employee UpdateEmployeePosition(int id, string position)
        {
          
            Employee isExist = _employeeRepasitory.GetOne(e => e.Id == id);
            if (isExist != null)
            {
                isExist.Position = position;
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
       
            Extention.Print(ConsoleColor.Red, "Bele bir Employee Tapilmadi..!");
            return null;
           
        }

        public Employee UpdateEmployeeSalary(int id, int salary)
        {
            throw new NotImplementedException();
        }

        public Employee UpdateEmployeeHotelname(int id, string hotelname)
        {
            throw new NotImplementedException();
        }
    }
}
