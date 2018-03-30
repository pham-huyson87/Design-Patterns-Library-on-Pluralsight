namespace Adapter_Pattern.Template
{
    public class ConcreateAdapter1 : IAdapter
    {
        public void DoOperation()
        {
            Adaptee adaptee = new Adaptee();

            adaptee.DoOperation();
        }
    }
}
