using Behavioral_Pattern.Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Strategy_Pattern.Concretes
{
    class ConcreteStrategy_C : IStrategy
    {
        public void Execute(int money)
        {
            double result = money >= 200 ? money * 0.6 : money;
            Console.WriteLine($"原價：{money}，滿200打六折：{result}");
        }
    }
}
