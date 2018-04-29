namespace Lazy_Load_Pattern.Value_Holder
{
    class Client
    {
        public Client()
        {
            BusinessObjectFactory businessObjectFactory = new BusinessObjectFactory();
            BusinessObject businessObject = businessObjectFactory.CreateFromId(123);

            var items = businessObject.Items;
        }
    }
}
