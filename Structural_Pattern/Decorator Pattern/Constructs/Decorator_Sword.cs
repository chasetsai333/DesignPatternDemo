using System;
using System.Collections.Generic;
using System.Text;
using Structural_Pattern.Decorator_Pattern.Abstracts;

namespace Structural_Pattern.Decorator_Pattern.Constructs
{
    class Decorator_Sword:DecoratorEquip
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Equipped Sword! act+10");
        }
    }
}
