using System;
using System.Collections;
public class Employee : IComparable
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
            this.empID = value;
        }
    }
    public int CompareTo(Object o)
    {
        Employee r = (Employee)o;
        return this.empID.CompareTo(r.empID);
    }
}
public class Tester
{
    static void Main()
    {
        ArrayList empArray = new ArrayList();
        Random r = new Random();
        for (int i = 0; i < 5; i++)
        {
            empArray.Add(new Employee(r.Next(10) + 100));
        }
        for (int i = 0; i < empArray.Count; i++)
        {
            Console.Write("{0} ", empArray[i].ToString());
        }
        Console.WriteLine("\n");
        empArray.Sort();
        for (int i = 0; i < empArray.Count; i++)
        {
            Console.Write("{0} ", empArray[i].ToString());
        }
        Console.WriteLine("\n");
    }
}
