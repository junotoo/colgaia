Module f25ex3
    Sub Main(args As String())
        Dim idades(24) As Integer
        Dim c As Byte
        ARpedirInteger(idades, 24,,, False, "Introduza a idade do ", "º jogador: ")
        Console.Write("Os jogadores de número impar têm as seguintes idades: ")
        For c = 0 To 23 Step 2
            Console.Write(idades(c) & " ")
        Next
        esperaAlt()
    End Sub
End Module
