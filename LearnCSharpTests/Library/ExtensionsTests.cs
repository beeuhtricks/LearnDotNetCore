// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExtensionsTests.cs" company="Beatrix Klebe">
//   2018 Beatrix Klebe
// </copyright>
// <summary>
//   Defines the ExtensionsTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnCSharpTests.Library
{
    using System;
    using System.IO;

    using LearnFSharpLibrary;

    using Xunit;

    /// <summary>
    /// The extensions tests.
    /// </summary>
    public class ExtensionsTests
    {
        /// <summary>
        /// The print string equal.
        /// </summary>
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