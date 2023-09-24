using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

public class Test
{
    public static void Main()
    {
        Console.WriteLine("Enter Main....");
        Test t = new Test();
        t.Func1();
        Console.WriteLine("Exit Main...");
    }
    public void Func2()
    {
        Console.WriteLine("Enter Func2...");
        try
        {
            Console.WriteLine("Entering try block...");
            throw new System.Exception();
            Console.WriteLine("Exiting try block...");
        }
        catch
        {
            Console.WriteLine("Exception caught and handled.");
        }
        Console.WriteLine("Exit Func2...");
    }
    public void Func1()
    {
        Console.WriteLine("Enter Func1...");
        try
        {
            Console.WriteLine("Entering try block...");
            Func2();
            Console.WriteLine("Exiting try block...");
        }
        catch
        {
            Console.WriteLine("Exception caught and handled.");
        }
        Console.WriteLine("Exit Func1...");
    }
}
