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
            func.Add("Tinh Max 2 So Thuc", new TinhMax2SoThuc());
            func.Add("Tinh Min 2 So Thuc", new TinhMin2SoThuc());
            func.Add("Tinh Tong 2 So Thuc", new TinhTong2SoThuc());
            func.Add("Giai PT Bac 1", new GiaiPTBac1());


            PopulateFunctionsToCombobox();
        }

        private void PopulateFunctionsToCombobox()
        {
            foreach (string key in func.Keys)
            {
                comboBox1.Items.Add(key);
            }
        }

        int nOutput = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                return;            
            listView1.Items.Add(comboBox1.Text);
            int n = listView1.Items.Count - 1;
            listView1.Items[n].SubItems.Add(textBox1.Text);
            int nResults = func[comboBox1.Text].GetNumberOfOutput();
            string info = "";
            for (int i = 0; i < nResults; i++)
            {
                info = info + "$"+ nOutput.ToString() + " ";
                nOutput++;
            }
            listView1.Items[n].SubItems.Add(info);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyStruct inputparam = new MyStruct();
            MyStruct outputparam = new MyStruct();
            Dictionary<string, object> GlobalVariables = new Dictionary<string, object>();
            for (int i=0; i<listView1.Items.Count; i++)
            {
                // Sao chep tu GlobalVariable vao inputparam
                CopyToInput(GlobalVariables, ref inputparam, listView1.Items[i].SubItems[1].Text);
                outputparam = func[listView1.Items[i].Text].Execute(inputparam);
                CopyFromOutput(ref GlobalVariables, outputparam, listView1.Items[i].SubItems[2].Text);
            }
        }

        private void CopyFromOutput(ref Dictionary<string, object> globalVariables, MyStruct outputparam, string text)
        {
            String[] s = text.Split(' ');
            for (int i = 0; i < s.Length; i++)
                if (s[i]!="")
                globalVariables.Add(s[i], outputparam.data["_" + i.ToString()]);
        }

        private void CopyToInput(Dictionary<string, object> globalVariables, ref MyStruct inputparam, string text)
        {
            inputparam.data.Clear();
            String[] s= text.Split(' ');
            for (int i = 0; i < s.Length; i++)
                if (s[i]!="")
                inputparam.data.Add("_" + i.ToString(), // _0, _1, _2....
                    globalVariables[s[i]]);

        }

    }
}




