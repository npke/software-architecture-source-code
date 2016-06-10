using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDistributedObject
{
    public class SFilm : ServerObjbect
    {
        public override bool SetAttributeValue(string attributeName, object newValue)
        {
            string normalizedAttributeName = NormalizeAttributeName(attributeName);
            try {
                switch (normalizedAttributeName)
                {
                    case "Name":
                        Name = (string)newValue;
                        break;
                    case "Rating":
                        Rating = (float)newValue;
                        break;
                }
                return true;
            }
            catch (Exception){}

            return false;
        }

        private string NormalizeAttributeName(string attributeName)
        {
            switch (attributeName)
            {
                case "Name":
                case "name":
                case "Tên film":
                case "Tên":
                    return "Name";
                case "Rating":
                case "rating":
                case "Đánh giá":
                case "Điểm":
                case "Bình chọn":
                    return "Rating";
            }
            return "lol";

        }

        public override object GetAttributeValue(string attributeName)
        {
            string normalizedAttributeName = NormalizeAttributeName(attributeName);
            switch (normalizedAttributeName)
            {
                case "Name":
                    return Name;
                case "Rating":
                    return Rating;
            }
            return null;
        }

        public override string GetClassName()
        {
            return "Film";
        }

        private string name;
        private float rating;

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

        public float Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }
    }
}