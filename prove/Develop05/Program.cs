using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        //instances
        Menu myMenu = new Menu();

        //constrcutors

        //method calling 
        int userinput = myMenu.DisplayMenu();

        //go into different activites
        if (userinput == 1)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Yay, it works");
        }
    }
}