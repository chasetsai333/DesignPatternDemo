using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Flyweight_Pattern.Abstracts
{
    abstract class ChessFlyweight
    {
        protected string name;

        public ChessFlyweight(string name)
        {
            this.name = name;
        }

        public abstract void Display(int x , int y);
    }
}
