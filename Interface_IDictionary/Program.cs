using System;
using System.Collections;
public class Employee
{
    private int empID;
    public Employee(int empID)
    {
        this.empID = empID;
    }
    public override string ToString()
    {
        return empID.ToString();
    }
    public int EmpID
    {
        get
        {
            return empID;
        }
        set
        {
            empID = value;
        }
    }
}
class Program
{

    static void Main(string[] args)
    {
        ArrayList empArray = new ArrayList();
        ArrayList intArray = new ArrayList();
        for (int i = 0; i < 5; i++)
        {
            empArray.Add(new Employee(i + 100));
            intArray.Add(i * 5);
        }
        for (int i = 0; i < intArray.Count; i++)
        {
            Console.Write("{0} ", intArray[i].ToString());
        }
        Console.WriteLine("\n");
        for (int i = 0; i < empArray.Count; i++)
        {
            Console.Write("{0} ", empArray[i].ToString());
        }
        Console.WriteLine("\n");
        Console.WriteLine("empArray.Count: {0}", empArray.Count);
        Console.WriteLine("empArray.Capacity: {0}", empArray.Capacity);
    }
}