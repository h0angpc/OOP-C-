using System;
public class SomeClass
{
     public SomeClass(int val)
        {        
            value = val;
     }
     public override string ToString()
     {
         return value.ToString();
     }
 private int value;
 }
 public class Tester
 {
     static void Main()
 {
         int i = 5;
         Console.WriteLine("The value of i is: {0}", i.ToString());
         SomeClass s = new SomeClass(7);
         Console.WriteLine("The value of s is: {0}", s.ToString());
         Console.WriteLine("The value of 5 is: {0}", 5.ToString());
         }
     }