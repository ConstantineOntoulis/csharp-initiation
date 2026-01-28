namespace CSharpFoundation.Exercises;

public static class Ch22_ForeachLoop
{
    public static void Run()
    {
        // Chapter 22: ForeachLoop

        String[] cars = { "BMW", "Mustang", "Corvette" };

        //without for each
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
        //with foreach
        foreach(String car in cars)
        {
            Console.WriteLine(car);
        }

        Console.ReadKey();
    }
}
