using Behavioral_Pattern.Command_Pattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Behavioral_Pattern.Command_Pattern
{
    class Invoker
    {
        private List<Command> commands = new List<Command>();

        public void Add(Command command)
        {
            Console.WriteLine($"Add {command.GetType().Name}");
            commands.Add(command);
        }

        public void Run()
        {
            if (commands.Any())
            {
                commands.ForEach(command => command.Execute());
            }
            else
            {
                Console.WriteLine("目前沒有待處理的命令");
            }
        }
    }
}
