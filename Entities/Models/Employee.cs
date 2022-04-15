using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public string Salary { get; set; }
        public string HotelName { get; set; }
        public DateTime ShareData { get; set; }

    }
}
