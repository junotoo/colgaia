Module f23ex3
    Sub Main(args As String())
        Dim num As Integer
        Dim soma As Integer = 1
        Dim less As Integer = -1
        Dim media As Double = -1
        While num <> -1
            num = pedirInteger("Introduza o número de peças produzidas: ")
            soma += num
            media += 1
            If num < 250 Then
                less += 1
            End If
        End While
        media = soma / media
        Console.WriteLine("O número total de peças foi {0}, a média foi {1}, e o número de vezes em que a produção foi inferior a 250 foi {2}.", soma, media, less)
        esperaAlt()
    End Sub
End Module
