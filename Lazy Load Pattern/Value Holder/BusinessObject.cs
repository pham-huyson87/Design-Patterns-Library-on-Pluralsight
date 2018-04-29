using System.Collections.Generic;

namespace Lazy_Load_Pattern.Value_Holder
{
    class BusinessObject
    {
        private ValueHolder<List<BusinessObjectItem>> _items;


        public BusinessObject(int id)
        {
            Id = id;
        }


        public int Id { get; set; }

        public List<BusinessObjectItem> Items
        {
            get { return _items.Value; }
        }


        internal void SetItems(ValueHolder<List<BusinessObjectItem>> valueHolder)
        {
            _items = valueHolder;
        }
    }
}
