using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Adapter_Pattern
{
    class Adapter
    {
        /// <summary>
        /// 適配器模式 (Adapter Pattern)：某個已存在的類，介面不是用戶所期待的。適配器，則是當做中間的轉接口，以提供用戶期待的介面。
        /// </summary>
        public void Go()
        {
            Console.WriteLine("Object Adapter Pattern (對象適配器模式)：將已存在的類的實例，包裹在適配器類別中。");
            Console.WriteLine("Class Adapter Pattern (類適配器模式)：使用多重繼承。");
        }
    }
}
