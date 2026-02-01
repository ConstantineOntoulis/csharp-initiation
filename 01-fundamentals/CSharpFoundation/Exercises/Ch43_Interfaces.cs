namespace CSharpFoundation.Exercises;

public static class Ch43_Interfaces
{
    public static void Run()
    {
        // Bro Code chapter 43: Interfaces
        // Interface = defines a "contract" that all the classes inheriting from should follow
        //             An interface declares "what a class should have"
        //             An inheriting class defines "how it should do it"

        //             Benefit = security + multiple inheritance + "plug-and-play"

        Rabbit rabbit = new Rabbit();
        Hawk hawk = new Hawk();
        Fish fish = new Fish();

        rabbit.Flee();
        hawk.Hunt();
        fish.Flee();
        fish.Hunt();

        Console.ReadKey();
    }
    interface IPrey
    {
        void Flee();
    }
    interface IPredator
    {
        void Hunt();
    }
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }
    }
    class Hawk : IPredator // with interfaces a class can inherit more than one methods unlike with standard inheritance
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food!");
        }
    }
    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish!");
        }
    }
}
