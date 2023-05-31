using System;
using System.Collections.Generic;
using System.IO;

namespace WriteStuff1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args[0];
            string input;
            Queue<string> inputs = new Queue<string>();

            while (true)
            {
                input = Console.ReadLine();
                if (input != string.Empty)
                    inputs.Enqueue(input);
                else
                    break;
            }

            File.WriteAllLines(path, inputs);
        }
    }
}
