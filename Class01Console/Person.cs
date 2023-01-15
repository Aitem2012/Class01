﻿namespace Class01Console
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(Guid id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public string SayMyName()
        {
            return $"Hello, My name is {FirstName} {LastName}";
        }

    }
}
