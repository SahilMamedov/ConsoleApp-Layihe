using Business.İnterfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    class EmployeeService : IEmployee
    {
        EmployeeRepasitory _employeeRepasitory;
        public Employee AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
