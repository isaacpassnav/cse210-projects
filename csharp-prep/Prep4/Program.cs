using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while(userNumber != 0)
        {
            Console.Write("Enter a number(0 to quit):");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if(userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        // Part 2: Compute the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        // There are several ways to do this, such as sorting the list

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if(number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is:{max}");
        //stretch challenge

        int smallPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if(number > 0 && number < smallPositive)
            {
                smallPositive = number;
            }
        }
        if(smallPositive == int.MaxValue)
        {
            Console.WriteLine("There were no positive numbers entered.");
        }
        else
        {
            Console.WriteLine($"The smalles positive number is: {smallPositive}");
        }

    }
}