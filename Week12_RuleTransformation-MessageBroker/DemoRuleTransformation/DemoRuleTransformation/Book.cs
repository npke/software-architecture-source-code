using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoRuleTransformation
{
    public class Book : ObjectWithFlexibleAttributes
    {
        protected override void PopulateAttributes()
        {
            base.PopulateAttributes();
            Attributes["ClassName"] = "Book";
            Attributes.Add("Title", "");
            Attributes.Add("Author", "");
            Attributes.Add("Publisher", "");
        }
    }
}