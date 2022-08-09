using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Composite_Pattern.Abstracts
{
    abstract class MenuComponent
    {
        protected readonly string name;

        protected MenuComponent(string name)
        {
            this.name = name;
        }

        public abstract void Print(int dept);
    }
}
