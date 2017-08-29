using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Composite : Component
    {
        ArrayList children = new ArrayList();

        public Composite(string name): base(name)
        {

        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override Component GetChild(int index)
        {
            return children[index] as Component;
        }

        public override void Operation()
        {
            Console.WriteLine("Composite component named {0}. Children:", name);
            foreach (var item in children)
            {
                (item as Component).Operation();
            }
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }
    }
}
