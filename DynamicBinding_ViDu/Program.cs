using System;
class Person
{
    public string Name { get; set; }
    public void Swim()
    {
        Console.WriteLine("Person is swimming");
    }
}
class Duck
{
    public string Weight { get; set; }
    public void Swim()
    {
        Console.WriteLine("The Duck is swimming");
    }
}
class Program
{
    //Hàm có paramater là một object dynamic
    static void InvokeSwim(dynamic obj)
    {
        obj.Swim();
    }
    static void Main(string[] args)
    {
    //Khai báo 2 object dynamic khác nhau
        dynamic person = new Person();
        dynamic duck = new Duck();
    //Truyền 2 object khác kiểu vào cùng 1 hàm
    InvokeSwim(person);
    InvokeSwim(duck);
    }
}
