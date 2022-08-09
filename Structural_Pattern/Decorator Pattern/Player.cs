using Structural_Pattern.Decorator_Pattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Decorator_Pattern
{
    class Player : Component
    {
        public override void Operation()
        {
            Console.WriteLine("玩家的裝備：");
        }
    }
}
