Module f27ex2
    Sub Main(args As String())
        Dim word As String
        word = pedirString("Introduza uma palavra: ")
        Console.Clear()
        Console.WriteLine(Mid(word, 1, 4))
        word.Reverse()
        Console.WriteLine(Mid(word, 1, 4))
        esperaAlt()

    End Sub


End Module
