using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //nothing here yet

    }

    //job class
    //responsibilities: Keeps track of the company, job title, start year, and end year.
    public class Job
    {
        string _company = "";
        string _jobTitle = "";
        int _startYear = 0;
        int _endYear = 0;

        static void Display()
        {
            //display the info function
        }
    }
    
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