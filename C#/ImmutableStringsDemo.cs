using System;

namespace Learning.CSharp;

public class ImmutableStringsDemo
{
    public void Run()
    {
        string text = "Hello";
        text = text + " World";

        Console.WriteLine(text);
    }
}
