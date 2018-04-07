using Factory.Common;
using System.Reflection;

namespace Factory.Template___Abstract_Factory
{
    class Client
    {
        private const string PRODUCT_FACTORY_NAME = "ProductAFactory";

        public Client()
        {
            IProductFactory productFactory = LoadFactory();
            IProduct product = null;

            product = productFactory.CreateProductX();
            product.OperationA();
            product.OperationB();

            product = productFactory.CreateProductY();
            product.OperationA();
            product.OperationB();

            product = productFactory.CreateProductZ();
            product.OperationA();
            product.OperationB();
        }

        private IProductFactory LoadFactory()
        {
            return Assembly
                        .GetExecutingAssembly()
                        .CreateInstance(PRODUCT_FACTORY_NAME) as IProductFactory;
        }
    }
}
