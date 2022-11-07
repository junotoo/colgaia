Module f24ex3_2
    Sub Main(args As String())
        Dim num As Double = 1
        Dim c, c2 As Byte
        For c2 = 1 To 20
            For c = 1 To c2
                num *= c
            Next
            Console.WriteLine("O fatorial de {0} é {1}", c2, num)
        Next
        esperaAlt()
    End Sub
End Module
