Module f25ex5
    Sub Main(args As String())
        Dim crt(20) As Char
        Dim crt2(20) As Char
        ARpedirChar(crt, 20)
        crt2 = crt
        Array.Reverse(crt2)
        ARmostrarChar(crt2, 20)
        esperaAlt()
    End Sub
End Module
