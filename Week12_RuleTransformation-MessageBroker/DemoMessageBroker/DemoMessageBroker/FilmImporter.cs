using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoMessageBroker
{
    public abstract class FilmImporter
    {
        public abstract bool IsValidInput(object input);

        public abstract SuatChieuPhim Convert(object input);
    }
}