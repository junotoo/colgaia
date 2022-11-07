Module f22ex10
    Sub Main(args As String())
        Dim num As Integer = 0
        Dim c As Byte = 0
        Dim soma As Byte = 0
        Dim m10 As Byte = 0
        Dim m20 As Byte = 0
        Dim m100 As Byte = 0
        Do
            c += 1
            num = pedirInteger()
            soma += num
            If num > 100 Then
                m100 += 1
                m10 += 1
                m20 += 1
            ElseIf num > 20 Then
                m10 += 1
                m20 += 1
            ElseIf num > 10 Then
                m10 += 1
            End If
        Loop Until c = 40
        Console.WriteLine("O somatório dos valores lidos foi foi {0}, {1} números eram maiores do que 100, {2} números eram maiores do que 20 e {1} eram maiores do que 10.", soma, m100, m20, m10)
        esperaAlt()
    End Sub
End Module
