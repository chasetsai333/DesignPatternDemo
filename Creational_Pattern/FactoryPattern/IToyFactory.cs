using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.FactoryPattern
{
    abstract class Toy
    {
        public abstract void MakeToy();
    }

    class ToyCar : Toy
    {
        public override void MakeToy()
        {
            Console.WriteLine("Make ToyCar!");
        }
    }

    class ToyDog : Toy
    {
        public override void MakeToy()
        {
            Console.WriteLine("Make ToyDog!");
        }
    }

    interface IToyFactory
    {
        Toy CreateToy();
    }

    class ToyCarFactory : IToyFactory
    {
        public Toy CreateToy()
        {
            return new ToyCar();
        }
    }

    class ToyDogFactory : IToyFactory
    {
        public Toy CreateToy()
        {
            return new ToyDog();
        }
    }
}
