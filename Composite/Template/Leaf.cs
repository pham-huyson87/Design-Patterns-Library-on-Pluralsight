using System;

namespace Composite.Template
{
    class Leaf : IComponent
    {
        public string Name { get; set; }

        public void Operation()
        {
            Console.WriteLine(Name);
        }
    }
}
