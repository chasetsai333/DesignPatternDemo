using Structural_Pattern.Flyweight_Pattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Flyweight_Pattern
{
    class Flyweight
    {
        /// <summary>
        /// 享元模式 (Flyweight Pattern)：物件之間，若有共同的部分可以共享，則將可共用的部分獨立為共享物件，不能共享的部份外部化，使用時再將外部化的部分傳給共享物件。這樣做的優點是減少記憶體使用量。缺點是程式邏輯可能變得較複雜。
        /// </summary>
        public void Go()
        {
            ChessFlyweightFactory chessFactory = new ChessFlyweightFactory();

            ChessFlyweight b1 = chessFactory.GetChessFlyweight("黑子");
            b1.Display(1, 1);
            ChessFlyweight w1 = chessFactory.GetChessFlyweight("白子");
            w1.Display(1, 2);

            ChessFlyweight b2 = chessFactory.GetChessFlyweight("黑子");
            b2.Display(2, 2);
            ChessFlyweight w2 = chessFactory.GetChessFlyweight("白子");
            w2.Display(2, 3);

            ChessFlyweight b3 = chessFactory.GetChessFlyweight("黑子");
            b3.Display(3, 3);
            ChessFlyweight w3 = chessFactory.GetChessFlyweight("白子");
            w3.Display(3, 4);

            Console.WriteLine(chessFactory.GetChessFlyweightCount());
        }
    }
}
