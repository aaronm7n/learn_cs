/* Console.ReadLine() */

string favoriteColor = Console.ReadLine();
Console.WriteLine("Oh, I love " + favoriteColor + " too!");
// User Input: yellow
// Output: yellow
//         Oh, I love yellow too!


/* Add a space to the end of your prompt */

Console.Write("What is your favorite color? ");
string favoriteColor = Console.ReadLine();
Console.WriteLine("Oh, I love " + favoriteColor + " too!");
// User Input: yellow
// Output: What is your favorite color? yellow
//         Oh, I love yellow too!


/* Understanding data types */

/*
    String (string): Text wrapped in quotes, like "Blue" or "25". Even a
    number becomes text when it's inside quotes.

    Integer (int): A whole number without quotes, like 25 or 100.
    You can do math with these.
*/


/* Console.ReadLine() always returns a string */

string age = Console.ReadLine();
Console.WriteLine(age + 1);
// User Input: 24
// Output: 241