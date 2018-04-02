namespace Facade.Template
{
    public class ServiceB
    {
        public void Operation()
        {
            ServiceC serviceC = new ServiceC();

            serviceC.SubOperation();
        }
    }
}
