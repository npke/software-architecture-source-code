using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoPublisherSubscriber
{
    public class Tin
    {
        static private int _nextID = 1;
        private int iD;
        private string noiDung;
        private List<string> tuKhoa;

        public Tin(string noidung, List<string> tukhoa)
        {
            iD = _nextID++;
            noiDung = noidung;
            tuKhoa = tukhoa;
        }

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public string NoiDung
        {
            get
            {
                return noiDung;
            }

            set
            {
                noiDung = value;
            }
        }

        public List<string> TuKhoa
        {
            get
            {
                return tuKhoa;
            }

            set
            {
                tuKhoa = value;
            }
        }
    }
}