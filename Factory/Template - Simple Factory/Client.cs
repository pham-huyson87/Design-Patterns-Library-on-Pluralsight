using Factory.Common;

namespace Factory.Template___Simple_Factory
{
    class Client
    {
        public Client()
        {
            Factory factory = new Factory();

            IProduct product = factory.CreateInstance("Product");

            product.OperationA();
            product.OperationB();
        }
    }
}
