using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFunctionIntegration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, MyFunction> func = new Dictionary<string, MyFunction>();

        private void Form1_Load(object sender, EventArgs e)
        {
            func.Add("Nhap 1 so thuc", new Nhap1SoThuc());
            func.Add("Xuat 1 so thuc", new Xuat1SoThuc());

            PopulateFunctionsToCombobox();
        }

        private void PopulateFunctionsToCombobox()
        {
            foreach (string key in func.Keys)
            {
                comboBox1.Items.Add(key);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                return;

            listBox1.Items.Add(comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyStruct inputparam = new MyStruct();
            MyStruct outputparam = new MyStruct();
            for (int i=0; i<listBox1.Items.Count; i++)
            {
                outputparam = func[listBox1.Items[i].ToString()].Execute(inputparam);
                //////////////
                inputparam = outputparam;
            }
        }
    }
}
