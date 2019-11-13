Module LibraryInvoker

    Sub Main()
        Dim cppValue = CPPFirstNumber.CPPFirstNumber.GetInt()
        Dim vbValue = VB.SecondNumber.VBSecondNumber.GetInt()
        Dim csValue = CSharp.ThirdNumber.CSharpThirdNumber.GetInt()
        Dim result = cppValue + vbValue + csValue
        Console.WriteLine($"Sum of {cppValue}, {vbValue} and {csValue} is {result}")
        Console.ReadLine()
    End Sub

End Module
