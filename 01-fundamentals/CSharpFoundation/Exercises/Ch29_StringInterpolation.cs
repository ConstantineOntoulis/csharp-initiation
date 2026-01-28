namespace CSharpFoundation.Exercises;

public static class Ch29_StringInterpolation
{
    public static void Run()
    {
        // Chapter 29: StringInterpolation
        // allows us to insert variables into a string literal
        // precede a string literal with $.
        // {} are placeholders

        String firstName = "Constantine";
        String lastName = "Ontoulis";
        int age = 25;
        /*
        Console.WriteLine("Hello, " + firstName + " " + lastName + ".");
        Console.WriteLine("You are " + age + " years old.");
        */

        Console.WriteLine($"Hello {firstName} {lastName}.");
        Console.WriteLine($"You are {age,10} years old."); //the 10 adds 10 spaces before the "age". If I were to write -10, the spaces would be after the "age"

        Console.ReadKey();
    }
}
