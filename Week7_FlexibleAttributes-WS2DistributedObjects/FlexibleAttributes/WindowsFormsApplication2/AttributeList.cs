using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication2
{
    public class AttributeList
    {
        public Dictionary<string, Attribute> _Attributes = new Dictionary<string, Attribute>();

        public bool PopulateAttributes(string[] Names, string[] Values, string[] Types)
        {
            _Attributes.Clear();
            try
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    _Attributes.Add(Names[i], new Attribute(Names[i], Values[i], Types[i]));
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
       }

        public bool AddAttribute(Attribute attr)
        {
            if (IsExist(attr.Name))
                return false;
            _Attributes.Add(attr.Name, attr);
            return true;
        }
        public bool RemoveAttribute(string name)
        {
            if (IsExist(name))
            {
                _Attributes.Remove(name);
                return true;
            }
            return false;
        }

        private bool IsExist(string name)
        {
            return _Attributes.ContainsKey(name);
        }

        public string GetAtttributeValue(string name)
        {
            if (IsExist(name))
                return _Attributes[name].Value;
            return "";
        }

        public bool SetAttributeValue(string name, string newvalue)
        {
            if (IsExist(name))
            {
                _Attributes[name].Value = newvalue;
                return true;
            }
            return false;
        }

        internal void CopyFrom(AttributeList attributes)
        {
            _Attributes.Clear();
            foreach(string key in attributes._Attributes.Keys)
            {
                _Attributes.Add(key, attributes._Attributes[key]);
            }
        }
    }
}