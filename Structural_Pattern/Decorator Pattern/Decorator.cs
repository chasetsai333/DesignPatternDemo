using Structural_Pattern.Decorator_Pattern.Constructs;

namespace Structural_Pattern.Decorator_Pattern
{
    class Decorator
    {
        /// <summary>
        /// 裝飾模式 (Decorator Pattern)：在某一物件動態加上功能。一層一層的將功能套上去，每一層執行的是不同的物件。
        /// </summary>
        public void Go()
        {
            var player = new Player();

            var decorator_A = new Decorator_Sword();
            decorator_A.SetPlayer(player);

            var decorator_B = new Decorator_Shield();
            decorator_B.SetPlayer(decorator_A);

            var decorator_C = new Decorator_Shoes();
            decorator_C.SetPlayer(decorator_B);

            decorator_C.Operation();
        }
    }
}
