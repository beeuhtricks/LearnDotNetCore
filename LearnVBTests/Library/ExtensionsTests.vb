Imports System.IO
Imports LearnVBLibrary
Imports Xunit

Public Class ExtensionsTests
    <Fact>
    Sub PrintStringEqual()
        Dim consoleOutput = New StringWriter
        Console.SetOut(consoleOutput)

        Const testString = "This is a test."
        testString.Print()

        Assert.Equal($"This is a test.{Environment.NewLine}", consoleOutput.ToString())
    End Sub
End Class