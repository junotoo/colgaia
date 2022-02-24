Module f26ex2
    Sub Main(args As String())
        Dim notas(7, 10) As Double
        Dim aluno1, aluno2, aluno3 As String
        Dim maior1, maior2, maior3 As Double
        Dim c As Byte
        Dim media, soma As Double
        Dim nomes(10) As String
        Dim maior As Double
        Dim cont, c2, c3, c4, c5, c6 As Integer
        Dim disciplinas() As String = {"PT", "MAT", "EF", "FQ", "TP", "FAC", "AI"}
        ARpedirString(nomes, 10,,, False, "Introduza o nome do ", "º aluno")
        AR2pedirDouble(notas, 7, 10,,, False, "Introduza a ", "ª nota do ", "º aluno: ", 20, 0)
        esperaAlt()
        Console.WriteLine("O nome do aluno nº 3.")
        Console.WriteLine(nomes(2))
        esperaAlt()
        Console.WriteLine("As notas a Português.")
        AR2mostrarDouble(notas, 7, 10,, 0)
        esperaAlt()
        Console.WriteLine("A nota do aluno no 8 a Téc. de Programação.")
        Console.WriteLine(notas(4, 7))
        esperaAlt()
        Console.WriteLine("A média da turma no curso.")
        Console.WriteLine(AR2mediaDouble(notas, 7, 10))
        esperaAlt()
        Console.WriteLine("Mostrar a média de cada disciplina.")
        For c = 0 To 6
            Console.WriteLine("A média de {0} é {1}", disciplinas(c), AR2mediaDouble(notas, 7, 10,,, c))
        Next
        esperaAlt()
        Console.WriteLine("Mostrar a média de cada aluno.")
        For c = 0 To 6
            Console.WriteLine("A média de {0} é {1}", nomes(c), AR2mediaDouble(notas, 7, 10,, c))
            If (AR2mediaDouble(notas, 7, 10,, c)) > maior Then
                maior = AR2mediaDouble(notas, 7, 10,, c)
                c2 = c
            End If
        Next
        esperaAlt()
        Console.WriteLine("O aluno com a melhor média.")
        Console.WriteLine(nomes(c2))
        esperaAlt()
        Console.WriteLine("O número de negativas na turma.")
        For c2 = 0 To 9
            For c = 0 To 6
                If notas(c, c2) > 9.5 Then
                    c3 += 1
                End If
            Next
        Next
        Console.WriteLine(c3)
        esperaAlt()
        Console.WriteLine("A (s) disciplina (s) com menos negativas.")
        For c2 = 0 To 9
            For c = 0 To 6
                If notas(c, c2) > 9.5 Then
                    c3 += 1
                    c4 = c2
                End If
            Next
            If c3 < c5 Then
                c5 = c3
                c6 = c4
            End If
        Next
        Console.WriteLine(disciplinas(c6))
        esperaAlt()
        Console.WriteLine("O aluno com a melhor nota a Português.")
        For c = 0 To 6
            Console.WriteLine("A média de {0} é {1}", disciplinas(c), AR2mediaDouble(notas, 7, 10,, 0))
            If AR2mediaDouble(notas, 7, 10,, 0) > c2 Then
                c2 = AR2mediaDouble(notas, 7, 10,, 0)
            End If
        Next
        Console.WriteLine(nomes(c2))
        esperaAlt()
        Console.WriteLine("Quais os alunos que passariam de ano (no máximo com 2 negativas)")
        melhores(notas, nomes)
        esperaAlt()
        vintes(nomes, notas, disciplinas)
        esperaAlt()
        Do
            cont = cont + 1
            For c2 = 0 To 9
                For c = 0 To 6
                    soma = soma + notas(c, c2)
                    media = soma / 6
                Next
                If media > maior1 Then
                    aluno1 = nomes(c2)
                End If
                If media > maior2 And media < maior1 Then
                    aluno2 = nomes(c2)
                End If
                If media > maior3 And media < maior2 Then
                    aluno3 = nomes(c2)
                End If
            Next
        Loop Until cont = 2

    End Sub
End Module
