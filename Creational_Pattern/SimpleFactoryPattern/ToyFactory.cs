using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.SimpleFactoryPattern
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

    class ToyFactory
    {
        public static Toy CreateToy(string toyType)
        {
            Toy toyFactory;
            switch (toyType)
            {
                case "Car":
                    toyFactory = new ToyCar();
                    break;
                case "Dog":
                    toyFactory = new ToyDog();
                    break;
                default:
                    throw new Exception("沒有這個類別");
            }
            return toyFactory;
        }
    }
}
