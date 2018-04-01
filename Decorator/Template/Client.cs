namespace Decorator.Template
{
    class Client
    {
        public Client()
        {
            Component component = new ConcreateComponent();
            component = new ConcreateDecoratorA(component);
            component = new ConcreateDecoratorB(component);

            component.Operation();
        }
    }
}
