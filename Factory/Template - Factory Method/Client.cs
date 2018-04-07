using Factory.Common;
using System;
using System.Reflection;

namespace Factory.Template___Factory_Method
{
    class Client
    {
        private const string PRODUCT_FACTORY_NAME = "ProductFactoryB";

        public Client()
        {
            IProductFactory productFactory = LoadFactory();
            IProduct product = productFactory.CreateProduct();

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
