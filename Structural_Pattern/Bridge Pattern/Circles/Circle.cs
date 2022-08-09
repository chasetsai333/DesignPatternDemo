using Structural_Pattern.Bridge_Pattern.Abstracts;
using Structural_Pattern.Bridge_Pattern.Interfaces;

namespace Structural_Pattern.Bridge_Pattern.Circles
{
    class Circle : Shape
    {
        public Circle(IDrawImplementor _drawImplementor)
            : base(_drawImplementor)
        { }

        public override void Draw()
        {
            _drawImplementor.DrawCircle();
        }
    }
}
