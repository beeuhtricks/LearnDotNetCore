// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Beatrix Klebe">
//   2018 Beatrix Klebe
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnCSharp
{
    using LearnCSharpLibrary;

    /// <summary>
    /// The program.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            var bootstrap = new Bootstrap(args);
            bootstrap.Start();
        }
    }
}
