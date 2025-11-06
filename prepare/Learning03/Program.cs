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
        job1._jobTitle = "Software";
        job1.Display();

    
    }

    //job class
    //responsibilities: Keeps track of the company, job title, start year, and end year.
    
    
    public class Resume
    {
        string _name = "";
        List<Job> _jobs;

        static void Display()
        {
            //display function
        }
    }
    
}