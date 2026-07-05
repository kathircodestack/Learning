using System;
using System.Text;

namespace Learning.CSharp;

public class StringBuilderDemo
{
    public void Run()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("Hello");
        builder.Append(" ");
        builder.Append("World");

        Console.WriteLine(builder.ToString());
    }
}
