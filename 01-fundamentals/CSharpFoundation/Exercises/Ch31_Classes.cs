namespace CSharpFoundation.Exercises;

public static class Ch31_Classes
{
    public static void Run()
    {
        // Chapter 31: Classes
        // A bundle of related code we wish to organize together. Can be used as a blueprint to create objects (oop)
        // Math.Round(3.14); // clicking on the class allows us to see all the math related methods within it

        // in order to call them, we either need some sort of object or we turn the class into static and the methods within as public static

        /*
        Math.Round(3.14);
        Math.Abs(-3.14);
        Math.Pow(2, 3);*/

        ClassChapter31.Hello();
        ClassChapter31.Waiting();
        ClassChapter31.Bye();
        
        Console.ReadKey();
    }
}
