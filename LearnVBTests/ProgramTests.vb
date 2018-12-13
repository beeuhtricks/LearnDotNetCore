Imports System.IO
Imports LearnVBLibrary
Imports Xunit

Public Class ProgramTests
    <Fact>
    Sub MainTest()
        Dim consoleOutput = New StringWriter
        Console.SetOut(consoleOutput)

        Dim bootstrapTest = New Bootstrap({"MainTest"})
        bootstrapTest.Start()

        Assert.Equal($"Hello World from MainTest!{Environment.NewLine}", consoleOutput.ToString())
    End Sub
End Class
