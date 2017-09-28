using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class PrintUsage
    {
        public void StartUp()
        {
            Console.WriteLine("Command Line ToDo application\n" +
                                "=============================" );
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
    }
}
