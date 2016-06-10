using IPluginNamespace;

namespace FlexibleMethod
{
    public class Multiply2Floats: IPlugin
    {
        public string Name()
        {
            return "Multiply 2 Floats";
        }

        public object Execute(object param1, object param2)
        {
            float v1 = (float)param1;
            float v2 = (float)param2;
            return v1 * v2;
        }

    }
}