using System.Reflection;

namespace CSharpFoundation.Exercises;

public static class Ch37_AbstractClasses
{
    public static void Run()
    {
        // Chapter 37: AbstractClasses
        // Modifier that indicates missing components or incomplete implementation

        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat bat = new Boat();
        //Vehicle vehicle = new Vehicle();

        Console.ReadKey();
    }
    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
}
