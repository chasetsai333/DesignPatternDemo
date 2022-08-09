using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Command_Pattern.Abstracts
{
    abstract class Command
    {
        protected readonly ReceiverRobot _robot;

        public Command(ReceiverRobot robot)
        {
            _robot = robot;
        }

        public abstract void Execute();
    }
}
