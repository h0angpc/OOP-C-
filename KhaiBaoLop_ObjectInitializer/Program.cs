public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
public class Program
{
    static void Main(string[] args)
    {
        var person = new Person(){Name = "John", Age = 25};
        Console.WriteLine(person.Name + " " + person.Age);
    }
}