Module f23ex1
    Sub Main(args As String())

        Dim min As Integer = pedirInteger("Introduza o valor mínimo:")
        Dim max As Integer = pedirInteger("Introduza o valor máximo:")
        Dim i As Integer
        Dim num As Integer

        If min Mod 2 = 0 Then
            num = min + 1
            Console.WriteLine("O 1º número ímpar seguido ao mínimo inserido é {0}", num)
        End If
        If min Mod 2 = 1 Then
            num = min + 2
            Console.WriteLine("O 1º número ímpar seguido ao mínimo inserido é {0}", num)
        End If
        i = 2
        If max Mod 2 = 0 Then
            While num <= max - 3
                num = num + 2
                Console.WriteLine("O {0}º número ímpar seguido é {1}", i, num)
                i = i + 1
            End While

        Else
            While num <= max - 4
                num = num + 2
                Console.WriteLine("O {0}º número ímpar seguido é {1}", i, num)
                i = i + 1
            End While
        End If

        esperaAlt()

    End Sub

End Module
