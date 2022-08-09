using Behavioral_Pattern.Command_Pattern.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Command_Pattern
{
    class CommandPattern
    {
        /// <summary>
        /// 命令模式 (Command Pattern)：一般命令包含發出命令和執行命令。命令模式，則是將這個過程拆成三個物件，發出命令的物件(Invoker)、命令的物件(command)、執行命令的物件(receiver)由 Invoker 物件，來建造要執行的命令。如此要擴充功能時，例如增加命令重覆執行、取消命令...等，也變得較單純。
        /// </summary>
        public void Go()
        {
            var invoker = new Invoker();

            var robot = new ReceiverRobot();

            var goAheadCommand = new GoAheadCommand(robot);
            var turnLeftCommand = new TurnLeftCommand(robot);
            var turnRightCommand = new TurnRightCommand(robot);

            invoker.Add(goAheadCommand);
            invoker.Add(turnLeftCommand);
            invoker.Add(turnRightCommand);

            invoker.Run();
        }
    }
}
