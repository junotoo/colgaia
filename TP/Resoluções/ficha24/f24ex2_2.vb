Module f24ex2_2
    Sub Main(args As String())
        Dim soma As Integer
        Dim c, c2 As Byte
        For c2 = 1 To 20
            For c = 1 To c2
                soma += c / c2
            Next
            Console.WriteLine("O valor do somatório é {0}(S={1})", soma, c2)
        Next
        esperaAlt()
    End Sub
End Module
