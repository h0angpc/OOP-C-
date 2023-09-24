using System;
using System.Collections;
using System.Runtime.Versioning;

public class Program
{
    static void Main()
    {
        Stack intStack = new Stack();
        for (int i = 0; i < 8; i++)
        {
            intStack.Push(i * 5);
        }
        Console.Write("intStack values: ");
        PrintValues(intStack);
        Console.WriteLine("\nPop: {0}", intStack.Pop());
        Console.Write("intStack values: ");
        PrintValues(intStack);
        Console.WriteLine("\nPop: {0}", intStack.Pop());
        Console.Write("intStack values: ");
        PrintValues(intStack);
        Console.WriteLine("\nPop: {0}", intStack.Pop());
        Console.Write("intStack values: "); PrintValues(intStack);
        Array targetArray = Array.CreateInstance(typeof(int), 12);
        for (int i = 0; i <= 8; i++)
        {
            targetArray.SetValue(100 * i, i);
        }
        Console.WriteLine("\nTarget array: "); PrintValues(targetArray);
        intStack.CopyTo(targetArray, 6);
        Console.WriteLine("\nTarget array after copy: ");
        PrintValues(targetArray);
        Object[] myArray = intStack.ToArray();
        Console.WriteLine("\nThe new array: "); PrintValues(myArray);
    }
    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("{0} ", obj);
        Console.WriteLine();
    }
}