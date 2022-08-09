using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.SimpleFactoryPattern
{
    class SimpleFactory
    {
        /// <summary>
        ///簡單工廠模式(Simple Factory pattern)。使用 class 的靜態方法，依不同條件，取得不同物件，並用取得的物件，做類似的事情。缺點是要新增不同條件時，須修改到類別的靜態方法。
        /// </summary>
        public void Go()
        {
            var toyCarFactory = ToyFactory.CreateToy("Car");
            toyCarFactory.MakeToy();

            var toyDogFactory = ToyFactory.CreateToy("Dog");
            toyDogFactory.MakeToy();
        }
    }
}
