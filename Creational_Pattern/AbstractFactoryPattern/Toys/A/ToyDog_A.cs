using Creational_Pattern.AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.AbstractFactoryPattern.Toys.A
{
    class ToyDog_A : ToyDog
    {
        public override void MakeToyDog()
        {
            Console.WriteLine("Make ToyDogA");
        }
    }
}
