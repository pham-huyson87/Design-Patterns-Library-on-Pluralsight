namespace Lazy_Load_Pattern.Virtual_Proxy
{
    class BusinessObjectFactory
    {
        public object CreateFromId(int id)
        {
            return new BusinessObjectProxy() { Id = id };
        }
    }
}
