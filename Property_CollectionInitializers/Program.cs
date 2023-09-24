using System.Collections.Generic;
public class Person
{
    string _Name;
    List _Intersets = new List();
    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }
    public List Interests
    {
        get { return _Intersets; }
    }
}

