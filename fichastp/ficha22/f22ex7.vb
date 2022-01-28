Module f22ex7
    Sub Main(args As String())
        Dim num As Integer = 0
        Do
            num += pedirInteger()
            Console.Clear()
        Loop Until num >= 5000
        Console.WriteLine("o valor so somatório foi {0}", num)
    End Sub
End Module
