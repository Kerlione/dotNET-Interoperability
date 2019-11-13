Public Class VBSecondNumber
    Public Shared Function GetInt() As Int32
        System.Console.Write("Please, enter second number: ")
        Dim value = 0
        value = System.Convert.ToInt32(System.Console.ReadLine())
        Return value
    End Function
End Class
