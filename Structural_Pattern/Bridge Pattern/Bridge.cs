using Structural_Pattern.Bridge_Pattern.Circles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Bridge_Pattern
{
    class Bridge
    {
        /// <summary>
        /// 橋接模式 (Bridge Pattern)：將一個物件的具體行為(實作)抽出來，成為一個獨立的物件。也就是原本的一個物件，變成兩個物件：「抽像物件」+「實作物件」。優點是抽像物件與實作物件可以解耦合，各自獨立變化。
        /// </summary>
        public void Go()
        {
            Circle circleA = new Circle(new DrawCircle_A());
            Circle circleB = new Circle(new DrawCircle_B());

            circleA.Draw();
            circleB.Draw();
        }
    }
}
