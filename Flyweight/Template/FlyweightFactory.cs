using System.Collections.Generic;
using System.Linq;

namespace Flyweight.Template
{
    class FlyweightFactory
    {
        private Dictionary<string, IComponent> components;

        public FlyweightFactory()
        {
            components = new Dictionary<string, IComponent>();
        }

        public IComponent ObtainComponent(string name) {

            switch (name)
            {
                case "ConcreateComponentA":

                    if (!components.Keys.Contains(name)) {
                        components.Add(name, new ConcreateComponentA());
                    }
                    return components[name];

                case "ConcreateComponentB":

                    if (!components.Keys.Contains(name))
                    {
                        components.Add(name, new ConcreateComponentB());
                    }
                    return components[name];

                default:
                    return null;
            }
        }
    }
}
