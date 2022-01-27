Module ex5
    Sub Main(args As String())

        Dim idade, valor_final As Byte

        Console.OutputEncoding = System.Text.Encoding.UTF8

        'Definir o valor inicial
        valor_final = 15

        'Input
        Do
            Console.Write("Introduza a idade do cliente: ")
            idade = Console.ReadLine()
            If idade < 0 Then
                Console.WriteLine("Valor impossível! Idade tem de ser maior que 0" & vbCrLf & "Prima qualquer tecla para continuar")
                Console.ReadKey()
            End If
            Console.Clear()
        Loop While idade < 0

        'Adicionar os respetivos valores ao inicial
        Select Case idade
            Case > 60
                valor_final += 80
            Case > 30
                valor_final += 50
            Case > 10
                valor_final += 20
            Case Else
                valor_final += 10
        End Select

        'Output
        Console.WriteLine("Valor a pagar: {0}€", valor_final)

        'Finalizar o programa
        Console.WriteLine("Prima qualquer tecla para encerrar o programa")
        Console.ReadKey()

    End Sub

End Module
