using System.Collections.Generic;

namespace DecouplingClasses.Tests
{
    public class TestableConsole : IConsole
    {
        public TestableConsole()
        {
            LastWrittenLine = new List<string>();
        }

        public List<string> LastWrittenLine { get; set; }
        public void Write(string value)
        {
            LastWrittenLine.Add(value);
        }

        public void WriteLine(string value)
        {
            LastWrittenLine.Add(value);
        }

        public string LineToRead { get; set; }

        public string ReadLine()
        {
            return LineToRead;
        }
    }
}