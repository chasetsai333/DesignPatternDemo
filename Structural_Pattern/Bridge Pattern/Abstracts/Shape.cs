using Structural_Pattern.Bridge_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Bridge_Pattern.Abstracts
{
    abstract class Shape
    {
        protected readonly IDrawImplementor _drawImplementor;

        protected Shape(IDrawImplementor drawImplementor)
        {
            _drawImplementor = drawImplementor;
        }

        public abstract void Draw();
    }
}
