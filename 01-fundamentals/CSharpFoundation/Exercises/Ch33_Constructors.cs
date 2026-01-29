namespace CSharpFoundation.Exercises;

public static class Ch33_Constructors
{
    public static void Run()
    {
        // Chapter 33: Constructors
        // A special method in a class
        // Same name as the class name
        // Can be used to assign argument to fields when creating an object
        /*
        Person person1 = new Person("Beth", 40);
        Person person2 = new Person("Jerry", 43);

        person1.Eat();
        person1.Sleep();

        person2.Eat();
        person2.Sleep();
        */

        Car car1 = new Car("Ford", "Mustang", 2022, "red");
        Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

        car1.Drive();
        car2.Drive();

        Console.ReadKey();
    }

    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }
    /*
    class Person
    {
        public String name;
        public int age;

        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }*/


}
