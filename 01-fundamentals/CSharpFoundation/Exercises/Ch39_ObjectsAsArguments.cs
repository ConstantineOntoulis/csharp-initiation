namespace CSharpFoundation.Exercises;

public static class Ch39_ObjectsAsArguments
{
    public static void Run()
    {
        // Chapter 39: ObjectsAsArguments

        Car car1 = new Car("Mustang", "violet");

        Car car2 = Copy(car1);

        // ChangeColor(car1, "silver");

        Console.WriteLine(car1.color + " " + car1.model);
        Console.WriteLine(car2.color + " " + car2.model);

        Console.ReadKey();
    }
    /*
    public static void ChangeColor(Car car, String color)
    {
        car.color = color;
    }
    */

    public static Car Copy(Car car)
    {
        return new Car(car.model, car.color);
    }
}
public class Car
{
    public String model;
    public String color;

    public Car(String model, String color)
    {
        this.model = model;
        this.color = color;
    }
}
