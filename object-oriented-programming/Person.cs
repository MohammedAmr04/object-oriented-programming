using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming
{
//     We use abstract classes to represent base concepts
// that should not be instantiated directly,
// and to enforce a common contract for derived classes.

// Inheritance is used only when there is a true "is-a" relationship.
// The derived class must represent a specialized type of the base class,
// not just share some common data or behavior.
// If the relationship is "has-a", composition should be used instead.

    internal abstract class Person
    // Abstract class representing a generic person
    // which cannot be instantiated directly
    // why abstract?
    // Because Person is a general concept
    // and we want to enforce that only specific types of persons
    
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public void SetName(string firstName, string lastName)
        {
            if (String.IsNullOrWhiteSpace(lastName) || String.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentNullException("first or last name is null");
            }
            FirstName = firstName;
            LastName = lastName;
        }
        public DateOnly BirthDate { get; private set; }

        public void SetBirthDate(DateOnly date)
        {
            if (date < new DateOnly(1960, 1, 1))
            {
                throw new ArgumentException("Invalid BirthDate Value");

            }
            BirthDate = date;

        }

    }
}
