using System.Collections.Generic;
using System.Linq;

namespace EventosV2
{
    public class ReaderText : IRead
    {
        private readonly string _pathFile;

        public ReaderText(string pathFile)
        {
            _pathFile = pathFile;
        }

        public List<string> GetListEvent()
        {
            string[] lines = System.IO.File.ReadAllLines(_pathFile);

            return lines.ToList();
        }
    }
}
