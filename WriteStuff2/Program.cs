using System;
using System.IO;
namespace WriteStuff2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(args[0]);

            string input;

            while (true)
            {
                input = Console.ReadLine();
                if (input != string.Empty)
                    sw.WriteLine(input);
                else
                    break;
            }
            
            sw.Close();
        }
    }
}
