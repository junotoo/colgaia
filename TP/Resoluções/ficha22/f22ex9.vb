Module f22ex9
    Sub Main(args As String())
        Dim num, pares, impares As Integer
        Dim c As Integer = 0
        Do
            c += 1
            num = pedirInteger()
            Console.Clear()
            pares += numsPares(num)
        Loop Until c = 30
        impares = 30 - pares
        Console.WriteLine("Dos {0} números lidos, {1} eram pares e {2} eram ímpares.", c, pares, impares)
        esperaAlt()
    End Sub
End Module
