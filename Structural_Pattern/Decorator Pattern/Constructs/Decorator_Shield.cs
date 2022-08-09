using Structural_Pattern.Decorator_Pattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Decorator_Pattern.Constructs
{
    class Decorator_Shield: DecoratorEquip
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Equipped Shield! def+10S");
        }
    }
}
