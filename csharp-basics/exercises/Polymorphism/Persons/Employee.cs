using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    internal class Employee : Person
    {
        private string _job { get; }

        public Employee(string name, string lastname, string address, int id, string job)
            : base(name, lastname, address, id)
        {
            _job = job;
        }

        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}, from {Address}, working as {_job}. ID: {Id}");
        }
    }
}
