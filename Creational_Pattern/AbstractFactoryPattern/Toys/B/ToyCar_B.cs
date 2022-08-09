using Creational_Pattern.AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.AbstractFactoryPattern.Toys.B
{
    class ToyCar_B : ToyCar
    {
        public override void MakeToyCar()
        {
            Console.WriteLine("Make ToyCarB");
        }
    }
}
