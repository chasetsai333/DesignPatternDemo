using Structural_Pattern.Composite_Pattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Composite_Pattern.Leafs
{
    class LeafMenuPhone : MenuComponent
    {
        public LeafMenuPhone(string name) 
            : base(name) { }

        public override void Print(int dept)
        {
            Console.WriteLine($"{new string('-', dept)}{name}");
        }
    }
}
