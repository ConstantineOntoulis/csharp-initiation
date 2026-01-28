namespace CSharpFoundation.Exercises;

public static class Ch27_ExceptionHandling
{
    public static void Run()
    {
        // Chapter 27: ExceptionHandling
        // errors that occur during execution

        // try = try some code that is considered "dangerous"
        // catch = catches and handles exceptions when they occur
        // finally = always executes regardless if exception is caught or not

        double x;
        double y;
        double result;
        try
        {
            Console.WriteLine("Enter number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = x / y;

            Console.WriteLine("Result: " + result);
        }
        catch(FormatException e)
        {
            Console.WriteLine("Enter ONLY numbers please!");
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine("You can't divide by zero!!");
        }
        /*
        catch(Exception e) //this catches everything but it is not good practice because it doesn't let the user know what went wrong
        {
            Console.WriteLine("Something went wrong")
        }
        */
        finally
        {
            Console.WriteLine("Thanks for visiting!");
        }
        Console.ReadKey();
    }
}
