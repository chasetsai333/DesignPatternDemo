using Creational_Pattern.BuilderPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.BuilderPattern.Drinks
{
    class LargeMilkTea : IBuilder
    {
        public void Cover()
        {
            Console.WriteLine("Cover Up Large Cap");
        }

        public void Cup()
        {
            Console.WriteLine("Take Large Cup");
        }

        public void Fill()
        {
            Console.WriteLine("Make Black Tea -> Add Milk");
        }

        public void Straw()
        {
            Console.WriteLine("Thin Straw");
        }
    }
}
