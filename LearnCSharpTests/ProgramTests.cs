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

            var bootstrapTest = new Bootstrap(new []{"MainTest"});
            bootstrapTest.Start();

            Assert.Equal("Hello MainTest!\n", consoleOutput.ToString());
        }
    }
}
