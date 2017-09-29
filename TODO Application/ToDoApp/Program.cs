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

            else if (args.Contains("-a"))
            {
                try
                {
                    using (StreamWriter file = File.AppendText(@"../../ListOfThings.txt"))
                    {
                        file.WriteLine("[ ]"+args[1]);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
            }

            else if (args.Contains("-r"))
            {
                try
                {
                    var file = new List<string>(File.ReadAllLines(@"../../ListOfThings.txt"));
                    file.RemoveAt(int.Parse(args[1]) - 1);
                    File.WriteAllLines(@"../../ListOfThings.txt", file);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Unable to add: no index provided");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Unable to add: index is out of bound");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to add: index is not a number");
                }
            }
            else if (args.Contains("-c"))
            {
                try
                {
                    var lines = File.ReadAllLines(@"../../ListOfThings.txt");
                    int line = int.Parse(args[1]) - 1;
                    var temp = lines[line];
                    lines[line] = "[X] " + temp;
                    File.WriteAllLines(@"../../ListOfThings.txt", lines);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Unable to check: no index provided");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Unable to check: index is out of bound");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to check: index is not a number");
                }
            }
            else if (args.Length > 0 && (!args.Contains("-l") || !args.Contains("-r") || !args.Contains("-c") || !args.Contains("-a")))
            {
                Console.WriteLine("Unsupported argument");
                start.StartUp();
            }
            else
            {
                start.StartUp(); 
            }

            Console.ReadLine();
        }
    }
}
