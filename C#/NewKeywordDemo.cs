using System;
using System.Text;

namespace Learning.CSharp;

public class NewKeywordDemo
{
    public void Run()
    {
        string name = new string('A', 3);
        StringBuilder builder = new StringBuilder();

        Console.WriteLine(name);
        builder.Append("Created with new");
        Console.WriteLine(builder.ToString());
    }
}
