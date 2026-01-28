using System.ComponentModel.Design;

namespace CSharpFoundation.Exercises;

public static class Ch26_ParamsKeyword
{
    public static void Run()
    {
        // Chapter 26: ParamsKeyword
        // A method parameter that takes a variable number of arguments
        // The parameter type must be a single dimensional array

        double total = CheckOut(3.99, 5.75, 15, 67, 69);

        Console.WriteLine(total);

        Console.ReadKey();
    }

    static double CheckOut(params double[] prices)
    {
        double total = 0;

        foreach (double price in prices)
        {
            total += price;
        }

        return total;
    }
    /* static double CheckOut(double a)
    {
        return a;
    }

    static double CheckOut(double a, double b) 
    {
        return a + b;
    }

    static double CheckOut(double a, double b, double c)
    {
        return a + b + c;
    }

    static double CheckOut(double a, double b, double c, double d)
    {
        return a + b + c + d;
    }

    static double CheckOut(double a, double b, double c, double d, double e)
    {
        return a + b + c + d+e;
    }

    static double CheckOut(double a, double b, double c, double d, double e, double f)
    {
        return a + b + c + d+f;
    }

    static double CheckOut(double a, double b, double c, double d, double e, double f,double g)
    {
        return a + b + c + d + f+g;
    }

    static double CheckOut(double a, double b, double c, double d, double e, double f, double g, double h)
    {
        return a + b + c + d + f+g+h;
    }

    static double CheckOut(double a, double b, double c, double d, double e, double f, double g, double h, double i)
    {
        return a + b + c + d + f+g+h+i;
    } */
    
}
