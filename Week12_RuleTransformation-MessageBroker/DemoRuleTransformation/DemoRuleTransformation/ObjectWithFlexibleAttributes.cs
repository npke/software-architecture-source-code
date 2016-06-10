using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoRuleTransformation
{
    public class ObjectWithFlexibleAttributes
    {
        protected Dictionary<string, object> Attributes = new Dictionary<string, object>();
        public object this[string key]
        {
            get
            {
                return Attributes[key];
            }
            set
            {
                if (!Attributes.ContainsKey(key))
                {
                    /*Console.WriteLine(
"Do you really want to add a new attribute " + key + " to the class " + Attributes["ClassName"]);
                    Console....*/
                    Attributes.Add(key, value);
                }
                else
                    Attributes[key] = value;
            }
        }

        protected virtual void PopulateAttributes()
        {
            Attributes.Add("ClassName", "ObjectWithFlexibleAttributes");
        }

        public ObjectWithFlexibleAttributes()
        {
            PopulateAttributes();
        }

    }
}