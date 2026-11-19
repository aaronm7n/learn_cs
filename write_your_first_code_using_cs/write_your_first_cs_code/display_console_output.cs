Console.WriteLine("Hello, world!");
// Ourput: Hello, world!

Console.WriteLine("Hello" + " " + "world!");
// Output: Hello world!


/* Escape Characters */

// \n: Moves text to a new line
Console.WriteLine("Line 1\nLine2");
// Output: Line 1
//         Line 2

// \t: Adds a tab space
Console.WriteLine("Name:\tAaron");
// Output: Name:    Aaron

// \\: Prints a literal backslash
Console.WriteLine("Path:C:\\Users");
// Output: Path:C:\Users

// \": Prints a double quote
Console.WriteLine("She said, \"Hi!\"");
// Output: She said, "Hi!"


/* Console.Write() vs. Console.WriteLine() */

// Console.Write():
Console.Write("Hello");
Console.Write(" ");
Console.Write("world!");
// Output: Hello world!

// Console.WriteLine():
Console.WriteLine("Hello");
Console.WriteLine(" ");
Console.WriteLine("world!");
// Output: Hello
//         
//         world!