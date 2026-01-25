using CSharpFoundation.Exercises;

Console.Write("BroCode Chapter Selection (1–50): ");
var input = Console.ReadLine();

if (int.TryParse(input, out var id))
{
    Topics.Run(id);
}
else
{
    Console.WriteLine("Invalid input. Please,nter a number like 2, 12, 37...");
}

Console.WriteLine("\nPress Enter to exit...");
Console.ReadLine();