namespace CSharpFoundation.Exercises;

public static class Ch17_NestedLoops
{
    public static void Run()
    {
        // Bro Code chapter 17: NestedLoops

        // Generates a Rectangle
        /*
        Console.WriteLine("How many rows?: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many columns?: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Which symbol: ");
        String symbol = Console.ReadLine();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
        */

        //Creates a Triangle

        Console.WriteLine("Which symbol:");
        string symbol = Console.ReadLine();

        Console.WriteLine("Height:");
        int height = Convert.ToInt32(Console.ReadLine());

        for (int row = 0; row < height; row++)
        {
            // leading spaces (decrease each row)
            for (int s = 0; s < height - row - 1; s++)
                Console.Write(" ");

            // symbols (1, 3, 5, ...)
            for (int c = 0; c < 2 * row + 1; c++)
                Console.Write(symbol);

            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
