using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoMessageBroker
{
    public abstract class FilmImporterManager
    {
        public List<FilmImporter> importers = new List<FilmImporter>();

        public FilmImporterManager()
        {
            importers.Add(new CGVFilmImporter());
            importers.Add(new LotteCinemaFilmImporter());
        }
        public SuatChieuPhim ImportFromData_AutoDetectInputFormat
            (object input)
        {
            int nImporters = importers.Count;
            for (int i = 0; i < nImporters; i++)
                if (importers[i].IsValidInput(input))
                    return importers[i].Convert(input);
            return null;
        }
    }
}