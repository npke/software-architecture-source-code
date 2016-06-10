using System;
using System.Windows.Forms;

namespace DemoDelegate
{
    internal class MyListener : IOnFinishListener
    {
        public void ShowMessage(string s)
        {
            MessageBox.Show("Processing in MyListener");
        }
    }
}