class Program
{
    static void Main()
    {
        //the planet venus
        Planet venus = new Planet();
        venus._name = "Venus";
        venus._diameter = 656.275;
        venus.DisplayPlanetInformation();

        // the planet Mercury
        Planet mercury = new Planet();
        mercury._name = "Mercury";
        mercury._diameter = 1234.434;
        mercury.DisplayPlanetInformation();
    }
}
