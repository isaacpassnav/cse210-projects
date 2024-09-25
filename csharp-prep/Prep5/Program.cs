using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome ();

        string userName = PromptUserName(); 
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Wellcome to the program.");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?:");
        string name =  Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your number:");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber( int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    
}