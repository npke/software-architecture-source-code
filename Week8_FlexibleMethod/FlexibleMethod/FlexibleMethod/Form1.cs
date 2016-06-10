using IPluginNamespace;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace FlexibleMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, MyObject> objects = new Dictionary<string, MyObject>();

        private void buttonCreateObject_Click(object sender, EventArgs e)
        {
            MyObject temp = new MyObject();
            string varName = textBoxVariableName.Text;
            objects[varName] = temp;
/*            if (objects.ContainsKey(varName))
                objects[varName] = temp;
            else 
                objects.Add(varName, temp);*/
            comboBoxVariableList.Items.Add(varName);
        }

        private void buttonViewMethods_Click(object sender, EventArgs e)
        {
            if (comboBoxVariableList.SelectedIndex == -1)
                return;
            string varName = comboBoxVariableList.Text;
            string[] MethodNames = objects[varName].GetAllMethods();

            comboBoxMethodList.Items.Clear();
            for (int i = 0; i < MethodNames.Length; i++)
                comboBoxMethodList.Items.Add(MethodNames[i]);
        }

        Dictionary<string, IPlugin> internalMethods = new Dictionary<string, IPlugin>();

        private void Form1_Load(object sender, EventArgs e)
        {
            IPlugin plugin;
            plugin = new Add2Integers();
            internalMethods.Add(plugin.Name(), plugin);
            plugin = new Multiply2Floats();
            internalMethods.Add(plugin.Name(), plugin);

            foreach (string key in internalMethods.Keys)
                comboBoxInternalMethodList.Items.Add(key);

        }

        private void buttonAddInternalMethod_Click(object sender, EventArgs e)
        {
            if (comboBoxInternalMethodList.SelectedIndex == -1)
                return;

            if (comboBoxVariableList.SelectedIndex == -1)
                return;

            MyObject obj = objects[comboBoxVariableList.Text];
            IPlugin method = internalMethods[comboBoxInternalMethodList.Text];
            obj.AddMethod(method);


        }

        private void buttonExecuteMethod_Click(object sender, EventArgs e)
        {
            if (comboBoxVariableList.SelectedIndex == -1)
                return;
            if (comboBoxMethodList.SelectedIndex == -1)
                return;
            string varName = comboBoxVariableList.Text;
            string methodName = comboBoxMethodList.Text;
            object result = objects[varName].Execute(methodName, 13, 4);
            MessageBox.Show(result.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxVariableList.SelectedIndex == -1)
                return;
            string varName = comboBoxVariableList.Text;
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            IPlugin plugin = LoadPlugin(dlg.FileName);
            objects[varName].AddMethod(plugin);
        }

        private IPlugin LoadPlugin(string fileName)
        {
            IPlugin result = null;
            try
            {
                Assembly asm = Assembly.LoadFile(fileName);
                CreatePluginFromAssembly(asm);
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }

        private IPlugin CreateFromType(Type t)
        {
            try
            {
                IPlugin result = (IPlugin)Activator.CreateInstance(t);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void buttonGenCode_Click(object sender, EventArgs e)
        {
            if (comboBoxVariableList.SelectedIndex == -1)
                return;

            string varName = comboBoxVariableList.Text;
            IPlugin method = GenPluginFromScript(textBoxFunctionName.Text, textBoxScript.Text);
            if (method == null)
                return;
            objects[varName].AddMethod(method);
        }

        private IPlugin GenPluginFromScript(string name, string text)
        {
            string strCSharpSourceCode = GenCSharpSourceCode(name, text);
            Assembly asm = CompileCode(strCSharpSourceCode);
            return CreatePluginFromAssembly(asm);
        }

        private IPlugin CreatePluginFromAssembly(Assembly asm)
        {
            foreach (Type t in asm.GetTypes())
            {
                IPlugin result = CreateFromType(t);
                if (result != null)
                    return result;
            }
            return null;
        }

        private Assembly CompileCode(string strCSharpSourceCode)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();
            // Reference to System.Drawing library
            parameters.ReferencedAssemblies.Add("IPlugin.dll");
            // True - memory generation, false - external file generation
            parameters.GenerateInMemory = true;            
            // True - exe file generation, false - dll file generation
            parameters.GenerateExecutable = false;
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, strCSharpSourceCode);
            if (results.Errors.HasErrors)
            {
                StringBuilder sb = new StringBuilder();

                foreach (CompilerError error in results.Errors)
                {
                    sb.AppendLine(String.Format("Error ({0}): {1}", error.ErrorNumber, error.ErrorText));
                }
                MessageBox.Show(sb.ToString());
                return null;
            }
            return results.CompiledAssembly;
        }


        int Counter = 0;
        private string GenCSharpSourceCode(string name, string text)
        {
            string strTemplate = "using IPluginNamespace; namespace DynamicPlugin { public class ClassName###1: IPlugin { public string Name() { return \"###2\"; } public object Execute(object param1, object param2) {     ###3 } } } ";
            string part1 = Counter.ToString("0000");
            Counter++;
            string strCode = strTemplate.Replace("###1", part1);
            string part2 = name;
            strCode = strCode.Replace("###2", part2);
            string part3 = text;
            strCode = strCode.Replace("###3", part3);
            return strCode;
        }
    }
}
