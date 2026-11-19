/* Concatenation (joining strings together) */

string first = "Hello";
string last = "world";
string message = first + ", " + last + "!";
Console.WriteLine(message);
// Output: Hello, world!


/* A better way: String interpolation */

string name = "Aaron";
Console.WriteLine($"Hello, {name}!");
// Output: Hello, Aaron!


/* A cleaner way to combine input and output */

string name2 = Console.ReadLine();
Console.WriteLine($"Hello, {name2}! Nice to meet you.");
// Output: Hello, Aaron! Nice to meet you.


/* Common string methods */

// .ToUpper(): Converts text to uppercase
Console.WriteLine("hello".ToUpper());
// Output: HELLO

// .ToLower(): Converts text to lowercase
Console.WriteLine("HELLO".ToLower());
// Output: hello

// .Replace(old, new): Swaps out specific characters
Console.WriteLine("cat".Replace("c", "b"));
// Output: bat

// Strings also have a property named Length that holds the number
// of characters in the tring. A property looks like a method but doesn't
// use parentheses:
string name3 = "Aaron";
Console.WriteLine(name.Length);
// Output: 5


/* Practical example */

Console.Write("What's your name? ");
string name = Console.ReadLine();
string greeting = $"Welcome, {name.ToUpper()}!";
Console.WriteLine(greeting);
// User Input: aaron
// Output: What's your name? aaron
//         Welcome, AARON!