using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Address { get; }
        public int Id { get; }

        public Person(string firstName, string lastName, string address, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Id = id;
        }
        public virtual void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}, from {Address}. ID: {Id} ");
        }
    }
}
