using System;
using System.CodeDom;

internal delegate void TextChanged();
class Person
{
    public event TextChanged TextChanged
    {
        add { Console.WriteLine("Event added"); }
        remove { Console.WriteLine("Event removed"); }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.TextChanged += new TextChanged(person_TextChanged);
        person.TextChanged -= new TextChanged(person_TextChanged);
    }
    private static void person_TextChanged()
    {
        Console.WriteLine("Event Called");
    }
}