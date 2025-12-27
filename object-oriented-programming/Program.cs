namespace object_oriented_programming
{
    internal class Program
    {
        // Interfaces are used to define behavior without implementation
        // and to achieve loose coupling,
        // while abstract classes are used to share common state and behavior
        // in an is-a relationship.
        // If you need flexibility and decoupling → use interface
        // supports multiple inheritance with interfaces only
        // interfaces can be implemented by any class, from any inheritance tree
        // interfaces define a contract that can be applied across different classes
        // interfaces are behavioral contracts,
        // abstract classes define a common base and shared implementation,
        // whereas abstract classes are part of a class hierarchy.
        // If you need shared state and behavior → use abstract class
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
            var notifier = new Notifier();
            var payslipGenerator = new PayslipGenerator(notifier);
            payslipGenerator.Generate(salariedEmployee);
            Console.WriteLine("------------------------------");
            payslipGenerator.Generate(internEmployee);
            Console.WriteLine("------------------------------");
            payslipGenerator.Generate(hourlyEmloyee);

        }

    }

}
