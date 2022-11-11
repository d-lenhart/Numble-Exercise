using QuadaxCodingAssessment;
using System;

Methods methods = new Methods();

Random numberRandomizer = new Random();
int firstRandomDigit = numberRandomizer.Next(1, 6);
int secondRandomDigit = numberRandomizer.Next(1, 6);
int thirdRandomDigit = numberRandomizer.Next(1, 6);
int fourthRandomDigit = numberRandomizer.Next(1, 6);
string generatedAnswer = string.Concat(firstRandomDigit, secondRandomDigit, thirdRandomDigit, fourthRandomDigit).ToString();

string userResult = "";

string userResultString = "";
string userGuess = "";
bool success = false;
int count = 0;

Console.WriteLine("Welcome to Numble!");
Console.WriteLine();
Console.WriteLine("I am thinking of a four digit number, where each digit is betwenn 1 and 6.");
Console.WriteLine("What number am I thinking of? If you have a matching number in the right location,");
Console.WriteLine("you'll see a + in its place. If you have a matching number, but in the wrong location,");
Console.WriteLine("you'll see a - in its place. You have 10 tries to get all four +'s in a row.");
Console.WriteLine();
Console.WriteLine("Good luck!");

while ((userResultString != generatedAnswer) && (count < 10))
{
    userGuess = Console.ReadLine();
    success = methods.IsValidNumber(userGuess);

    if (success == true)
    {
        userResult = methods.CheckGuess(userGuess, generatedAnswer);

        userResultString = string.Join(",", userResult).Replace(",", "");
        Console.WriteLine(userResultString);
        if (userResultString.Contains("++++"))
        {
            Console.WriteLine("Splendid! You solved Numble!");
            Environment.Exit(0);
        }
        else
        {
            count++;
            userResult = "";
            Console.WriteLine("Sorry, try again. You have " + (10 - count) + " attempts remaining.");
            Console.WriteLine();
            success = false;

        }
    }
}

Console.WriteLine("Game over :(");
Environment.Exit(0);


