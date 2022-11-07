Module f27ex4
    Sub Main(args As String())
        Const N = 20
        Dim word As String
        Dim vet(N) As String
        Dim i, cont, cont1 As Integer
        Do
            vet(i) = pedirString()

            If Len(vet(i)) = 15 Then
                cont += 1
            End If
            If vet(i).First() = "A" Then
                cont1 += 1
            End If
        Loop Until vet(i) = "SAIR" Or i = N - 1
        If cont >= 1 Then
            Console.WriteLine(cont)
            esperaAlt()
        End If
        If cont1 >= 1 Then
            Console.WriteLine(cont1)
            esperaAlt()
        End If
        If cont = 0 And cont1 = 0 Then
            esperaAlt()
        End If
    End Sub
End Module
