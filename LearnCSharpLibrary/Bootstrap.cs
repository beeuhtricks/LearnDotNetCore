// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bootstrap.cs" company="Beatrix Klebe">
//   2018 Beatrix Klebe
// </copyright>
// <summary>
//   Defines the Bootstrap type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LearnCSharpLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class Bootstrap
    {
        private readonly ReadOnlyCollection<string> args;

        public Bootstrap(IList<string> args)
        {
            this.args = new ReadOnlyCollection<string>(args);
        }

        public void Start()
        {
            Console.WriteLine($"Hello World from {this.args[0]}!");
        }
    }
}
