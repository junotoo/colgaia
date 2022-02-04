Module f22ex8
    Sub Main(args As String())
        Dim num As Integer
        Dim c As Integer = 0
        Do
            num = pedirInteger()
            c += 1
        Loop Until num = 0
        Console.WriteLine("Foram lidos {0} valores.", c)
    End Sub
End Module
