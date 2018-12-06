using System;
using System.IO;
using Xunit;
using Program = LearnCSharp;

namespace LearnCSharpTests
{
    public class ProgramTests
    {
        [Fact]
        public void MainTest()
        {
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            var bootstrapTest = new Program.Bootstrap();
            bootstrapTest.Start(new []{"MainTest"});
            Assert.Equal("Hello MainTest!\n", consoleOutput.ToString());
        }
    }
}