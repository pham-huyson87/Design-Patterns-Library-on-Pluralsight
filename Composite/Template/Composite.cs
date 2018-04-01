using System.Collections.Generic;

namespace Composite.Template
{
    class Composite : IComponent
    {
        public List<IComponent> LeafList = new List<IComponent>();

        public string Name { get; set; }

        public void Operation()
        {
            foreach (var leaf in LeafList)
            {
                leaf.Operation();
            }
        }
    }
}
