using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoRuleTransformation
{
    public class Transformer
    {
        public Transformer()
        {
            LoadAllMappers();
        }

        List<Rule> rules = new List<Rule>();
        Dictionary<string, MappingHelper> mappers = new Dictionary<string, MappingHelper>();
        public Transformer (string strRulePathname)
        {
            LoadAllMappers();
            LoadAllRulesFromFile(strRulePathname);
        }

        private void LoadAllMappers()
        {
            mappers = new Dictionary<string, MappingHelper>();
            mappers.Add("DirectCopy", new MappingHelper());
            mappers.Add("String2Integer", new String2Integer());
            mappers.Add("Integer2String", new Integer2String());
        }

        private void LoadAllRulesFromFile(string strRulePathname)
        {

        }

        public bool MappingObject(ObjectWithFlexibleAttributes input,
            ObjectWithFlexibleAttributes output)
        {
            object sourceAttributeValue, targetAttributeValue;
            
            for (int i=0; i<rules.Count; i++)
            {

                if ((string)(input["ClassName"]) != rules[i].strInputClassName)
                    continue;
                if ((string)(output["ClassName"]) != rules[i].strOutputClassName)
                    continue;

                sourceAttributeValue = input[rules[i].strInputAttributeName];

                if (!mappers[rules[i].strMappingHelperName].Convert(
                    sourceAttributeValue,
                    out targetAttributeValue))
                {
                    return false;
                }
                else
                {
                    output[rules[i].strOutputAttributeName] = targetAttributeValue;
                }
                
            }
            return true;
        }


    }
}