using System;
using System.Collections;
class Program
{
    public static void Main()
    {
        Queue intQueue = new Queue();
        for (int i = 0; i < 5; i++)
        {
            intQueue.Enqueue(i * 5);
        }
        Console.Write("intQueue values: ");
        PrintValues(intQueue);
        Console.WriteLine("\nDequeue: {0}", intQueue.Dequeue());
        Console.Write("intQueue values: "); PrintValues(intQueue);
        Console.WriteLine("\nDequeue: {0}", intQueue.Dequeue());
        Console.Write("intQueue values: "); PrintValues(intQueue);
        Console.WriteLine("\nPeek: {0}", intQueue.Peek());
        Console.Write("intQueue values: "); PrintValues(intQueue);
    }
    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("{0} ", obj);
        Console.WriteLine();
    }
}
