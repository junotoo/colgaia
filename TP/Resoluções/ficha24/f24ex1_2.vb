Module f24ex1_2
    Sub Main(args As String())
        Dim num As Integer
        Dim c As Byte
        Dim quant As Byte = 0
        For c = 1 To 10
            num = pedirInteger()
            If num >= 30 And num <= 90 Then
                quant += 1
            End If
        Next
        Console.WriteLine("Dos 10 números lidos, {0} eram entre 30 e 90", quant)
        esperaAlt()
    End Sub
End Module
