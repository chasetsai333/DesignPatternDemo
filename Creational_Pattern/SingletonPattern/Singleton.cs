using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.SingletonPattern
{
    class Singleton
    {
        /// <summary>
        /// 單例模式 (Singleton Pattern)。讓一個類別只能有一個實例(Instance)的方法。產生單一實例的方式：懶漢方式(Lazy initialization)：第一次使用時，才產生實例。餓漢方式(Eager initialization)：class 載入時就產生實例，不管後面會不會用到。
        /// </summary>
        public void Go()
        {
            Console.WriteLine("LazyInitialization Start");
            LazyInitialization lazySingleton_1 = LazyInitialization.GetInstance();
            LazyInitialization lazySingleton_2 = LazyInitialization.GetInstance();
            Console.WriteLine($"LazyInitialization_1 Number：{lazySingleton_1.Number}");
            Console.WriteLine($"LazyInitialization_2 Number：{lazySingleton_2.Number}");
            Console.WriteLine($"LazyInitialization_1.Number = 999");
            lazySingleton_1.Number = 999;
            Console.WriteLine($"LazyInitialization_1 Number：{lazySingleton_1.Number}");
            Console.WriteLine($"LazyInitialization_2 Number：{lazySingleton_2.Number}");
            Console.WriteLine($"LazyInitialization_1 == LazyInitialization_2：{lazySingleton_1 == lazySingleton_2}");

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("EagerInitialization Start");
            EagerInitialization eagerSingleton_1 = EagerInitialization.GetInstance();
            EagerInitialization eagerSingleton_2 = EagerInitialization.GetInstance();
            Console.WriteLine($"EagerInitialization_1 Number：{eagerSingleton_1.Number}");
            Console.WriteLine($"EagerInitialization_2 Number：{eagerSingleton_2.Number}");
            Console.WriteLine($"EagerInitialization_1.Number = 999");
            eagerSingleton_1.Number = 999;
            Console.WriteLine($"EagerInitialization_1 Number：{eagerSingleton_1.Number}");
            Console.WriteLine($"EagerInitialization_2 Number：{eagerSingleton_2.Number}");
            Console.WriteLine($"EagerInitialization_1 == EagerInitialization_2：{eagerSingleton_1 == eagerSingleton_2}");
        }
    }
}
