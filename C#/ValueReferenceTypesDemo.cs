using System;

namespace Learning.CSharp;

public class ValueReferenceTypesDemo
{
    public void Run()
    {
        int number1 = 10;
        int number2 = number1;
        number2 = 20;

        string text1 = "Hello";
        string text2 = text1;
        text2 = "World";

        Console.WriteLine($"number1: {number1}");
        Console.WriteLine($"number2: {number2}");
        Console.WriteLine($"text1: {text1}");
        Console.WriteLine($"text2: {text2}");
    }
}
