namespace object_oriented_programming
{
    internal class Program
    {
    // Encapsulation helps keep the object in a valid state
    // by hiding internal data, applying business logic inside the class,
    // and preventing direct access that could lead to invalid values.

        static void Main(string[] args)
        {
            // Create new employee object
            var Employee = new Employee();
            // Encapsulation: setting name through a method
            // Direct access is not allowed because setters are private
            Employee.SetName("Mohammed", "Amr");
            // Encapsulation: setting birthdate with validation
            Employee.SetBirthDate(new DateOnly(1960,5,5));
            // These values are invalid logically
            // The goal of encapsulation is to prevent such cases
            // task make encapsulation to salary and tax
            Employee.BasicSalary = -5000;
            Employee.TaxPercentage = 140;

            Console.WriteLine($" Employee Name is {Employee.FirstName} {Employee.LastName} ");
            Console.WriteLine($" Employee Birthdate is {Employee.BirthDate}");
            Console.WriteLine($" Employee BasicSalary is {Employee.BasicSalary}");
            Console.WriteLine($" Employee TaxPercentage is {Employee.TaxPercentage}");

        }
    }
}
