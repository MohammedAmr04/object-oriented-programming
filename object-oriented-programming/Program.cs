namespace object_oriented_programming
{
    internal class Program
    {
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


        }

    }

}
