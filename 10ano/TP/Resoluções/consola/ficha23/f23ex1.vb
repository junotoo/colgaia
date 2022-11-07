Module f23ex1
    Sub Main(args As String())
        Dim min As Integer = pedirInteger("Introduza o valor mínimo:")
        Dim max As Integer = pedirInteger("Introduza o valor máximo:", , min)
        Dim c As Integer = 0
        If numPar(min) = 0 Then
            min -= 1
        End If
        If numPar(max) = 0 Then
            max -= 1
        End If
        While min <= max - 2
            min += 2
            Console.WriteLine("O {0}º número ímpar seguido é {1}", c, min)
            c += 1
        End While
        esperaAlt()
    End Sub
End Module
