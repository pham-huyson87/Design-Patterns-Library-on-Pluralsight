using Factory.Common;

namespace Factory.Template___Abstract_Factory
{
    interface IProductFactory
    {
        IProduct CreateProductX();
        IProduct CreateProductY();
        IProduct CreateProductZ();
    }
}
