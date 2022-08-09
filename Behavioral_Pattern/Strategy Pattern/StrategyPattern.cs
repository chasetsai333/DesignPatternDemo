using Behavioral_Pattern.Strategy_Pattern.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Strategy_Pattern
{
    class StrategyPattern
    {
        /// <summary>
        /// 策略模式 (Strategy Pattern)：將不同的演算法，定義成一個家族，這些演算法實現同樣的接口，且寫成個別的類別，所以彼此之間能夠互相替換。優點是以後要增加新的演算法，只須額外新增一個類別，不須動到原本的類別。
        /// </summary>
        public void Go()
        {
            CashContext cashContext;

            cashContext = new CashContext(new ConcreteStrategy_A());
            cashContext.ExecuteStrategy(100);

            cashContext = new CashContext(new ConcreteStrategy_B());
            cashContext.ExecuteStrategy(150);

            cashContext = new CashContext(new ConcreteStrategy_C());
            cashContext.ExecuteStrategy(200);
        }
    }
}
