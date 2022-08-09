using Creational_Pattern.BuilderPattern.Drinks;
using Creational_Pattern.BuilderPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Pattern.BuilderPattern
{
    class Builder
    {
        /// <summary>
        /// 建造者模式(生成器模式) (Builder Pattern)。某種類的產品，有一建造過程，將這些生產步驟整理出來，所有要生產這類產品的 class，均要實現這些標準化步驟。另外，為避免實際生產時，遺漏某步驟，統一由一個指揮者 class，執行一系列的生產步驟。
        /// </summary>
        public void Go() 
        {
            IBuilder builder;
            Director director;

            builder = new SmallCoffee();
            director = new Director(builder);
            director.Create();

            Console.WriteLine("---------------------");

            builder = new LargeMilkTea();
            director = new Director(builder);
            director.Create();
        }
    }
}
