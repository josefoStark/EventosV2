using System;
using System.Collections.Generic;
using System.IO;
using EventDomain;

namespace EventServices
{
    public class TextReaderService : IRead
    {
        private static string _pathFile;

        public Func<string[]> Lines = () => File.ReadAllLines(_pathFile);

        public TextReaderService(string pathFile)
        {
            _pathFile = pathFile;
        }

        public List<IDatos> GetListEvent()
        {
            List<IDatos> result = new List<IDatos>();
            string[] lstLines = Lines();
            foreach (var item in lstLines)
            {
                result.Add(GetEvent(item));
            }

            return result;
        }

        private IDatos GetEvent(string line)
        {
            string[] datos = line.Split(Convert.ToChar(","));
            IDatos result = new EventInformation
            {
                Name = datos[0],
                OriginalDateTime = datos[1]
            };

            return result;
        }
    }
}
