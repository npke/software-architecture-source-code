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
    public partial class Input1SoThucForm : Form
    {
        public Input1SoThucForm()
        {
            InitializeComponent();
        }

        public double val = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            val = int.Parse(textBox1.Text);
            this.Close();
        }
    }
}
