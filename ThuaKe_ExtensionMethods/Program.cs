sealed class Person
{
    public string Name { get; set; }
 }
static class Utility
{
    //Extension method thêm vào lớp Person
    static public void ExMethod(this Person person)
    {
        person.Name = "John";
    Console.WriteLine("Name: " + person.Name);
    }
}
class Program
{
    static void Main(string[] args)
    {
        //Tạo instance của lớp Person
        var person = new Person();
        //Gọi Extension Method
        person.ExMethod();
    }
}