using Structural_Pattern.Bridge_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Bridge_Pattern.Circles
{
    class DrawCircle_B : IDrawImplementor
    {
        public void DrawCircle()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
