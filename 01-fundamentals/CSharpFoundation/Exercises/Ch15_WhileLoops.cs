namespace CSharpFoundation.Exercises;

public static class Ch15_WhileLoops
{
    public static void Run()
    {
        // Chapter 15: WhileLoops = repeats some code while some condition remains true

        Console.Write("Please enter your name: ");
        String name = Console.ReadLine(); //Or String name = "";

        while (name == "")
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
        }

        Console.WriteLine("Hello, " + name);

        Console.ReadKey();
    }
}
