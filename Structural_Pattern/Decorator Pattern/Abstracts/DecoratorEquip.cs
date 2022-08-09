using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Decorator_Pattern.Abstracts
{
    abstract class DecoratorEquip : Component
    {
        protected Component component;

        public void SetPlayer(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}
