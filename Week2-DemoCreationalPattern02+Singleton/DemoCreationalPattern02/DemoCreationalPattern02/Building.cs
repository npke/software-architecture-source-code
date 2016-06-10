using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCreationalPattern02
{
    public abstract class Building
    {
        protected Dictionary<string, Unit> prototypes = new Dictionary<string, Unit>();

        public virtual void PopulateAllUnitsFromFile(string strFilename)
        {

        }

        public virtual void PopulateAllUnitsFromPluginsInFolder(string strFolder)
        {
            string[] strPluginFilenames = LoadAllFilenamesInFolder(strFolder,"*.unit");
            Unit unit;
            foreach (string strPluginFilename in strPluginFilenames)
            {
                unit = CreateUnitFromPlugin(strPluginFilename);
                if (unit!=null)
                {
                    prototypes.Add(unit.Name, unit);
                }
            }
        }

        private Unit CreateUnitFromPlugin(string strPluginFilename)
        {
            throw new NotImplementedException(); // to be continued...
        }

        private string[] LoadAllFilenamesInFolder(string strFolder, string strPattern)
        {
            return System.IO.Directory.GetFiles(strFolder, strPattern);
        }

        public virtual void PopulateAllUnits()
        {
            prototypes = new Dictionary<string, Unit>();
        }

        public Unit RecruitUnit(string name)
        {
            if (IsInPrototypes(name))
                return prototypes[name].Recruit();
            return null;
        }

        private bool IsInPrototypes(string name)
        {
            return prototypes.ContainsKey(name);
            //return prototypes[name] != null;??????
        }

        public virtual Unit RecruitUnit(int idx)
        {
            return null;
        }
    }
}