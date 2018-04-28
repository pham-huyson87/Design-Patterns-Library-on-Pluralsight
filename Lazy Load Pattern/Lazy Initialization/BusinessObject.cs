using System;

namespace Lazy_Load_Pattern.Lazy_Initialization
{
    class BusinessObject
    {
        // Without Lazy<T>

        private object _property;
        public object Property
        {
            get
            {
                if (_property == null) {
                    _property = new object();
                }

                return _property;
            }
        }


        // With Lazy<T>

        private Lazy<object> _propertyV2;
        public object PropertyV2
        {
            get
            {
                return _propertyV2.Value;
            }
        }

        public BusinessObject()
        {
            _propertyV2 = new Lazy<object>(() => new object());  // Thread-safe by default
        }
    }
}
