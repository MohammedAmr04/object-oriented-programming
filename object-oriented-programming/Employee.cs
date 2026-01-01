using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming
{
    internal class Employee
    {
        // Encapsulation:
        // Public getter + private setter
        // The name cannot be changed directly from outside
        public string FirstName { get; private set; }
        public string LastName { get;private set; }
        // Method responsible for validating and setting name
        public void SetName(string firstName, string lastName)
        {
            if( String.IsNullOrWhiteSpace(lastName) || String.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentNullException("first or last name is null");
            }
            FirstName = firstName;
            LastName = lastName;
        }
        public DateOnly BirthDate { get; private set; }
        // Validation logic is hidden inside the class
        public void SetBirthDate(DateOnly date)
        {
            if(date < new DateOnly(1960, 1, 1))
            {
                throw new ArgumentException("Invalid BirthDate Value");

            }
            BirthDate = date;

        }
        public decimal BasicSalary { get; set; }
        public int TaxPercentage { get; set; }
    }
}
