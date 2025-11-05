class Program
{
    static void Main()
    {
        //the planet venus
        Planet venus = new Planet();
        venus._name = "Venus";
        venus._diameter = 656.275;

        // the planet Mercury
        Planet mercury = new Planet();
        mercury._name = "Mercury";
        mercury._diameter = 1234.434;
        
        //the planet earth
        Planet Earth = new Planet();
        Earth._name = "Earth";
        Earth._diameter = 15353.234;

        SolarSystem solarSystem = new SolarSystem();
        solarSystem._solarSystem.Add(mercury);
        solarSystem._solarSystem.Add(venus);
        solarSystem._solarSystem.Add(Earth);
        solarSystem.DisplayPlanetInformation();

    }
}
