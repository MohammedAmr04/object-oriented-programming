namespace object_oriented_programming
{
    internal class Program
    {
    // Encapsulation helps keep the object in a valid state
    // by hiding internal data, applying business logic inside the class,
    // and preventing direct access that could lead to invalid values.

        static void Main(string[] args)
        {

           var salariedEmployee = new SalariedEmployee();
            salariedEmployee.BasicSalary = 2000;
            salariedEmployee.Transportation = 500;
            salariedEmployee.Housing = 1000;
            Console.WriteLine($"Salary of salariedEmployee {salariedEmployee.GetSalary()} ");
            Console.WriteLine($"Salary of salariedEmployee {salariedEmployee.GetSalary(500)} ");

            Console.WriteLine("----------------------------------------------------------");
            var hourlyEmloyee  = new HourlyEmployee();
            hourlyEmloyee.HourRate = 1000;
            hourlyEmloyee.TotalWorkingHours = 10;
            Console.WriteLine($"Salary of hourlyEmloyee {hourlyEmloyee.GetSalary()} ");
            Console.WriteLine("----------------------------------------------------------");
            var internEmployee = new InternEmployee();
            Console.WriteLine($"Salary of internEmployee {internEmployee.GetSalary()} ");
            Console.WriteLine("----------------------------------------------------------");

//             // Create new employee object
//             var Employee = new Employee();
//             // Encapsulation: setting name through a method
//             // Direct access is not allowed because setters are private
//             Employee.SetName("Mohammed", "Amr");
//             // Encapsulation: setting birthdate with validation
//             Employee.SetBirthDate(new DateOnly(1960,5,5));
//             // These values are invalid logically
//             // The goal of encapsulation is to prevent such cases
//             // task make encapsulation to salary and tax
//             Employee.BasicSalary = -5000;
//             Employee.TaxPercentage = 140;


        }

    }

}
