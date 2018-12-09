namespace LearnFSharpLibrary

open System
open System.Runtime.CompilerServices

[<Extension>]
module Extensions =
    [<Extension>]
    let Blorp(o : obj) : string = "bork"
