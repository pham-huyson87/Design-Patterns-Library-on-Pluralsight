namespace Adapter_Pattern.Template
{
    public class Client
    {
        public Client()
        {
            IAdapter adapter;

            adapter = new ConcreateAdapter1();
            adapter.DoOperation();

            adapter = new ConcreateAdapter2();
            adapter.DoOperation();
        }
    }
}
