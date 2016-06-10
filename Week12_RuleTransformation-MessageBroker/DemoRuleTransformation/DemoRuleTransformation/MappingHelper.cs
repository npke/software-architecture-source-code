using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoRuleTransformation
{
    public class MappingHelper
    {
        public virtual bool Convert(object sourceAttributeValue, out object targetAttributeValue)
        {
            targetAttributeValue = sourceAttributeValue;
            return true;
        }
    }
}