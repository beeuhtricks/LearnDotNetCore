// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProgramTests.cs" company="Beatrix Klebe">
//   2018 Beatrix Klebe
// </copyright>
// <summary>
//   Defines the ProgramTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnCSharpTests.Executable
{
    using System;
    using System.IO;

    using LearnCSharpLibrary;

    using Xunit;

    /// <summary>
    /// The program tests.
    /// </summary>
    public class ProgramTests
    {
        /// <summary>
        /// The main test.
        /// </summary>
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
