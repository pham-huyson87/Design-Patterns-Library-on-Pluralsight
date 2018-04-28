namespace Lazy_Load_Pattern.Virtual_Proxy
{
    class Client
    {
        public Client()
        {
            BusinessObjectFactory businessObjectFactory = new BusinessObjectFactory();

            object businessOject = businessObjectFactory.CreateFromId(123);

        }

    }
}
