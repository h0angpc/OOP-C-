using System;
delegate void MethodDelegate();
class Person
{
    public void Hello(MethodDelegate mDelegate)
    {
        Console.WriteLine("Hello Delegate");
        if (mDelegate != null)
            mDelegate();
    }
}
class Program
{
    private static void priMethod()
    {
        Console.WriteLine("Private Method");
    }
    static void Main(string[] args)
    {
        Person person = new Person();
        MethodDelegate helloDelegate = new MethodDelegate(priMethod);
        person.Hello(helloDelegate);

    }
}