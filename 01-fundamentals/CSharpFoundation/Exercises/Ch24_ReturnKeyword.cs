namespace CSharpFoundation.Exercises;

public static class Ch24_ReturnKeyword
{
    public static void Run()
    {
        // Chapter 24: ReturnKeyword
        // Returns data back to the place where a method is invoked

        double x;
        double y;
        double result;

        Console.WriteLine("Enter in number 1: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter in number 2: ");
        y = Convert.ToDouble(Console.ReadLine());

        result = Multiply(x, y);

        Console.WriteLine(result);

        Console.ReadKey();
    }
    static double Multiply(double x, double y) //we change the origina "void" word into "double" because we are returning a double
    {
        double z = x * y;
        return z; //or return x * y
    }
}
