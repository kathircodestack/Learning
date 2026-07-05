# C# Types, Variables, and Initialization

## 1. Numeric types
C# has several integer and floating-point types:

- `int`: common whole number type
- `long`: larger whole numbers
- `short`: smaller whole numbers
- `byte`: very small whole numbers
- `uint`: unsigned integer (non-negative)
- `ulong`: unsigned long integer
- `decimal`: high-precision money/financial values
- `double`: double-precision floating-point numbers
- `float`: single-precision floating-point numbers

Example:

```csharp
int age = 25;
double price = 19.99;
decimal salary = 2500.50m;
```

## 2. Booleans and logical operators
A boolean stores either `true` or `false`.

```csharp
bool isReady = true;
bool isLoggedIn = false;
```

Common operators:

- `&&` = AND
- `||` = OR
- `!` = NOT

Example:

```csharp
bool result = isReady && isLoggedIn;
```

## 3. Characters and strings
- `char` stores a single character.
- `string` stores a sequence of characters.

```csharp
char grade = 'A';
string name = "Alice";
```

### Important difference
- Single quotes: `'A'`
- Double quotes: `"Hello"`

A `char` is one character. A `string` is text made of one or more characters.

## 4. String concepts
### String interpolation
```csharp
string message = $"Hello, {name}!";
```

### String concatenation
```csharp
string fullName = firstName + " " + lastName;
```

## 5. Immutable strings
Strings in C# are immutable. That means once a string is created, it cannot be changed.

Example:

```csharp
string text = "Hello";
text = text + " World";
```

This does not modify the original string in place. Instead, a new string is created.

## 6. StringBuilder
`StringBuilder` is used when you need to build or change a lot of text efficiently.

```csharp
using System.Text;

StringBuilder sb = new StringBuilder();
sb.Append("Hello");
sb.Append(" World");
string result = sb.ToString();
```

Use `string` for simple text and `StringBuilder` for many modifications or repeated appends.

## 7. The `new` keyword
`new` creates an object or instance of a type.

```csharp
string name = new string('A', 3);
StringBuilder sb = new StringBuilder();
```

Use it when you need to create an instance of a class or a complex type.

## 8. Value types vs reference types
- Value types store their data directly.
- Reference types store a reference to the data.

Examples:

- Value types: `int`, `double`, `bool`, `char`, `decimal`
- Reference types: `string`, arrays, classes

## 9. `var`
`var` lets the compiler infer the type automatically.

```csharp
var age = 25;
var name = "Alice";
```

This is useful when the type is obvious from the value.

## 10. Variable initialization
A variable must be assigned a value before it is used.

```csharp
int count = 0;
string message = "Hello";
```

You can also declare without initialization, but you must assign it before using it:

```csharp
int count;
count = 10;
```

## 11. Methods and parameters
A method is a reusable block of code that performs a task.

### Method signature parts
A method signature usually includes:
- access modifier such as `public` or `private`
- return type such as `int` or `void`
- method name
- parameters inside parentheses

Example:

```csharp
public static int Add(int first, int second)
{
    return first + second;
}
```

### Return type
The return type tells you what a method gives back.

```csharp
int result = Add(1, 2);
```

### `void`
`void` means the method does not return a value.

```csharp
public static void PrintMessage()
{
    Console.WriteLine("Hello");
}
```

### `static`
`static` means the method belongs to the class itself and can be called without creating an object.

### Arguments vs parameters
- Parameters are the names declared in the method definition.
- Arguments are the values passed when calling the method.

```csharp
public static int Add(int first, int second)
{
    return first + second;
}

int sum = Add(3, 4);
```

### Conditional logic
```csharp
if (age > 18)
{
    Console.WriteLine("Adult");
}
else if (age == 18)
{
    Console.WriteLine("Just turned 18");
}
else
{
    Console.WriteLine("Minor");
}
```

### Switch / case
```csharp
switch (day)
{
    case "Monday":
        Console.WriteLine("Start of work week");
        break;
    case "Friday":
        Console.WriteLine("Almost weekend");
        break;
    default:
        Console.WriteLine("Midweek");
        break;
}
```

### Collections
```csharp
int[] numbers = { 1, 2, 3, 4 };
List<int> scores = new List<int> { 10, 20, 30 };
List<List<int>> matrix = new List<List<int>>
{
    new List<int> { 1, 2 },
    new List<int> { 3, 4 }
};
```

### Loops
```csharp
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

while (index < scores.Count)
{
    Console.WriteLine(scores[index]);
    index++;
}

foreach (var score in scores)
{
    Console.WriteLine(score);
}

do
{
    Console.WriteLine("Run at least once");
} while (false);
```

### Basic utility methods
```csharp
string text = "  Hello World  ";
text.ToUpper();
text.Trim();
text.Substring(0, 5);
text.Split(' ');
text.ToCharArray();
```

## Summary
- Learn the common numeric types and when to use them.
- Use `bool` for true/false logic.
- Use `char` for one character and `string` for text.
- Remember that strings are immutable.
- Use `StringBuilder` for heavy text building.
- Use `new` to create objects.
- Understand the difference between value and reference types.
- Use `var` when the compiler can infer the type.
- Always initialize variables before use.
- Understand methods, parameters, return types, conditionals, collections, loops, and common string utility methods.
