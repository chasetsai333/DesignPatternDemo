using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Facade_Pattern
{
    class Facade
    {
        /// <summary>
        /// 外觀模式 (Facade Pattern)：將原有的大系統包裝起來，用另一個較簡易的介面開放給使用者。使用者只須了解介面的的使用方式。而不須了解大系統內，各個小系統的操作方式。
        /// </summary>
        public void Go()
        {
            Console.WriteLine();
        }
    }
}
