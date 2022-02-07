Module f24ex5
    Sub Main(args As String())
        Dim nota As Double = 0
        Dim c, c2 As Byte
        Dim media As Double = 0
        Dim quant As Byte = 0
        For c = 1 To 10
            For c2 = 1 To 10
                nota = pedirDouble("Introduza a " & c2 & "ª nota do" & c & "º aluno", 20, 0)
                media += nota
            Next
            media /= 5
            Console.WriteLine("A média do {0}º aluno é de {1}.")
            esperaAlt()
        Next
    End Sub
End Module
