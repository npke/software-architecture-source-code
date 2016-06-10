using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDistributedObject
{
    public class SCinema : ServerObjbect
    {
        public override object GetAttributeValue(string attributeName)
        {
            switch (attributeName)
            {
                case "Name":
                case "name":
                    return Name;
            }
            return null;
        }

        public override string GetClassName()
        {
            return "Cinema";
        }

        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}