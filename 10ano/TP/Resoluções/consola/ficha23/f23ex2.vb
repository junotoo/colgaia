Module f23ex2
    Sub Main(args As String())
        Dim num As Double
        Dim c As Byte = 0
        Dim desvio As Double
        While c < 12 And num <> -999
            num = pedirDouble()
            c += 1
            desvio -= num
        End While
        Console.WriteLine("O desvio é {0}.", desvio)
    End Sub
End Module