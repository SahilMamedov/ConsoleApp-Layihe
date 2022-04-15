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

        public Employee DeletAllEmployee(string Hotelname)
        {
            _employeeRepasitory.
        }

        public Employee DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployee(string Hotelname = null)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Employee UpdateEmployee(int id, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
