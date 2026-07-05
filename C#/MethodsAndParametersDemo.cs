using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning.CSharp;

public class MethodsAndParametersDemo
{
    public void Run()
    {
        int result = Add(3, 4);
        Console.WriteLine($"Add result: {result}");

        if (result > 5)
        {
            Console.WriteLine("Result is greater than 5");
        }
        else if (result == 5)
        {
            Console.WriteLine("Result is exactly 5");
        }
        else
        {
            Console.WriteLine("Result is less than 5");
        }

        string grade = "B";
        switch (grade)
        {
            case "A":
                Console.WriteLine("Excellent");
                break;
            case "B":
                Console.WriteLine("Good");
                break;
            default:
                Console.WriteLine("Needs improvement");
                break;
        }

        int[] numbers = { 1, 2, 3, 4 };
        List<int> numberList = new List<int> { 1, 2, 3 };
        List<List<int>> matrix = new List<List<int>>
        {
            new List<int> { 1, 2 },
            new List<int> { 3, 4 }
        };

        Console.WriteLine("Array values:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("List values:");
        int index = 0;
        while (index < numberList.Count)
        {
            Console.WriteLine(numberList[index]);
            index++;
        }

        Console.WriteLine("Foreach values:");
        foreach (var item in numberList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Do while example:");
        int counter = 0;
        do
        {
            Console.WriteLine(counter);
            counter++;
        } while (counter < 3);

        string text = "  Hello World  ";
        Console.WriteLine($"ToUpper: {text.ToUpper()}");
        Console.WriteLine($"Trim: {text.Trim()}");
        Console.WriteLine($"Substring: {text.Substring(0, 5).Trim()}");
        Console.WriteLine($"Split: {string.Join(", ", text.Split(' '))}");
        Console.WriteLine($"ToCharArray length: {text.ToCharArray().Length}");
        Console.WriteLine($"ToList example: {string.Join(", ", new[] { 1, 2, 3 }.ToList())}");

        Console.WriteLine("Matrix values:");
        foreach (var row in matrix)
        {
            Console.WriteLine(string.Join(", ", row));
        }
    }

    public static int Add(int first, int second)
    {
        return first + second;
    }
}
