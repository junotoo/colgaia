Module f21ex6



    Sub Main(args As String())



        Dim code As Byte
        Dim classe As String = 0



        'Input
        Do
            Console.Write("Introduza o código do produto: ")
            code = Console.ReadLine()
            If code < 1 Or code > 15 Then
                Console.WriteLine("Valor impossível! Tem que ser um valor entre 1 e 15" & vbCrLf & "Prima qualquer tecla para continuar")
                Console.ReadKey()
            End If
            Console.Clear()
        Loop While code < 1 Or code > 15



        'Escolha de classificações
        Select Case code
            Case 1
                classe = "Alimento não-perecível"
            Case 2, 3, 4
                classe = "Alimento perecível"
            Case 5, 6
                classe = "Vestuário"
            Case 7
                classe = "Higiene Pessoal"
            Case Is >= 8, Is <= 15
                classe = "Limpeza e Utensílios Domésticos"
        End Select



        'Output
        Console.WriteLine("O produto introduzido tem a seguinte classificação: {0}", classe)



        'Finalizar o programa
        Console.WriteLine("Prima qualquer tecla para encerrar o programa")
        Console.ReadKey()



    End Sub



End Module