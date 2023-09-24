using System;
using System.IO;
class Test
{
    public static void Main()
    {
        try
        {
            using (StreamReader sr = new StreamReader("TestFie.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}