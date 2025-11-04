
using System.ComponentModel.DataAnnotations;

class Planet
{
    public string _name = "";

    public double _diameter;

    public  void DisplayPlanetInformation()
    {
        Console.WriteLine($"The planet info is: {_name}, diameter {_diameter}");
    }
}