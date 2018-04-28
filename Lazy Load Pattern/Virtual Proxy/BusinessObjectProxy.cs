namespace Lazy_Load_Pattern.Virtual_Proxy
{
    class BusinessObjectProxy : BusinessObject
    {
        public override object Property
        {
            get
            {
                if (base.Property == null) {
                    base.Property = new object();
                }
                return base.Property;
            }

            set
            {
                base.Property = value;
            }
        }

        public override bool Equals(object obj)
        {
            var other = obj as BusinessObject;

            if (other == null)
                return false;

            return other.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
