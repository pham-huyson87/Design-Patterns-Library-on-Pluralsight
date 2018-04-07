using Factory.Common;

namespace Factory.Template___Abstract_Factory
{
    class ProductAFactory : IProductFactory
    {
        public IProduct CreateProductX()
        {
            return new ProductAX("ProductAX");
        }

        public IProduct CreateProductY()
        {
            return new ProductAY("ProductAY");
        }

        public IProduct CreateProductZ()
        {
            return new ProductAZ("ProductAZ");
        }
    }
}
