using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameAutoAction
{
    public class Wonder
    {
        private int nTurns = Global.TurnsToBuildWonder;

        public int NTurns
        {
            get
            {
                return nTurns;
            }

            set
            {
                nTurns = value;
            }
        }

        public void BuildInATurn()
        {
            this.NTurns--;
            if (this.NTurns == 0)
                OnBuildWonderFinished();
        }

        private void OnBuildWonderFinished()
        {
            Global.CurrentForm.IAmDone();
        }
    }
}