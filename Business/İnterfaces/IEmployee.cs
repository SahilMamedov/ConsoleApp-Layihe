using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.İnterfaces
{
   public interface IEmployee
    {
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(int id, Employee employee);
        Employee DeleteEmployee(int id);
        Employee DeletAllEmployee(string Hotelname);
        Employee GetEmployee(int id);
        List<Employee> GetAllEmployee(string Hotelname = null);
    }
}
