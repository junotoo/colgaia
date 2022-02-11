Module f27ex3
    Sub Main(args As String())
        Dim seq As String
        Dim seq2 As String

        Console.OutputEncoding = System.Text.Encoding.UTF8
        Console.WriteLine("Insira uma sequência de carateres:")
        seq = Console.ReadLine()

        seq2 = seq.Replace("1", "*").Replace("2", "*").Replace("3", "*").Replace("4", "*").Replace("4", "*").Replace("5", "*").Replace("6", "*").Replace("7", "*").Replace("8", "*").Replace("9", "*")
        Console.WriteLine(seq2)
    End Sub

End Module
