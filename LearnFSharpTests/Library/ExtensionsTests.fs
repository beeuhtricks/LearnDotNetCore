module LearnFSharpTests.Library.ExtensionsTests

open System
open System.IO
open Xunit
open LearnFSharpLibrary.Extensions

[<Fact>]
let PrintTest() =
    let consoleOutput = new StringWriter()
    Console.SetOut consoleOutput
    let testString = "This is a test."
    testString.Print()
    Assert.Equal(testString + Environment.NewLine, consoleOutput.ToString())