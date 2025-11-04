using System;

class Program
{
    // static void = can call the function without a return value.
    //must always return a value except when calling void

    //make your own function
    static void TestValues(int x, float y, double z)
    {
        Console.WriteLine($"The values are: {x}, {y}, {z}");
    }

    //function that returns a value
    static int AddValues(int n1, int n2, int n3)
    {
        int total = n1 + n2 + n3;
        return total;
    }


    static void Main(string[] args)
    {
        TestValues(10, (float)123.234, 23423.234234234234);
        int total = AddValues(10, 20, 30);
        Console.WriteLine($"The total is {total}");

        // //write line moves the cursor to the next line
        // Console.WriteLine("Hello Sandbox World!");
        // string firstName;
        // string lastName;

        // //console. write leaves the cursor after the after the print statement so that you can input something
        // Console.Write("Enter your first name: ");
        // firstName = Console.ReadLine();

        // Console.Write("Enter your last name: ");
        // lastName = Console.ReadLine();

        // Console.WriteLine($"Your full name is {firstName} {lastName}");

        // //if statement
        // int x = 10;
        // if (!(x == 10 || x == 12 && x == 13 && x != 23))
        // {
        //     Console.WriteLine($"X is {x}");
        // }
        // else if (x == 435)
        // {
        //     Console.WriteLine("Hey bob");
        // }

        // Console.WriteLine(Math.Pow(2, 10));
        // Console.WriteLine($"{x}, {++x}, {x++}, {x}");

        // //for loops in C#
        // for (int i = 0; i < 20; i++)
        // {
        //     Console.WriteLine($"The value of i is {i}");
        // }

        // //count to 10000 by 10
        // for (int countUp = 0; countUp <= 1000; countUp += 10)
        // {
        //     Console.WriteLine($"The number is {countUp}");
        // }

        // //count down to 0 from 1000
        // for (int countDown = 1000; countDown >= 0; countDown -= 100)
        // {
        //     Console.WriteLine(countDown);
        // }

        // bool done = false;

        // while (!done)
        // {
        //     Console.Write("Input your age ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine($"Super age: {age}");
        //     }
        // }

        // //do while loops - guarenteed that the code will run atleast once
        // done = false;
        // do
        // {
        //     Console.Write("Input your age ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine($"Super age: {age}");
        //     }
        // } while (!done);

        // List<int> numbers = new List<int>();
        // numbers.Add(10);
        // numbers.Add(101);
        // numbers.Add(102);
        // foreach (int n in numbers)
        // {
        //     Console.WriteLine($"The number is {n}");
        // }

        //Fucntions


    }
}