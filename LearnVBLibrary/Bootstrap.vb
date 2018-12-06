Public Class Bootstrap
    Private ReadOnly _args As String()

    Public Sub New(ByVal args As String())
        _args = args
    End Sub

    Public Sub Start()
        Console.WriteLine($"Hello World from {_args(0)}!")
    End Sub
End Class
