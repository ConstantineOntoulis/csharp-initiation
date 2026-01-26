namespace CSharpFoundation.Exercises;

public static class Ch14_LogicalOperators
{
    public static void Run()
    {
        // Chapter 14: Logical Operators = Can be used to check if more than 1 condition is true/false

        // &&
        // ||

        Console.WriteLine("What's the temperature outside: (C)");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (temp >= 10 && temp <= 25)
        {
            Console.WriteLine("It's warm outside!");
        }
        else if (temp <= -50 || temp >= 50)
        {
            Console.WriteLine("DO NOT GO OUTSIDE!!!");
        }

        Console.ReadKey();
    }
}
