using System.Collections.Generic;

namespace DecouplingClasses.Tests
{
    public class TestableConsole : IConsole
    {
        public TestableConsole()
        {
            WrittenLines = new List<string>();
        }

        public List<string> WrittenLines { get; set; }
        public void Write(string value)
        {
            WrittenLines.Add(value);
        }

        public void WriteLine(string value)
        {
            WrittenLines.Add(value);
        }

        public string LineToRead { get; set; }

        public string ReadLine()
        {
            return LineToRead;
        }
    }
}