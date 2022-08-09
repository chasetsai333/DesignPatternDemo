using Behavioral_Pattern.Command_Pattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Command_Pattern.Commands
{
    class GoAheadCommand : Command
    {
        public GoAheadCommand(ReceiverRobot robot)
            : base(robot) { }

        public override void Execute()
        {
            _robot.GoAhead();
        }
    }
}
