using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();
        using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
        {
            foreach (DirectoryInfo dir in cDirs)
            {
                sw.WriteLine(dir.Name);
            }
        }
        string line = "";
        using (StreamReader sr = new StreamReader("CDriverDirs.txt"))
        {
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}