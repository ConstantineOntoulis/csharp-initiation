namespace CSharpFoundation.Exercises;

public static class Ch21_Arrays
{
    public static void Run()
    {
        // Chapter 21: Arrays = a variable that can store multiple values. Has a fixed size

        //String[] cars = { "BMW", "Mustang", Corvette" };

        //Console.WriteLine(cars[0]);

        String[] cars = new string[3]; //This creates an array with a fixed size. In this case, 3 items

        cars[0] = "Tesla";
        cars[1] = "Mustange";
        cars[2] = "Corvette";

        for (int i = 0; i < cars.Length; i++) //Displays all elements of the array
        {
            Console.WriteLine(cars[i]);
        }

        Console.ReadKey();
    }
}
