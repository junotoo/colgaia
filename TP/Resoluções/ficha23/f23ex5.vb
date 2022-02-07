Module f23ex5
    Sub Main(args As String())
        Dim min As Integer = pedirInteger("Introduza o valor mínimo: ")
        Dim max As Integer = pedirInteger("Introduza o valor máximo: ",, min)
        Dim num As Integer = min
        Dim c As Byte = 1
        Dim div As Integer = 0
        While num <= max
            While c <= num
                If num \ c = 0 Then
                div += 1
            End If
            End While
            If div = 2 Then
                Console.WriteLine("O número {0} é primo.", num)
            End If
            num += 1
        End While
        esperaAlt()
    End Sub
End Module
