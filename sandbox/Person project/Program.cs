

//inheritance

class Program
{
    public static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine(person.GetPersonalInformation());
        Console.WriteLine($" ${person.GetSalary()}");
    }

    static void Main(string[] args)
    {
        //print info from person class
        // Person Person1 = new Person("Bob", "Larry", 34, 168);    Cannot create instance of abstract class
        // Console.WriteLine(Person1.GetPersonalInformation());
        
        //print infor from inherited police class
        Police myPolice = new Police("Taser, gun", "Bob", "Billy", 35, 250);

        Doctor myDoctor = new Doctor("knife, needle", "billy", "jones", 56, 134);

        //can access methods in parent classes directly
        Console.WriteLine(myPolice.GetPersonalInformation());

        Console.WriteLine(myPolice.GetPoliceInformation());
        Console.WriteLine(myDoctor.DoctorInformation());

        //SetAge is a base class method (but mydoctor has access bc its dervided from those methods)
        myDoctor.SetAge(45);
        Console.WriteLine($"Edited age: {myDoctor.DoctorInformation()}");

        //surgeon class inhertits doctor class
        Surgeon mySergeon = new Surgeon("Surgeon", "Hammer, big spoon", "Kaladin", "Stormblist", 56, 154);
        Console.WriteLine(mySergeon.GetSurgeonInformation());

        Console.WriteLine("\n\n\n\n\n");
        Console.WriteLine("Polymorphism");

        //polymorphism
        List<Person> myPeople = new List<Person>();
        // myPeople.Add(Person1);
        myPeople.Add(myPolice);
        myPeople.Add(myDoctor);
        myPeople.Add(mySergeon);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }
    }
}
