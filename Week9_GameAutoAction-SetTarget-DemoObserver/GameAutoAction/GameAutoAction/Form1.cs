using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameAutoAction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Global.CurrentForm = this;
        }

        internal void IAmDone()
        {
            timer1.Stop();
            textBoxBuildingWonder.Text="You win";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Global.ProduceFood();
            if (Global.IsBuildingWonder)
                Global.BuildWonder();
            DisplayCurrentGameStatus();
            Global.Turn++;
        }

        private void DisplayCurrentGameStatus()
        {
            textBoxTurn.Text = Global.Turn.ToString();
            textBoxFood.Text = Global.Food.ToString();
            textBoxVillager.Text = Global.nVillagers.ToString();
            if (Global.IsBuildingWonder == true)
                textBoxBuildingWonder.Text = Global.wonder.NTurns.ToString();

        }
    }
}
