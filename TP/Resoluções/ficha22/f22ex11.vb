Module f22ex11
    Sub Main(args As String())

        Dim num As Integer
        Dim i As Integer
        Dim max As Integer
        Dim min As Integer

        i = 0
        max = -32767
        min = 32768
        Do
            num = pedirInteger()
            i = i + 1
            If num > max Then
                max = num
            End If
            If num < min Then
                min = num
            End If
            Console.Clear()
        Loop Until i = 3
        Console.WriteLine("O maior lido foi {0} e o menor valor lido foi {1}.", max, min)
        esperaAlt()
    End Sub
End Module
