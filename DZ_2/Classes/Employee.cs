using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2.Classes
{
    internal class Employee
    {
        public string Name { get; set; } = string.Empty;
        public string SurName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public DateTime EmploymentDate { get; set; }
    }
}
