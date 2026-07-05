using System;

namespace Learning.CSharp;

public class NumericTypesDemo
{
    public void Run()
    {
        int age = 25;
        long bigNumber = 1234567890123L;
        double price = 19.99;
        decimal salary = 2500.50m;

        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Big number: {bigNumber}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Salary: {salary}");
    }
}
