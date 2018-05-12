using System;
using System.Collections;
using System.Collections.Generic;

namespace Lazy_Load_Pattern.Ghosts
{
    class BusinessObject : DomainObject
    {
        private string _propertyOne;
        public string PropertyOne
        {
            get
            {
                Load();
                return _propertyOne;
            }
            set
            {
                Load();
                _propertyOne = value;
            }
        }

        private object _propertyTwo;
        public object PropertyTwo
        {
            get
            {
                Load();
                return _propertyTwo;
            }
            set
            {
                Load();
                _propertyTwo = value;
            }
        }

        private Lazy<List<object>> _propertyThree;
        public IEnumerable<object> PropertyThree
        {
            get
            {
                Load();
                return _propertyThree.Value.AsReadOnly();
            }
        }


        public BusinessObject(int id) : base(id) {}


        protected override void DoLoadLine(ArrayList dataRow)
        {
            PropertyOne = (string)dataRow[0];
            PropertyTwo = dataRow[1];
            _propertyThree = new Lazy<List<object>>(
                                    () => new List<object>()
                                );
        }

        protected override ArrayList GetDataRow()
        {
            var row = new ArrayList();
            row.Add("PropertyOne_value");
            row.Add(new object());

            return row;
        }
    }
}
