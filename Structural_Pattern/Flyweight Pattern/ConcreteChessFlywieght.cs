using Structural_Pattern.Flyweight_Pattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Flyweight_Pattern
{
    class ConcreteChessFlywieght : ChessFlyweight
    {
        public ConcreteChessFlywieght(string name) 
            : base(name) { }

        public override void Display(int x, int y)
        {
            Console.WriteLine($"{name}：({x},{y})");
        }
    }
}
