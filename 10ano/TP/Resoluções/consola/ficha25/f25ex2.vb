Module f25ex2
    Sub Main(args As String())
        Dim array(26) As Char
        Dim c As Byte
        ARpedirChar(array, 26)
        For c = 1 To 25 Step 2
            Console.Write(array(c) & " ")
        Next
        esperaAlt()
    End Sub
End Module
