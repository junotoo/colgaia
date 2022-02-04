Module f22ex12
    Sub Main(args As String())
        Dim num As Integer
        Dim c As Byte = 0
        Dim num2 As Integer = 0
        num = pedirInteger()
        Do
            c += 1
            num2 += num / c
        Loop Until c = 20
    End Sub
End Module
