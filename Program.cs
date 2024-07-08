using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Assignment10._2._2OOPLINQQuery
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
             {
                new Employee() {Id=1, Name= "John", Salary= 4500, Age= 49 },
                new Employee() {Id=2, Name= "Shawn", Salary= 6000, Age= 39 },
                new Employee() {Id=3, Name= "Rob", Salary= 5100, Age= 28 }
             };

            var employeeQuery = from employee in list
                                where employee.Salary > 5000 && employee.Age < 30 
                                select employee;
            foreach ( Employee employee in employeeQuery )
            {
                Console.WriteLine( employee.Name );
                Console.WriteLine( employee.Salary ); 
                Console.WriteLine( employee.Age );

            }
        }            
    }
}