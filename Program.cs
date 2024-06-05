class Program
{
    static void Main(string[] args)
    {
        var solarSystem = new SolarSystem();
        solarSystem.AddPlanet(new Planet("Mercury", 2439));
        solarSystem.AddPlanet(new Planet("Venus", 6051));
        solarSystem.AddPlanet(new Planet("Earth", 6371));
        solarSystem.AddPlanet(new Planet("Mars", 3389));
        solarSystem.AddPlanet(new Planet("Jupiter", 69911));
        solarSystem.AddPlanet(new Planet("Saturn", 58232));
        solarSystem.AddPlanet(new Planet("Uranus", 25362));
        solarSystem.AddPlanet(new Planet("Neptune", 24622));
        solarSystem.AddPlanet(new Planet("Pluto", 1188));
        solarSystem.AddPlanet(new Planet("Sun", 696340));
        solarSystem.AddPlanet(new Planet("UrMom", 696969));

        solarSystem.DisplayPlanets();

        Console.ReadKey();
    }
    public class SolarSystem
    {
        private List<Planet> planets;

        public SolarSystem()
        {
            planets = new List<Planet>();
        }

        public void AddPlanet(Planet planet)
        {
            planets.Add(planet);
        }
        public void DisplayPlanets()
        {
            foreach (var planet in planets)
            {
                string type = planet.Name == "Sun" ? "Star" : "Planet";
                Console.WriteLine($"{type}: {planet.Name}. Radius: {planet.Radius} km. Volume: {planet.Volume} km^3");
            }
        }
    }
    public class Planet
    {
        public string Name { get; }
        public int Radius { get; }
        public double Volume => CalculateVolume();

        public Planet(string name, int radius)
        {
            Name = name;
            Radius = radius;
        }
        private double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}