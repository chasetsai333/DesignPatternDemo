using Creational_Pattern.AbstractFactoryPattern.Abstract;
using Creational_Pattern.AbstractFactoryPattern.Interface;
using Creational_Pattern.AbstractFactoryPattern.Toys.A;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.AbstractFactoryPattern.Factories
{
    class Factory_A : IFactory
    {
        public ToyCar CreateToyCar()
        {
            return new ToyCar_A();
        }

        public ToyDog CreateToyDog()
        {
            return new ToyDog_A();
        }
    }
}
