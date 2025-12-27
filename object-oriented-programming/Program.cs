namespace object_oriented_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Employee = new Employee();
            // before encapsulation 
            //Employee.FirstName = "Mohammed";
            Employee.SetName("Mohammed", "Amr");
            // before encapsulation
            //Employee.BirthDate = new DateOnly(1700, 5, 23);
            Employee.SetBirthDate(new DateOnly(1960,5,5));
            // task make encapsulation to salary and tax
            Employee.BasicSalary = -5000;
            Employee.TaxPercentage = 140;

            PersonDetails(Employee);
            Console.WriteLine($" Employee BasicSalary is {Employee.BasicSalary}");
            Console.WriteLine($" Employee TaxPercentage is {Employee.TaxPercentage}");
            Console.WriteLine("------------------------------------------------------");
            var applicant = new Applicant();
            applicant.SetName("Applicant", "2");
            applicant.SetBirthDate(new DateOnly(2004,3,11));
            PersonDetails(applicant);


            void PersonDetails(Person person)
            {
                Console.WriteLine($" Employee Name is {person.FirstName} {person.LastName} ");
                Console.WriteLine($" Employee Birthdate is {person.BirthDate}");
            }
        }
      
    }

}
