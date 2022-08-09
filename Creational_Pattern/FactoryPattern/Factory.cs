using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.FactoryPattern
{
    class Factory
    {
        /// <summary>
        /// 工廠方法模式 (Factory Method Pattern)。避免了簡單工廠模式，要新增條件時，對工廠類靜態方法的修改(對修改應該是封閉的)。
        /// </summary>
        public void Go() 
        {
            IToyFactory toyCarFactory = new ToyCarFactory();
            Toy toyCar = toyCarFactory.CreateToy();
            toyCar.MakeToy();

            IToyFactory toyDogFactory = new ToyCarFactory();
            Toy toyDog = toyDogFactory.CreateToy();
            toyDog.MakeToy();
        }
    }
}
