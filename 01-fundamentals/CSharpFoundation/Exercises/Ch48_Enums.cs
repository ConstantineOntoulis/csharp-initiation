namespace CSharpFoundation.Exercises;

public static class Ch48_Enums
{
    public static void Run()
    {
        // Chapter 48: Enums
        // special "class" that contains a set of named integer constants
        // use enums when you have values that you know will not change,
        // to get the integer value from an item, you must explicitly convert to an int
        // name = integer

        Console.WriteLine(Planets.Terra + " is a planet"); // It's like using the ToString method
                                                           // Console.WriteLine(Planets.Terra.ToString() + " is a planet");
        
        Console.WriteLine(Planets.Terra + " is planet #" + (int)Planets.Terra); // This displays the element's position

        String name = PlanetRadius.Saturn.ToString();
        int radius = (int)PlanetRadius.Saturn;
        double volume = Volume(PlanetRadius.Terra);

        Console.WriteLine("Planet: " + name);
        Console.WriteLine("Radius: " + radius + "km");
        Console.WriteLine("Volume: " + volume + "km^3");

        Console.ReadKey();
    }
    public static double Volume(PlanetRadius radius)
    {
        double volume = (4.0/3.0) * Math.PI * Math.Pow((int)radius, 3);
        return volume;
    }
    enum Planets
    {
        Mercury = 1,
        Venus = 2,
        Terra = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }
    public enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Terra = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}