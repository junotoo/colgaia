Module f26ex1
    Sub Main(args As String())
        Dim array(5, 5) As Integer
        Dim maior, menor, cmaior, cmenor, lmaior, lmenor As Integer
        AR2pedirInteger(array, 5, 5)
        Console.WriteLine("Elementos da primeira coluna.")
        AR2mostrarInteger(array, 5, 5,, 1)
        esperaAlt()
        Console.WriteLine("Elementos da segunda linha")
        AR2mostrarInteger(array, 5, 5, 2)
        esperaAlt()
        Console.WriteLine("Soma da terceira coluna")
        Console.WriteLine(AR2mediaInteger(array, 5, 5, True,, 3))
        esperaAlt()
        Console.WriteLine("A soma da quarta linha menos a soma da 2 coluna")
        Console.WriteLine(AR2mediaInteger(array, 5, 5, True, 4) - AR2mediaInteger(array, 5, 5, True,, 2))
        esperaAlt()
        Console.WriteLine("O maior valor.")
        AR2MaiorMenor(array, maior, menor, 5, 5, True, cmaior, cmenor, lmaior, lmenor)
        Console.WriteLine(maior)
        Console.WriteLine("Com coordenadas {0},{1}", cmaior, lmaior)
        esperaAlt()
        Console.WriteLine("O menor valor.
")
        Console.WriteLine(menor)
        Console.WriteLine("Com coordenadas {0},{1}", cmenor, lmenor)
        esperaAlt()
    End Sub
End Module
