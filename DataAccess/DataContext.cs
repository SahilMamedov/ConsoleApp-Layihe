using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class DataContext
    {
      public static List<Hotel> Hotels { get; set; }
        public static List<Employee> Employees { get; set; }
        static DataContext()
        {
            Hotels = new List<Hotel>();
            Employees = new List<Employee>();
        }
    }
}
