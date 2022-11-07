Module f22ex4
    Sub Main(args As String())
        Dim num As Integer
        Dim c As Byte = 0
        num = pedirInteger()
        If num \ 2 = 1 Then
            num -= 1
        End If
        Do
            c += 2
            Console.WriteLine(num + c)
        Loop Until c = 20
    End Sub
End Module
