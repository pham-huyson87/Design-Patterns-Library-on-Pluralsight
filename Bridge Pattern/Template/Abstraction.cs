namespace Bridge_Pattern.Template
{
    public abstract class Abstraction
    {
        protected IImplementor _implementor;

        public Abstraction(IImplementor implementor)
        {
            this._implementor = implementor;
        }

        public virtual void Operation() {

        }
    }
}
