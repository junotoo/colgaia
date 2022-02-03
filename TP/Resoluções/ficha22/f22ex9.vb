Module f22ex9
    Sub Main(args As String())
        Dim num As Integer
        Dim maior As Integer = 0
        Dim menor As Integer = 0
        Dim c As Integer = 0
        Do
            c += 1
            num = pedirInteger()
            Console.Clear()
            maiorMenor(num, maior, menor)
        Loop Until c = 30
        Console.WriteLine("Dos {0} números lidos, o maior foi {1} e o menor foi {2}", c, maior, menor)
        esperaAlt()
    End Sub
End Module
