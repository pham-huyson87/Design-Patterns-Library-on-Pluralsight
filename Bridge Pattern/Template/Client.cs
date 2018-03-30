namespace Bridge_Pattern.Template
{
    public class Client
    {
        public Client()
        {
            IImplementor concreateImplementor = new ConcreateImplementor();
            Abstraction abstraction = new RefinedAbstraction(concreateImplementor);

            abstraction.Operation();
        }
    }
}
