Module f21ex1
    Sub Main(args As String())
        Dim tipo As Byte
        Dim bool As Boolean
        Dim quantidade As Integer

        Do
            Console.Write("Introduza o tipo de batatas a comprar:")
            tipo = Console.ReadLine
            If tipo < 1 Or tipo > 5 Then
                bool = 1
                Console.WriteLine("O tipo introduzido estava errado, insira um valor correto")
                Console.WriteLine("Prima qualquer tecla para continuar...")
                Console.ReadKey()
                Console.Clear()
            Else
                bool = 0
            End If
        Loop Until bool = 0
        Do
            Console.Write("Introduza a quantidade de batatas a comprar:")
            quantidade = Console.ReadLine
            If quantidade < 1 Then
                bool = 1
                Console.WriteLine("A quantidade introduzida estava errada, insira um valor correto")
                Console.WriteLine("Prima qualquer tecla para continuar...")
                Console.ReadKey()
                Console.Clear()
            Else
                bool = 0
            End If
        Loop Until bool = 0

        Console.Clear()
        Select Case tipo
            Case 1
                Console.WriteLine(“Valor a pagar {0} Euros Qualidade: Branca“, 0.2 * quantidade)
            Case 2
                Console.WriteLine(“Valor a pagar {0} Euros Qualidade: Branca“, 0.25 * quantidade)
            Case 3
                Console.WriteLine(“Valor a pagar {0} Euros Qualidade: Rosada“, 0.3 * quantidade)
            Case 4
                Console.WriteLine(“Valor a pagar {0} Euros Qualidade: Extra“, 0.35 * quantidade)
            Case 5
                Console.WriteLine(“Valor a pagar {0} Euros Qualidade: Extra2“, 0.4 * quantidade)
        End Select
        Console.WriteLine("Prima qualquer tecla para continuar...")
        Console.ReadKey()
    End Sub
End Module
