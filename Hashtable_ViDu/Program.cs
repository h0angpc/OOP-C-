using System;
using System.Collections;
public class Tester
{
    static void Main()
    {
        Hashtable hashTable = new Hashtable();
        hashTable.Add("00440123", "Ngoc Thao");
        hashTable.Add("00123001", "My Tien");
        hashTable.Add("00330124", "Thanh Tung");
        Console.WriteLine("myHashtable[\"00440123\"]: {0}", hashTable["00440123"]);
    }
}