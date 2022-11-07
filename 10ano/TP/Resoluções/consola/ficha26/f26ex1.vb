Module f26ex1
    Sub Main(args As String())
        Dim array(5, 5) As Integer
        Dim maior, menor, cmaior, cmenor, lmaior, lmenor, c, c2 As Integer
        Dim media As Double
        AR2pedirInteger(array, 5, 5)
        Console.WriteLine("Elementos da primeira coluna.")
        AR2mostrarInteger(array, 5, 5,, 1)
        esperaAlt()
        Console.WriteLine("Elementos da segunda linha")
        AR2mostrarInteger(array, 5, 5, 2)
        esperaAlt()
        Console.WriteLine("Soma da terceira coluna.")
        Console.WriteLine(AR2mediaInteger(array, 5, 5, True,, 3))
        esperaAlt()
        Console.WriteLine("A soma da quarta linha menos a soma da 2 coluna.")
        Console.WriteLine(AR2mediaInteger(array, 5, 5, True, 4) - AR2mediaInteger(array, 5, 5, True,, 2))
        esperaAlt()
        Console.WriteLine("O maior valor.")
        AR2MaiorMenor(array, maior, menor, 5, 5, True, cmaior, cmenor, lmaior, lmenor)
        Console.WriteLine(maior)
        Console.WriteLine("Com coordenadas {0},{1}.", cmaior, lmaior)
        esperaAlt()
        Console.WriteLine("O menor valor.")
        Console.WriteLine(menor)
        Console.WriteLine("Com coordenadas {0},{1}.", cmenor, lmenor)
        esperaAlt()
        Console.WriteLine("A média da quinta linha.")
        Console.WriteLine(AR2mediaInteger(array, 5, 5,, 5))
        esperaAlt()
        Console.WriteLine("O maior número da matriz menos o menor,")
        Console.WriteLine(maior - menor)
        esperaAlt()
        Console.WriteLine("Diagonal principal.")
        AR2diagonal(array, 5)
        esperaAlt()
        Console.WriteLine("Diagonal secundária.")
        AR2diagonal(array, 5, True)
        esperaAlt()
        Console.WriteLine("Todos os números acima da diagonal principal.")
        AR2diagonal(array, 5,, -1)
        esperaAlt()
        Console.WriteLine("Todos os números abaixo da diagonal principal.")
        AR2diagonal(array, 5,, 1)
        esperaAlt()
        Console.WriteLine("Todos os números abaixo da diagonal secundária.")
        AR2diagonal(array, 5, True, 1)
        esperaAlt()
        Console.WriteLine("Todos os números acima da diagonal secundária.")
        AR2diagonal(array, 5, True, -1)
        esperaAlt()
        Console.WriteLine("A média de todos os números exceto o maior e o menor")
        For c2 = 0 To 4
            For c = 0 To 4
                If array(c, c2) <> maior And array(c, c2) <> menor Then
                    media += array(c, c2)
                End If
            Next
        Next
        media /= 5 * 5
        Console.WriteLine(media)
        esperaAlt()
        Console.Write("Escolha a linha a qual seram efetuados os calculos: ")
        c = Console.ReadLine()
        Console.WriteLine("Soma")
        Console.WriteLine(AR2mediaInteger(array, 5, 5, True, c))
        Console.WriteLine("Média")
        Console.WriteLine(AR2mediaInteger(array, 5, 5,, c))
        Console.WriteLine("Maior")
        For c2 = 0 To 4
            If array(c, c2) > maior Then
                maior = array(c, c2)
            End If
        Next
        Console.WriteLine(maior)
            esperaAlt()
    End Sub
End Module
