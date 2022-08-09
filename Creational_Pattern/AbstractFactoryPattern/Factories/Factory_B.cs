using Creational_Pattern.AbstractFactoryPattern.Abstract;
using Creational_Pattern.AbstractFactoryPattern.Interface;
using Creational_Pattern.AbstractFactoryPattern.Toys.B;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.AbstractFactoryPattern.Factories
{
    class Factory_B : IFactory
    {
        public ToyCar CreateToyCar()
        {
            return new ToyCar_B();
        }

        public ToyDog CreateToyDog()
        {
            return new ToyDog_B();
        }
    }
}
