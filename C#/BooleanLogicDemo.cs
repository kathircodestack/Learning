using System;

namespace Learning.CSharp;

public class BooleanLogicDemo
{
    public void Run()
    {
        bool isReady = true;
        bool isLoggedIn = false;

        bool canAccess = isReady && isLoggedIn;
        bool canTryAgain = isReady || isLoggedIn;

        Console.WriteLine($"Can access: {canAccess}");
        Console.WriteLine($"Can try again: {canTryAgain}");
    }
}
