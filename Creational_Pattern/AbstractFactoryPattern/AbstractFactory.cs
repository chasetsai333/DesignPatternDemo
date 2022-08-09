using Creational_Pattern.AbstractFactoryPattern.Abstract;
using Creational_Pattern.AbstractFactoryPattern.Factories;
using Creational_Pattern.AbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.AbstractFactoryPattern
{
    class AbstractFactory
    {
        /// <summary>
        /// 抽象工廠模式 (Abstract Factory Pattern)。抽象工廠類別，可返回同類型的工廠。這些返回的工廠，有多個相同的方法，做類似的事。
        /// </summary>
        public void Go()
        {
            IFactory factory;
            ToyCar toyCar;
            ToyDog toyDog;

            factory = new Factory_A();
            toyCar = factory.CreateToyCar();
            toyDog = factory.CreateToyDog();

            toyCar.MakeToyCar();
            toyDog.MakeToyDog();

            Console.WriteLine("-----------------------");

            factory = new Factory_B();
            toyCar = factory.CreateToyCar();
            toyDog = factory.CreateToyDog();

            toyCar.MakeToyCar();
            toyDog.MakeToyDog();
        }
    }
}
