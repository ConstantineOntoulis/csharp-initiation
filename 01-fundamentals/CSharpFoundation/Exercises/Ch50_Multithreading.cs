using System;
using System.Threading;

namespace CSharpFoundation.Exercises;

public static class Ch50_Multithreading
{
    public static void Run()
    {
        // Chapter 50: Multithreading
        // thread = an execution path of a program
        //          We can use multiple threads to perform,
        //          different tasks of our program at the same time.
        //          Current thread running is "main" thread
        //          Using System.Threading;

        Thread mainThread = Thread.CurrentThread; // Assigns the current thread that is running to a local variable
        mainThread.Name = "Main Thread";
        // Console.WriteLine(mainThread.Name);

        // We won't use the following method since they're running on the same thread
        // and so the methods will be running the one AFTER the other and won't be running simultaneously

        // CountDown();
        // CountUp();

        // Instead, we will use the following:

        Thread thread1 = new Thread(() => CountDown("Timer #1")); // use lamda expression when methods have parameters
        Thread thread2 = new Thread(() => CountUp("Timer #2"));   // like in this case (String name)

        thread1.Start();
        thread2.Start();

        Console.WriteLine(mainThread.Name + " is complete!");

        Console.ReadKey();
    }
    public static void CountDown(String name)
    {
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine("Timer #1 : " + i + " seconds");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Timer #1 is complete!");
    }
    public static void CountUp(String name)
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Timer #2 : " + i + " seconds");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Timer #2 is complete!");
    }
}
