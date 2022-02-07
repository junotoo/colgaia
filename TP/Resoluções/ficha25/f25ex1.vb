Module f25ex1
    Sub Main(args As String())
        Dim array(15) As Integer
        Dim media As Double = 0
        Dim c As Byte
        ARpedirInteger(array, 15)
        For c = 0 To 14
            media += array(c)
        Next
        Console.Write("A soma de todos os elementos é {0}", media)
        media /= 15
        Console.WriteLine(" e a sua média é {0}.", media)
        esperaAlt()
    End Sub
End Module
