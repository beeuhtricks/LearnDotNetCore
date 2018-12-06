module ProgramTests

open System
open System.IO
open Xunit
open LearnFSharpLibrary

[<Fact>]
let MainTest() =
    let consoleOutput = new StringWriter()
    Console.SetOut consoleOutput
    Bootstrap.start [| "MainTest" |] |> ignore
    Assert.Equal("Hello World from MainTest!\n", consoleOutput.ToString())
