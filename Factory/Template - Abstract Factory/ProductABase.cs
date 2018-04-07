using System;
using Factory.Common;

namespace Factory.Template___Abstract_Factory
{
    abstract class ProductABase : IProduct
    {
        private string name = String.Empty;

        public ProductABase(string name)
        {
            this.name = name;
        }

        public void OperationA()
        {
            // Implementaion
        }

        public void OperationB()
        {
            // Implementaion
        }
    }
}
