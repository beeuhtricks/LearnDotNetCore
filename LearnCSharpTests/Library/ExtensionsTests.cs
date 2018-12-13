namespace LearnCSharpTests.Library
{
    using System;
    using System.IO;

    using LearnFSharpLibrary;

    using Xunit;

    public class ExtensionsTests
    {
        [Fact]
        public void PrintStringEqual()
        {
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            const string TestString = "This is a test.";
            TestString.Print();
            Assert.Equal(TestString + Environment.NewLine, consoleOutput.ToString());
        }
    }
}