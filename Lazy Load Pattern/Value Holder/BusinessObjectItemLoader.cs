using System.Collections.Generic;

namespace Lazy_Load_Pattern.Value_Holder
{
    class BusinessObjectItemLoader : IValueLoader<List<BusinessObjectItem>>
    {
        private readonly int _businessObjectId;


        public BusinessObjectItemLoader(int businessObjectId)
        {
            _businessObjectId = businessObjectId;
        }


        public List<BusinessObjectItem> Load()
        {
            return new List<BusinessObjectItem>();
        }
    }
}
