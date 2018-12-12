namespace LearnFSharpLibrary

open System
open System.Runtime.CompilerServices
open System.Reflection

[<Extension>]
module Extensions =
    [<Extension>]
    let Print(s : string) = printfn "%s" s
