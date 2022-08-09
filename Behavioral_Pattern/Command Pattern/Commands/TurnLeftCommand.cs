using Behavioral_Pattern.Command_Pattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Command_Pattern.Commands
{
    class TurnLeftCommand : Command
    {
        public TurnLeftCommand(ReceiverRobot robot)
            : base(robot) { }

        public override void Execute()
        {
            _robot.TurnLeft();
        }
    }
}
