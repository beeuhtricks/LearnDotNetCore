namespace LearnCSharp
{
    using LearnCSharpLibrary;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            var bootstrap = new Bootstrap(args);
            bootstrap.Start();
        }
    }
}
