using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //nothing here yet
        Console.WriteLine("Hello World");

        // creat a job instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyTitle = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2023;
        job1.Display();

        // second job instance
        Job job2 = new Job();
        job2._jobTitle = "Managaer";
        job2._companyTitle = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        job2.Display();

        // call the resume class
        
    }

    
}