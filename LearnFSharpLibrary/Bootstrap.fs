module LearnFSharpLibrary.Bootstrap

open LearnFSharpLibrary.Library

let start (args : string []) =
    Say.hello args.[0]
    0
