using System;

public class Resume
{
    public string _name;

    // the job list
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job myJobs in _jobs)
        {
            // goes through thee job lists
            myJobs.Display();
        }
    }
}