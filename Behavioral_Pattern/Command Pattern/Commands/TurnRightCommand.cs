using Behavioral_Pattern.Command_Pattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Command_Pattern.Commands
{
    class TurnRightCommand : Command
    {
        public TurnRightCommand(ReceiverRobot robot)
            : base(robot) { }

        public override void Execute()
        {
            _robot.TurnRight();
        }
    }
}
