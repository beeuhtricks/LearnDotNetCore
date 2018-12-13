using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LearnFSharpLibrary;

namespace LearnCSharpLibrary
{
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
