using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Decorator : Component
    {
        protected Component component = null;
        public override void Operation()
        {
            if(component != null)
            {
                component.Operation();
            }
        }
        public void SetComponent(Component component)
        {
            this.component = component;
        }
    }
}
