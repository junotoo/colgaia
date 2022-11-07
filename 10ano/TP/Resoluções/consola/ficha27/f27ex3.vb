Module f27ex3
    Sub Main(args As String())
        Dim seq As String = 0
        Dim seq2 As String = 0

        Console.OutputEncoding = System.Text.Encoding.UTF8
        seq = pedirString("Introduza uma sequência de carateres: ")

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")

        seq2 = seq.Replace("1", "*").Replace("2", "*").Replace("3", "*").Replace("4", "*").Replace("4", "*").Replace("5", "*").Replace("6", "*").Replace("7", "*").Replace("8", "*").Replace("9", "*")
        Console.WriteLine(seq2)
    End Sub

End Module
