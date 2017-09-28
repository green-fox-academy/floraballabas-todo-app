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
            if (args.Contains("-l"))
            {
                string content = File.ReadAllText(path);
                if (content != null)
                {
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine("No todos for today! :)");
                }
                
            }
            Console.ReadLine();
        }
    }
}
