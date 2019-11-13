Public Class Program
    Inherits CPPLibrary.HelloCPP
    Public Overrides Sub Hello()
        MyBase.Hello()
        System.Console.WriteLine("Hello from VB")
    End Sub
End Class
