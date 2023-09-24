using System;
using System.Collections;
public class Employee : IComparable
{
    private int empID;
    private int yearsOfSvc = 1;
    public Employee(int empID)
    {
        this.empID = empID;
    }
    public Employee(int empID, int yearsOdSvc)
    {
        this.empID = empID;
        this.yearsOfSvc = yearsOdSvc;
    }
    public override string ToString()
    {
        return "ID: " + empID.ToString() + ". Years of Svc: " + yearsOfSvc.ToString();
    }
    public static EmployeeComparer GetComparer()
    {
        return new Employee.EmployeeComparer();
    }
    public int CompareTo(Object rhs)
    {
        Employee r = (Employee)rhs;
        return this.empID.CompareTo(r.empID);
    }
    public int CompareTo(Employee rhs, Employee.EmployeeComparer.ComparisionType which)
    {
        switch (which)
        {
            case Employee.EmployeeComparer.ComparisionType.EmpID:
                return this.empID.CompareTo(rhs.empID);
            case Employee.EmployeeComparer.ComparisionType.Yrs:
                return this.yearsOfSvc.CompareTo(rhs.yearsOfSvc);
        }
        return 0;
    }
    public class EmployeeComparer : IComparer
    {
        private Employee.EmployeeComparer.ComparisionType whichComparision;
        public enum ComparisionType
        {
            EmpID, Yrs
        };
        public int Compare(object lhs, object rhs)
        {
            Employee l = (Employee)lhs;
            Employee r = (Employee)rhs;
            return l.CompareTo(r, WhichComparision);
        }
        public Employee.EmployeeComparer.ComparisionType WhichComparision
        {
            get
            {
                return whichComparision;
            }
            set
            {
                whichComparision = value;
            }
        }
    }
}
public class Teser
{
    static void Main()
    {
        ArrayList empArray = new ArrayList();
        Random r = new Random();
        for (int i = 0; i < 5; i++)
        {
            empArray.Add(new Employee(r.Next(10) + 100, r.Next(200)));
        }
        for (int i = 0; i < empArray.Count; i++)
        {
            Console.Write("\n{0} ", empArray[i].ToString());
        }
        Console.WriteLine("\n");
        Employee.EmployeeComparer c = Employee.GetComparer();
        c.WhichComparision = Employee.EmployeeComparer.ComparisionType.EmpID;
        empArray.Sort(c);
        for (int i = 0; i < empArray.Count; i++)
        {
            Console.Write("\n{0} ", empArray[i].ToString());
        }
        Console.WriteLine("\n");
        c.WhichComparision = Employee.EmployeeComparer.ComparisionType.Yrs;
        empArray.Sort(c);
        for (int i = 0; i < empArray.Count; i++)
        {
            Console.Write("\n{0} ", empArray[i].ToString());
        }
        Console.WriteLine("\n");
    }
}