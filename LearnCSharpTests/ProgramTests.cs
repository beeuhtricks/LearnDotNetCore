using System;
using System.IO;
using LearnCSharpLibrary;
using Xunit;

namespace LearnCSharpTests
{
    public class ProgramTests
    {
        [Fact]
        public void MainTest()
        {
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            var bootstrapTest = new Bootstrap(new[] { "MainTest" });
            bootstrapTest.Start();
            var expected = $"Hello World from MainTest!{Environment.NewLine}";
            Assert.Equal(expected, consoleOutput.ToString());
        }
    }
}
