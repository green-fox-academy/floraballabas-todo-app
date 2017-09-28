using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDoApp
{
    class PrintUsage
    {
        public void StartUp()
        {
            Console.WriteLine("Command Line ToDo application\n" +
                                "=============================");
            Console.WriteLine();
            Console.WriteLine("Command line arguments:");
            Dictionary<string, string> commandList = new Dictionary<string, string>
            {
                { "-l", "Lists all the tasks" },
                { "-a", "Adds a new task" },
                { "-r", "Removes a task" },
                { "-c", "Completes an task" }
            };
            foreach (var command in commandList)
            {
                Console.WriteLine(command);
            }
        }
        //public void TextWriter()
        //{
        //    string[] lines = { "1 - Walk the Dog", "2 - Buy Milk", "3 - Do Homework" };
        //    System.IO.File.WriteAllLines(@"C:\Users\Flóra\greenfox\floraballabas-todo-app\TODO Application\ListOfThings.txt", lines);
        //}
        //public void GiveCommand()
        //{
            
        //    string path = @"../../ListOfThings.txt";
        //    string content = File.ReadAllText(path);
        //    Console.WriteLine(content);
        //}
    }
}
