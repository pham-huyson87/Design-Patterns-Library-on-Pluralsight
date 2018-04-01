namespace Decorator.Template
{
    public class Decorator : Component
    {
        protected Component component { get; set; }

        public Decorator(Component component)
        {
            this.component = component;
        }

        public override int Operation()
        {
            return component.Operation();
        }
    }
}
