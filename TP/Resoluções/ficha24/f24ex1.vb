Module f24ex1
    Sub Main(args As String())
        Dim c As Integer
        For c = 1000 To 2000
            If c Mod 11 = 5 Then
                Console.WriteLine(c)

            End If
        Next
        esperaAlt()
    End Sub

End Module

