using System.Collections.Generic;

namespace Composite.Template
{
    class Client
    {
        public Client()
        {
            List<IComponent> componentList = new List<IComponent>();

            var leaf1 = new Leaf { Name = "leaf1" };
            var leaf2 = new Leaf { Name = "leaf2" };
            var leaf3 = new Leaf { Name = "leaf3" };
            var leaf4 = new Leaf { Name = "leaf4" };
            var leaf5 = new Leaf { Name = "leaf5" };
            var leaf6 = new Leaf { Name = "leaf6" };
            var leaf7 = new Leaf { Name = "leaf7" };
            var leaf8 = new Leaf { Name = "leaf8" };
            var leaf9 = new Leaf { Name = "leaf9" };
            var subGroup = new Composite { LeafList = { leaf7, leaf8, leaf9 } };
            var group = new Composite { LeafList = { leaf4, leaf5, leaf6, subGroup } };
            var root = new Composite { LeafList = { leaf1, leaf2, leaf3, group } };

            root.Operation();
        }
    }
}
