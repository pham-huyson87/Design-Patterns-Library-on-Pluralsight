namespace Builder_Pattern.Template
{
    public class Client
    {
        public Client()
        {
            Builder builder = new ConcreateBuilder();
            Director director = new Director(builder);
            Product product;

            product = director.BuildProduct();
        }
    }
}
