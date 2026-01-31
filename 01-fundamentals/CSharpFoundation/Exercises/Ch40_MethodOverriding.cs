namespace CSharpFoundation.Exercises;

public static class Ch40_MethodOverriding
{
    public static void Run()
    {
        // Chapter 40: MethodOverriding
        // provides a new version of a method inherited from a parent class
        // inherited method must be: abstract, virtual, or already overriden
        // used with ToString(), polymorphism

        Dog dog = new Dog();
        Cat cat = new Cat();

        dog.Speak();
        cat.Speak();

        Console.ReadKey();
    }
}
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal goes *brrr*");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog goes *woof*");
    }
}
class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The cat goes *meow*");
    }
}