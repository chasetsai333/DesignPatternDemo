using Creational_Pattern.AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.AbstractFactoryPattern.Interface
{
    interface IFactory
    {
        ToyCar CreateToyCar();

        ToyDog CreateToyDog();
    }
}
