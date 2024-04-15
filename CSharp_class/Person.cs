using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_class
{
    internal class Person
    {
        public string? FirstName {  get; set; }
        public required string LastName { get; init; }

        public decimal Salary { get; set; }
    }
}
