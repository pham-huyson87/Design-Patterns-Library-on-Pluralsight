namespace Lazy_Load_Pattern.Virtual_Proxy
{
    class BusinessObject
    {
        public int Id { get; set; }

        public virtual object Property { get; set; }


        public string Operation()
        {
            return Property.ToString();
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
