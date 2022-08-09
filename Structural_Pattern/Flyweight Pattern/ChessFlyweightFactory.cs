using Structural_Pattern.Flyweight_Pattern.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Flyweight_Pattern
{
    class ChessFlyweightFactory
    {
        protected Hashtable chessFlyweight = new Hashtable();

        public ChessFlyweight GetChessFlyweight(string key)
        {
            if (!chessFlyweight.ContainsKey(key))
            {
                chessFlyweight.Add(key,new ConcreteChessFlywieght(key));
            }
            return (ChessFlyweight)chessFlyweight[key];
        }

        public int GetChessFlyweightCount()
        {
            return chessFlyweight.Count;
        }
    }
}
