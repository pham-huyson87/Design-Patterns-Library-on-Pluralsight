using Factory.Common;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Factory.Template___Simple_Factory
{
    class Factory
    {
        private Dictionary<string, Type> productTypeDictionary;


        public Factory()
        {
            LoadTypesReturnable();
        }

        public IProduct CreateInstance(string productName)
        {
            Type productType = RetrieveProductType(productName);

            if (productType == null)
                return new NullProduct();

            return Activator.CreateInstance(productType) as IProduct;
        }


        private void LoadTypesReturnable()
        {
            productTypeDictionary = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in typesInThisAssembly)
            {
                productTypeDictionary.Add(type.Name, type);
            }
        }

        private Type RetrieveProductType(string productName)
        {
            foreach (var productType in productTypeDictionary)
            {
                if (productType.Key == productName) {
                    return productTypeDictionary[productName];
                }
            }

            return null;
        }
    }
}
