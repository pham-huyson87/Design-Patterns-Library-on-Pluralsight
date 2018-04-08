namespace Flyweight.Template
{
    class Client
    {
        public Client()
        {
            FlyweightFactory flyweightFactory = new FlyweightFactory();

            for (int i = 0; i < 100; i++)
            {
                IComponent component = flyweightFactory.ObtainComponent("ConcreateComponentA");
                component.Operation();
            }
        }
    }
}
