namespace LearnFSharpLibrary

open System
open System.Runtime.CompilerServices

[<Extension>]
module Extensions =
    [<Extension>]
    let Print(s : string) = printfn "%s" s

    type String with
        member s.Print() = printfn "%s" s