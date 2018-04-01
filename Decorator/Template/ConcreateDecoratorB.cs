namespace Decorator.Template
{
    class ConcreateDecoratorB : Decorator
    {
        public ConcreateDecoratorB(Component component) : base(component) { }

        public void NewBehavior()
        {
            // Implementation
        }

        public override int Operation()
        {
            NewBehavior();
            return component.Operation();
        }
    }
}
