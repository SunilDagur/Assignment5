// File: PersonProperties.cs

using System;

public partial class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

// File: PersonMethods.cs


public partial class Person
{
    public void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
}


// File: Program.cs

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person
        {
            FirstName = "Sunil",
            LastName = "Dagur"
        };

        person.PrintFullName();
    }
}
