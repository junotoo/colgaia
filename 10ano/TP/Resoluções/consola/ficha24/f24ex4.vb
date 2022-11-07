Module f24ex4
    Sub Main(args As String())
        Dim idade As Integer
        Dim c As Byte
        Dim faixa1, faixa2, faixa3, faixa4, faixa5 As Byte
        For c = 1 To 15
            idade = pedirInteger("introduza a sua idade: ", , 0)
            Select Case idade
                Case > 15
                    faixa1 += 1
                Case > 30
                    faixa2 += 1
                Case > 45
                    faixa3 += 1
                Case > 60
                    faixa4 += 1
                Case < 60
                    faixa5 += 1
            End Select
        Next
        Console.WriteLine("Das 10 idades lidas, {0} pessoas pertenciam à 1ª faixa etária, {1} à 2ª, {2} à terceira, {3} à quarta e {4} à quinta", faixa1, faixa2, faixa3, faixa4, faixa5)
        esperaAlt()
    End Sub
End Module
