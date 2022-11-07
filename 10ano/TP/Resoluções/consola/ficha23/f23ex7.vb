Module f23ex7
    Sub Main(args As String())
        Dim num As Integer = pedirInteger()
        Dim c As Integer = 1
        Dim soma As Integer
        While c <= num
            c += 1
            soma += num - c
        End While
        writeAlt("O valor do somatório é " & soma)
    End Sub
End Module
