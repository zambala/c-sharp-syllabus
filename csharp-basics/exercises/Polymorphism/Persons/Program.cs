using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("John", "Doe", "Station Road", 12231);
            var employee = new Employee("Jane", "Doe", "Park Road", 213123, "accountant");
            var student = new Student("Rick", "Pickle", "Park Road", 213123, 3.7);

            person.Display();
            employee.Display();
            student.Display();
            Console.ReadKey();
        }
    }
}