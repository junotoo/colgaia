Module f22ex3
    Sub Main()
        Dim num As Integer
        Dim c As Integer = 0
        num = pedirInteger()
        Do
            c += 1
            Console.WriteLine(num + c)
        Loop Until c = 21
    End Sub
End Module
