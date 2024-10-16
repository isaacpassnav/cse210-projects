using System;

class Program
{
    static void Main(string[] args)
    {
        
        MathAssignment myMathAssignment = new MathAssignment("Isaac Pasapera", "Desarrollo Web", "Section 7.3", "Problems 8-19");
        Console.WriteLine(myMathAssignment.GetSumary());
        Console.WriteLine(myMathAssignment.GetHomeworkList());

        WritingAssignment myWritingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(myWritingAssignment.GetSumary());
        Console.WriteLine(myWritingAssignment.GetWritingInformation());

    }
}