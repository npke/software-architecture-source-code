using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication2
{
    public class EResource
    {
        public int ID;
        protected AttributeList Attributes = new AttributeList();
        private static Dictionary<string, EResource> SampleEResources = new Dictionary<string, EResource>();
        private string ClassType;

        public static void Initialize()
        {
            SampleEResources = new Dictionary<string, EResource>();
            EResource temp;
            temp = new EResource();
            temp.ClassType = "Ebook";
            temp.Attributes.AddAttribute(new Attribute("Title", "", "String"));
            temp.Attributes.AddAttribute(new Attribute("Authors", "", "String"));
            temp.Attributes.AddAttribute(new Attribute("Publisher", "", "String"));
            temp.Attributes.AddAttribute(new Attribute("#Pages", "", "int"));
            SampleEResources.Add(temp.ClassType, temp);

            temp = new EResource();
            temp.ClassType = "Audio";
            temp.Attributes.AddAttribute(new Attribute("Title", "", "String"));
            temp.Attributes.AddAttribute(new Attribute("Artists", "", "String"));
            temp.Attributes.AddAttribute(new Attribute("Album", "", "String"));
            temp.Attributes.AddAttribute(new Attribute("Duration", "", "int"));
            temp.Attributes.AddAttribute(new Attribute("Rating", "", "double"));
            SampleEResources.Add(temp.ClassType, temp);

        }

        private EResource()
        {

        }
        public static void Initialize (string strFromFileSpec)
        {
            // Do it yourself, pls!!!
        }

        public EResource(string ResourceTypeName)
        {

            this.Attributes.CopyFrom(SampleEResources[ResourceTypeName].Attributes);
        }

        public string this[string key]
        {
            get
            {
                return Attributes.GetAtttributeValue(key);
            }
            set
            {
                Attributes.SetAttributeValue(key, value);
            }

        }

    }
}