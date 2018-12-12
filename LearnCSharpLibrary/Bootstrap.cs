using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LearnFSharpLibrary;

namespace LearnCSharpLibrary
{
    public class Bootstrap
    {
        private readonly ReadOnlyCollection<string> _args;

        public Bootstrap(IList<string> args)
        {
            _args = new ReadOnlyCollection<string>(args);
        }

        public void Start()
        {
            Console.WriteLine($"Hello World from {_args[0]}!");
            const string str = "blorp";
            str.Print();

            var x = ("hello", 4);
        }
    }
}
