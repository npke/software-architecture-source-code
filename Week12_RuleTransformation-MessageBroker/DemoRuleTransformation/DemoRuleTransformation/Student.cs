using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoRuleTransformation
{
    public class Student : ObjectWithFlexibleAttributes
    {
        protected override void PopulateAttributes()
        {
            base.PopulateAttributes();
            Attributes["ClassName"] = "Student";
            Attributes["TestXemNao"] = "";
            Attributes.Add("Fullname", "");
            Attributes.Add("StudentID", "");
            Attributes.Add("Year of Birth", "-1");
        }

    }
}