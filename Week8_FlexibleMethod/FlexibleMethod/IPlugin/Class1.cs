using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPluginNamespace
{
    public interface IPlugin
    {
        string Name();
        object Execute(object param1, object param2);

    }
}
