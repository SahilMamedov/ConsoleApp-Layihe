using Business.İnterfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace Business.Services
{
  public  class EmployeeService : IEmployee
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

                return false;
               
            }
            foreach (var item in isExist)
            {
               
                _employeeRepasitory.Delete(item);
                Extention.Print(ConsoleColor.Red, $"ID: {item.Id} \n" +
                    $"Name: {item.Name} \n" +
                    $"Surname: {item.SurName} \n" +
                    $"HotelName: {item.HotelName} \n" +
                    $"Silindi..!");

            }
            return true;
           
            
        }

        public Employee DeleteEmployee(int id)
        {
            Employee isExist = _employeeRepasitory.GetOne(s => s.Id == id);
            if (isExist == null)
            {
                return null;
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
            return _employeeRepasitory.GetOne(e => e.Id == id);
        }

        public Employee UpdateEmployee(int id, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
