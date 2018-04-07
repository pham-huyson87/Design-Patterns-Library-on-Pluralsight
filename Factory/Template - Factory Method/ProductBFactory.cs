using Factory.Common;

namespace Factory.Template___Factory_Method
{
    class ProductBFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}
