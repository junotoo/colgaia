Module f22ex6
    Sub Main(args As String())
        Dim nota As Decimal
        Dim c As Byte = 0
        Do
            c += 1
            nota = pedirDouble("Introduza a nota do teste teórico: ", 20, 0)
            Console.Clear()
            nota += pedirDouble("Introduza a nota do teste prático: ", 20, 0)
            Console.Clear()
            nota /= 2
            If nota < 9.5 Then
                Console.WriteLine("Aluno reprovado com nota {0}", nota)
            Else
                Console.Write("Aluno aprovado com nota {0}", nota)
            End If
            esperaAlt
        Loop Until c = 30
    End Sub
End Module
