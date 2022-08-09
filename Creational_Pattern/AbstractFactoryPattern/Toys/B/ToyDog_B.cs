using Creational_Pattern.AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.AbstractFactoryPattern.Toys.B
{
    class ToyDog_B : ToyDog
    {
        public override void MakeToyDog()
        {
            Console.WriteLine("Make ToyDogB");
        }
    }
}
