using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?");
        string first = Console.ReadLine();

        Console.Write("What is your last name?");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}");

        // int x = 5;
        // int y = 10;

        // if(x < y)
        // {
        //     Console.WriteLine("greater than y");
        // }
        // else if(x > y)
        // {
        //     Console.WriteLine("greater than z");
        // }
        // else
        // {
        //     Console.WriteLine("less than both");
        // }
    }

}