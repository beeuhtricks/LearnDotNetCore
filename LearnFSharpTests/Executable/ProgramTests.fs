module LearnFSharpTests.Console.ProgramTests

open System
open System.IO
open Xunit
open LearnFSharpLibrary

[<Fact>]
let MainTest() =
    let consoleOutput = new StringWriter()
    Console.SetOut consoleOutput
    Bootstrap.start [| "MainTest" |] |> ignore
    let expected = sprintf "Hello World from MainTest!%s" Environment.NewLine
    Assert.Equal(expected, consoleOutput.ToString())
