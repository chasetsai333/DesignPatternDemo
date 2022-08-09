using Creational_Pattern.AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.AbstractFactoryPattern.Toys.A
{
    class ToyCar_A : ToyCar
    {
        public override void MakeToyCar()
        {
            Console.WriteLine("Make ToyCar_A");
        }
    }
}
