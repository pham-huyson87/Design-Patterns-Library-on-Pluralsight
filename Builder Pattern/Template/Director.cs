using System;

namespace Builder_Pattern.Template
{
    public class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public Product BuildProduct() {

            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();

            return builder.RetrieveProduct();
        }
    }
}
