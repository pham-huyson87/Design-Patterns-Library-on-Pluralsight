using Factory.Common;

namespace Factory.Template___Factory_Method
{
    class ProductAFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}
