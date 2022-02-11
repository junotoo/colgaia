Module f27ex2
    Sub Main(args As String())
        Dim word As String

        Console.WriteLine("Insira uma palavra:")
        word = Console.ReadLine()
        esperaAlt()

        Console.WriteLine(StrReverse(word))

    End Sub


End Module
