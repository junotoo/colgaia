Module f22ex11
    Sub Main(args As String())

        Dim num As Integer
        Dim c As Byte = 0
        Dim max As Integer
        Dim min As Integer
        max = -32767
        min = 32768
        Do
            num = pedirInteger()
            c += 1
            maiorMenor(num, max, min)
        Loop Until c = 30
        Console.WriteLine("O maior lido foi {0} e o menor valor lido foi {1}.", max, min)
        esperaAlt()
    End Sub
End Module
