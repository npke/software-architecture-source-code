using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoRuleTransformation
{
    public class String2Integer : MappingHelper
    {
        public override bool Convert(object sourceAttributeValue, out object targetAttributeValue)
        {
            int result;
            if (int.TryParse((string)sourceAttributeValue, out result))
            {
                targetAttributeValue = result;
                return true;
            }
            targetAttributeValue = result;
            return false;
        }
    }
}