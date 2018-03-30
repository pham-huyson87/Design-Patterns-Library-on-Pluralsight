namespace Bridge_Pattern.Template
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementor implementor) : base(implementor)
        {

        }

        public override void Operation()
        {
            base.Operation();

            _implementor.SubOperation();
        }
    }
}
