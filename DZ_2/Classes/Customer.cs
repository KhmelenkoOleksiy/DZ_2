using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2.Classes
{
    internal class Customer
    {
        public string Name { get; set; } = string.Empty;
        public string SurName { get; set; } = string.Empty;
        public string Address {  get; set; } = string.Empty;

        public required List<decimal> Orders { get; set; }
    }
}
