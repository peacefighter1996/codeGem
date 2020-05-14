using System;

namespace Mechanoid.Parser.CSV.Tests
{
    public class TestDataObject
    {
        public TestDataObject()
        {
        }

        public int Id { get; set; }

        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Birthday { get; set; }
    }
}
