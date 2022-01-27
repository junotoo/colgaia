Module ex4
    Sub Main(args As String())

        Dim mes As Byte

        'Input
        Do
            Console.Write("Introduza o número de um mês: ")
            mes = Console.ReadLine()
            If mes < 1 Or mes > 12 Then
                Console.WriteLine("Valor incorreto! Tem de ser entre 1 e 12" & vbCrLf & "Prima qualquer tecla para continuar")
                Console.ReadKey()
            End If
            Console.Clear()
        Loop While mes < 0 Or mes > 12

        'Output
        Select Case mes
            Case 1, 2, 6, 7, 12
                Console.WriteLine("O mês introduzido é de época alta")
            Case Else
                Console.WriteLine("O mês introduzido é de época baixa")
        End Select

        Console.WriteLine("Prima qualquer tecla para encerrar o programa")
        Console.ReadKey()

    End Sub

End Module
