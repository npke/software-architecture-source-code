using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EResource.Initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EResource ebook1 = new EResource("Ebook");
            ebook1["Title"] = "Giáo trình môn...";
            ebook1["Authors"] = "Author1";



            EResource audio = new EResource("Audio");
            ebook1["Title"] = "Song ...";
            ebook1["Artists"] = "Artist 1, Artist 2";

        }
    }
}
