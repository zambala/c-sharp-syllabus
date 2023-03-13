using System;

namespace Persons
{
    public class Student : Person
    {
        private double _gpa { get; }

        public Student(string name, string lastName, string address, int id, double gpa)
            : base(name, lastName, address, id)
        {
            _gpa = gpa;
        }

        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}, from {Address}, GPA: {_gpa}. ID: {Id}");
        }
    }
}
