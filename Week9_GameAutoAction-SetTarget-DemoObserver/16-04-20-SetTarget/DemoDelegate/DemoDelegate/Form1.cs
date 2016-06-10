using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDelegate
{
    public partial class Form1 : Form, IOnFinishListener
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyClass myobj = null;
        MyListener l;

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            myobj = new MyClass();
            l = new MyListener();
            myobj.setOnFinishListener(new MyListener());
            myobj.StartVeryLongOperation();
        }



        private void buttonNext_Click(object sender, EventArgs e)
        {
            myobj.Finish();
        }

        public void ShowMessage(string s)
        {
            MessageBox.Show(s);
        }
    }
}
