using System;
using System.Security.Claims;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "sofware engineer";
        job1._company = "Microsoft Apple";
        job1._startYear = 2021;
        job1._endYear = 2024;

        Job job2 = new Job();
        job1._jobTitle = "Manager";
        job1._company = "Apple";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Resume resume1 = new Resume();
        resume1._name = "Isaac Pasapera Navarro";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        Console.WriteLine($"First job {resume1._jobs[0]._jobTitle}");

        resume1.DisplayResume();
    
        
    }
}