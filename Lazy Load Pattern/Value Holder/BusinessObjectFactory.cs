using System.Collections.Generic;

namespace Lazy_Load_Pattern.Value_Holder
{
    class BusinessObjectFactory
    {
        public BusinessObject CreateFromId(int id)
        {
            var businessObject = new BusinessObject(id);
            businessObject
                .SetItems(new ValueHolder<List<BusinessObjectItem>>(
                    new BusinessObjectItemLoader(id))
                );

            return businessObject;
        }
    }
}
