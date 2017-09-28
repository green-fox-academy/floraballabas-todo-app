using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new PrintUsage();
            start.StartUp();
            //string[] lines = { "1 - Walk the Dog", "2 - Buy Milk", "3 - Do Homework" };
            //System.IO.File.WriteAllLines(@"../../ListOfThings.txt", lines);
            string path = @"../../ListOfThings.txt";
            string[] content = File.ReadAllLines(path);
            if (args.Contains("-l"))
            {
                if (content != null)
                {
                    for (int i = 0; i < content.Count(); i++)
                    {
                        Console.WriteLine(@"{0}. - {1}", i + 1, content[i]);
                    }
                }
                else
                {
                    Console.WriteLine("No todos for today! :)");
                }
            }
            if (args.Contains("-a"))
            {
                using (StreamWriter file = File.AppendText(@"../../ListOfThings.txt"))
                {
                    file.WriteLine(args[1]);
                }
            }
            Console.ReadLine();
        }
    }
}
