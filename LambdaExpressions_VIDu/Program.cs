using System;
public delegate int MyDelegate(int n);
class LambdaExpression
{
    static void Main()
    {
        MyDelegate Obj1 = new MyDelegate(delegate (int n)
        {
            return n + 10;
        });
        Console.WriteLine("The value using an anonymous method is: {0}", Obj1(5));
        MyDelegate Obj2 = (int n) => n * 10;
        Console.WriteLine("The value using a lambda expression is: {0}", Obj2(5));
        Console.ReadLine();
    }
}