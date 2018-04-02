namespace Facade.Template
{
    public class Facade
    {
        public void Operation()
        {
            ServiceA serviceA = new ServiceA();
            ServiceB serviceB = new ServiceB();

            serviceA.Operation();
            serviceB.Operation();
        }
    }
}
