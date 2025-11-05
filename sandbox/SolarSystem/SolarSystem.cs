class SolarSystem
{
    List<Planet> _solarSystem = new List<Planet>();

    public void DisplayPlanetInformation()
    {
        foreach (Planet p in _solarSystem)
        {
            p.DisplayPlanetInformation();
        }
    }
}