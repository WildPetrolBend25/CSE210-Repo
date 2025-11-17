

//inheritance

class Program
{
    static void Main(string[] args)
    {
        //print info from person class
        Person Person1 = new Person("Bob", "Larry", 34, 168);
        Console.WriteLine(Person1.GetPersonalInformation());
        
        //print infor from inherited police class
        Police myPolice = new Police("Taser, gun", "Bob", "Billy", 35, 250);
        Console.WriteLine(myPolice.GetPersonalInformation());
    }
}
