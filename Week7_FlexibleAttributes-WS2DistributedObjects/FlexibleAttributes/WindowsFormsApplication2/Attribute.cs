using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication2
{
    public class Attribute
    {
        private string _Name;
        private string _Value;
        private string _Type;
        public bool IsValid = true;

        public Attribute(string name, string value, string type)
        {
            Name = name;
            Value = value;
            Type = type;
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public string Value
        {
            get
            {
                return _Value;
            }

            set
            {
                this._Value = value;
            }
        }

        public string Type
        {
            get
            {
                return _Type;
            }

            set
            {
                _Type = value;
            }
        }
    }
}