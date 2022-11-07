Module f25ex4
    Sub Main(args As String())
        Dim vendas(12) As Double
        Dim c As Byte
        Dim max As Double = 0
        ARpedirDouble(vendas, 12,,, False, "Introduza a quantidade vendida no ", "º mês: ")
        For c = 0 To 11
            If vendas(c) > max Then
                max = c
            End If
        Next
        Console.WriteLine("O mês com mais vendas foi o {0}º mês.", max)
    End Sub
End Module
