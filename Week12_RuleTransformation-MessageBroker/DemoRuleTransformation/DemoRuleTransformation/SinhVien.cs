using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoRuleTransformation
{
    public class SinhVien : ObjectWithFlexibleAttributes
    {
        protected override void PopulateAttributes()
        {
            base.PopulateAttributes();
            Attributes["ClassName"] = "Sinh vien";
            Attributes.Add("Ho Ten", "");
            Attributes.Add("MSSV", "");
            Attributes.Add("Nam sinh", -1);
        }

    }
}