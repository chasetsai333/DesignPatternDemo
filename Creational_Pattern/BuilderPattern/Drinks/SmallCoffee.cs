using Creational_Pattern.BuilderPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.BuilderPattern.Drinks
{
    class SmallCoffee : IBuilder
    {
        public void Cover()
        {
            Console.WriteLine("Cover Up Small Cap");
        }

        public void Cup()
        {
            Console.WriteLine("Take Small Cup");
        }

        public void Fill()
        {
            Console.WriteLine("Grinding Coffee Beans -> Make Coffee");
        }

        public void Straw()
        {
            Console.WriteLine("No Straw");
        }
    }
}
