Module f22ex1
    Sub Main(args As String())
        Dim nome As String = pedirString()
        Dim c As Byte = 0
        Console.Clear()
        Do
            Console.WriteLine(nome)
            c += 1
        Loop Until c = 3
    End Sub
End Module