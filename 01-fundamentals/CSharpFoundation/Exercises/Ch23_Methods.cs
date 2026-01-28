namespace CSharpFoundation.Exercises;

public static class Ch23_Methods
{
    public static void Run()
    {
        // Chapter 23: Methods = performs a section of code, whenever it's called "invoked".
        //                       benefit = Let's us reuse code w/o writing it multiple times
        /*
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine("Happy birthday dear YOU!");
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine();
        */
        String name = "Constantine";
        int age = 25;

        singHappyBirthday(name, age);
        singHappyBirthday(name, age);
        singHappyBirthday(name, age);

        Console.ReadKey();
    }
    static void singHappyBirthday(String name, int age)
    {
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine("Happy birthday dear " + name + "!");
        Console.WriteLine("You are now " + age + " years old!");
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine();
    }
}
