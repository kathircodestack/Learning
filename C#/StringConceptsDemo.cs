using System;

namespace Learning.CSharp;

public class StringConceptsDemo
{
    public void Run()
    {
        string firstName = "John";
        string lastName = "Doe";

        string fullName = firstName + " " + lastName;
        string message = $"Hello, {fullName}!";

        Console.WriteLine(fullName);
        Console.WriteLine(message);
    }
}
