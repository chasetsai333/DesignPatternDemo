using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Command_Pattern
{
    class ReceiverRobot
    {
        public void GoAhead()
        {
            Console.WriteLine("向前走一步");
        }

        public void TurnLeft()
        {
            Console.WriteLine("向左轉");
        }

        public void TurnRight()
        {
            Console.WriteLine("向右轉");
        }
    }
}
