using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EmployeeRepasitory : IRepasitory<Employee>
    {
        public bool Create(Employee employee)
        {
            try
            {
                DataContext.Employees.Add(employee);
                return true;
            }
            catch (Exception )
            {

                throw;
            }
        }

        public bool Delete(Employee entity)
        {
            try
            {
                DataContext.Employees.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }
        

        public List<Employee> GetAll(Predicate<Employee> filter = null)
        {

            return filter == null ? DataContext.Employees :
                DataContext.Employees.FindAll(filter);
        }

        public Employee GetOne(Predicate<Employee> filter )
        {
            try
            {
                return DataContext.Employees.Find(filter);
                //return filter == null ? DataContext.Employees[0] :
                //    DataContext.Employees.Find(filter);

            }
            catch (Exception)
            {

                throw;
            }
           
        }

       
    }
}
