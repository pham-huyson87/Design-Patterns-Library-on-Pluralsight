namespace Decorator.Template
{
    class ConcreateDecoratorA : Decorator
    {
        public int NewProperty { get; set; }

        public ConcreateDecoratorA(Component component) : base(component) { }

        public override int Operation()
        {
            return component.Operation() + NewProperty;
        }
    }
}
