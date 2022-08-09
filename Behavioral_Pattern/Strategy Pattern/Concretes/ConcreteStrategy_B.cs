using Behavioral_Pattern.Strategy_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Strategy_Pattern.Concretes
{
    class ConcreteStrategy_B : IStrategy
    {
        public void Execute(int money)
        {
            double result = money * 0.7;
            Console.WriteLine($"原價：{money}，打七折：{result}");
        }
    }
}
