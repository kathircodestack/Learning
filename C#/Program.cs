using Learning.CSharp;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Numeric Types ===");
        new NumericTypesDemo().Run();

        Console.WriteLine("\n=== Boolean Logic ===");
        new BooleanLogicDemo().Run();

        Console.WriteLine("\n=== Characters and Strings ===");
        new CharacterAndStringDemo().Run();

        Console.WriteLine("\n=== String Concepts ===");
        new StringConceptsDemo().Run();

        Console.WriteLine("\n=== Immutable Strings ===");
        new ImmutableStringsDemo().Run();

        Console.WriteLine("\n=== StringBuilder ===");
        new StringBuilderDemo().Run();

        Console.WriteLine("\n=== New Keyword ===");
        new NewKeywordDemo().Run();

        Console.WriteLine("\n=== Value vs Reference Types ===");
        new ValueReferenceTypesDemo().Run();

        Console.WriteLine("\n=== Var ===");
        new VarDemo().Run();

        Console.WriteLine("\n=== Variable Initialization ===");
        new VariableInitializationDemo().Run();

        Console.WriteLine("\n=== Methods and Parameters ===");
        new MethodsAndParametersDemo().Run();
    }
}
