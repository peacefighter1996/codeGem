using System;
using System.Collections.Generic;
using System.Text;

namespace Mechanoid.Parser.CSV
{
    public class CsvParser<T> : Parser.DataLoader<T>
    {
        readonly bool hasHeader;
        public CsvParser(bool hasHeader = false)
        {
            this.hasHeader = hasHeader;
        }

        public T ParseDocument(string filePath)
        {
            throw new NotImplementedException();
        }

        public T[] ParseMultiObjectDocument(string filepath)
        {
            throw new NotImplementedException();
        }

    }
}
