Module f21ex7



    Sub Main(args As String())



        Dim val_final, val_uni As Decimal
        Dim code, qtd As Byte
        Dim fechar_prgm As Boolean



        Console.OutputEncoding = System.Text.Encoding.UTF8



        'Valores iniciais
        fechar_prgm = False
        val_final = 0



        Do
            'Input: código do produto
            Do
                Console.Write("Introduza o código do produto: ")
                code = Console.ReadLine()
                If code < 100 Or code > 104 Then
                    Console.WriteLine("Valor incorreto! Tem de ser entre 100 e 104" & vbCrLf & "Prima qualquer tecla para continuar")
                    Console.ReadKey()
                End If
                Console.Clear()
            Loop While code < 100 Or code > 104



            'Input: quantidade
            Do
                Console.Write("Introduza o quantide de produtos que deseja: ")
                qtd = Console.ReadLine()
                If qtd <= 0 Then
                    Console.WriteLine("Valor incorreto! Tem de ser maior que 0" & vbCrLf & "Prima qualquer tecla para continuar")
                    Console.ReadKey()
                End If
                Console.Clear()
            Loop While qtd <= 0



            'Processamento de valores
            Select Case code
                Case 100
                    val_uni = 3
                Case 101
                    val_uni = 4
                Case 102
                    val_uni = 4.5
                Case 103
                    val_uni = 1.5
                Case = 104
                    val_uni = 2
            End Select



            val_final += val_uni * qtd



            'Pergunta ao utilisador se deseja encerrar o programa
            Console.Write("Deseja comprar mais alguma coisa? Prima S (sim) ou N (não)")
            Do
                If Console.ReadKey().Key = ConsoleKey.N Then
                    fechar_prgm = True
                End If
            Loop Until fechar_prgm = True Or Console.ReadKey().Key = ConsoleKey.S
            Console.Clear()



        Loop Until fechar_prgm = True



        'Output
        Console.WriteLine("Valor a pagar: {0}€", val_final)



        'Finalizar o programa
        Console.WriteLine("Prima qualquer tecla para encerrar o programa")
        Console.ReadKey()



    End Sub



End Module