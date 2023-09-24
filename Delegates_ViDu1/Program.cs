
using System;
delegate void MethodDelegate();
class Person
{
    public void Hello()
    {
        Console.WriteLine("Hello Delegate");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        MethodDelegate helloDelegate = new MethodDelegate(person.Hello);
        helloDelegate();
    }
}