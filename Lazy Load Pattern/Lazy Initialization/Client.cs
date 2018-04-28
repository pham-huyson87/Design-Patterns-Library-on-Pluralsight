namespace Lazy_Load_Pattern.Lazy_Initialization
{
    class Client
    {
        public Client()
        {
            BusinessObject businessObject = new BusinessObject();

            var value = businessObject.Property;

            value = businessObject.PropertyV2;
        }
    }
}
