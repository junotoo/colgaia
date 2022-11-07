Module f24ex3
    Sub Main(args As String())
        Dim idade As Integer
        Dim c As Byte
        Dim m18 As Byte = 0
        For c = 1 To 10
            idade = pedirInteger("introduza a sua idade: ", , 0)
            If idade > 18 Then
                m18 += 1
            End If

        Next
        Console.WriteLine("Das 10 idades lidas, {0} tinham mais de 18 anos", m18)
        esperaAlt()
    End Sub

End Module
