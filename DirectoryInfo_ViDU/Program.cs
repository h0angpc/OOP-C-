using System;
using System.IO;
class Test
{
    public static void Main()
    {
        DirectoryInfo di = new DirectoryInfo(@"c:\MyDir");
        try
        {
            if (di.Exists)
            {
                Console.WriteLine("That path exists already.");
                return;
            }
            di.Create();
            Console.WriteLine("The directory was created successfully.");
            di.Delete();
            Console.WriteLine("The directory was deleted successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
        finally
        {

        }
    }
}