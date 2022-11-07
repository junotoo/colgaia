Module f23ex4
    Sub Main(args As String())
        Dim num As Integer = 1
        Dim c As Byte = 1
        While c <= 8
            num *= c
            Console.WriteLine("O fatorial de {0} é {1}", c, num)
            c += 1
        End While
        esperaAlt()
    End Sub
End Module
