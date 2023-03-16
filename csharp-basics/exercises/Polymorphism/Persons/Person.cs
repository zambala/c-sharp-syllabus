﻿using System;

namespace Persons
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }

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
