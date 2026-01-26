namespace CSharpFoundation.Exercises;

public static class Ch13_SwitchStatements
{
    public static void Run()
    {
        // Chapter 13: Switches = an efficient alternative to many else if statements

        Console.WriteLine("What day is it today?");
        String day = Console.ReadLine();

        day = day.ToLower();

        switch (day)
        {
            case "monday":
                Console.WriteLine("It's Monday!");
                break;
            case "tuesday":
                Console.WriteLine("It's Tuesday!");
                break;
            case "wednesday":
                Console.WriteLine("It's Wednesday");
                break;
            case "thursday":
                Console.WriteLine("It's Thursday");
                break;
            case "friday":
                Console.WriteLine("It's Friday");
                break;
            case "saturday":
                Console.WriteLine("It's Saturday");
                break;
            case "sunday":
                Console.WriteLine("It's Sunday");
                break;
            default:
                Console.WriteLine("Not a valid day. Type e.g. Monday.");
                break;
        }

        Console.ReadKey(); 
    }
}
