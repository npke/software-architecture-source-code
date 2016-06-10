using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idx = comboBox1.SelectedIndex;
            if (idx == -1)
                return;

            textBox3.Text = op[idx].Execute(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopulateAllOperators();
        }

        protected List<AbstractOperator> op = new List<AbstractOperator>();
        private Type abstractOperatorType;
        private Assembly currentAssembly;

        private void PopulateAllOperators()
        {
            CreateAllOperators();
            ShowOperatorsToCombobox();
        }


        private void CreateAllOperators()
        {
            AbstractOperator temp;
            op.Clear();
            string[] strClassnames = FindAllInternalOperators();
            foreach (string strClassname in strClassnames)
            {
                temp = CreateInstance(strClassname);
                op.Add(temp);
            }
        }

        private void ShowOperatorsToCombobox()
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < op.Count; i++)
                comboBox1.Items.Add(op[i].GetName());
        }

        private AbstractOperator CreateInstance(string strClassname)
        {
            //reflection
            Type t = currentAssembly.GetType(strClassname);
            return (AbstractOperator)Activator.CreateInstance(t);
        }

        private string[] FindAllInternalOperators()
        {
            List<string> temp = new List<string>();
            
            Type[]   types = currentAssembly.GetTypes();
            foreach (Type t in types)
                if (IsOperator(t))
                {
                    temp.Add(ExtractNameFromType(t));
                }
            return temp.ToArray();
        }

        private string ExtractNameFromType(Type t)
        {
            return t.FullName;
        }

        private bool IsOperator(Type t)
        {
            return t.IsSubclassOf(abstractOperatorType);
        }

        private Assembly GetCurrentAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentAssembly = GetCurrentAssembly();
            GetTypeOfAbstractOperator();
        }

        private void GetTypeOfAbstractOperator()
        {
            abstractOperatorType = currentAssembly.GetType("WindowsFormsApplication1.AbstractOperator");

        }
    }
}
