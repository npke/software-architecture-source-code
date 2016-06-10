using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDistributedObject
{
    public class CCinema : ClientObject
    {
        public override string GetClassName()
        {
            return "Cinema";
        }

        public string TenRap
        {
            get {
                return (string)ClientObjectManager.GetAttributeValue(Handle, "Tên");
            }
            set {
                ClientObjectManager.SetAttributeValue(Handle, "Tên", value);
            }
        }
    }
}