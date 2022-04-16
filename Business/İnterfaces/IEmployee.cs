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
        Employee UpdateEmployeePosition(int id,string position);
        Employee UpdateEmployeeSalary(int id, int salary);
        Employee UpdateEmployeeHotelname(int id, string hotelname);
        Employee DeleteEmployee(int id);
        bool DeletAllEmployee(string Hotelname);
        Employee GetEmployee(int id);
        List<Employee> GetAllEmployee(string Hotelname = null);
    }
}
