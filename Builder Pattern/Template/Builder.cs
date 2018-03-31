namespace Builder_Pattern.Template
{
    public abstract class Builder
    {
        protected Product product;

        public Product RetrieveProduct()
        {
            return product;
        }

        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
    }
}
