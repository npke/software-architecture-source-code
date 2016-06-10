using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoComposite
{
    public class MachPhuc : MachDien
    {
        protected List<MachDien> _ThanhPhan;
        public List<MachDien> ThanhPhan
        {
            get
            {
                return _ThanhPhan;
            }

            set
            {
                _ThanhPhan = value;
            }
        }
    }
}