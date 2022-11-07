Imports System

Module nome_num
    Sub Main(args As String())
        Dim opt As Byte
        Dim lidos As Boolean = False
        Dim notas(28) As Double
        Dim nomes(28) As String
        Dim media As Double
        Dim numaluno As Integer = 0
        While opt <> 7
            opt = menu()
            Console.Clear()

            Select Case opt
                Case 1
                    introducao(notas, nomes)
                    lidos = True
                Case 2
                    If lidos Then
                        Console.WriteLine("Deseja mostrar a nota de que aluno? (Introduza -1 para mostrar todos)")
                        numaluno = Console.ReadLine()
                        If numaluno > 28 Then
                            Console.WriteLine("Número inválido, volte a introduzir...")
                        Else
                            mostraNota(notas, nomes, numaluno)
                        End If
                    Else
                        Console.WriteLine("Deve efetuar a leitura primeiro, selecione a 1ª opção no menu...")
                    End If
                    espera()
                Case 3
                    If lidos Then
                        Console.Write("A melhor nota foi: {0}", melhorAluno(notas))
                        Console.Write("Alunos que tiveram a melhor nota: ")
                        melhoresAlunos(notas, nomes, melhorAluno(notas))
                    Else
                        Console.WriteLine("Deve efetuar a leitura primeiro, selecione a 1ª opção no menu...")
                    End If
                    espera()
                Case 4
                    If lidos Then
                        Console.Write("A pior nota foi: {0}", piorNota(notas))
                        Console.Write("Alunos que tiveram a pior nota: ")
                        melhoresAlunos(notas, nomes, piorNota(notas))
                    Else
                        Console.WriteLine("Deve efetuar a leitura primeiro, selecione a 1ª opção no menu...")
                    End If
                    espera()
                Case 5
                    If lidos Then
                        media = mediaNotas(notas)
                        Console.Write("A média foi: {0}", media)
                    Else
                        Console.WriteLine("Deve efetuar a leitura primeiro, selecione a 1ª opção no menu...")
                    End If
                    espera()
                Case 6
                    If lidos Then
                        Console.Write("Alunos com nota acima da média: ")
                        acimaMedia(notas, nomes, media)
                    Else
                        Console.WriteLine("Deve efetuar a leitura primeiro, selecione a 1ª opção no menu...")
                    End If
                    espera()
                Case Else
                    Console.WriteLine("O valor introduzido não é uma opção no menu...")
                    espera()
            End Select
        End While
    End Sub
    Function menu()
        Dim opt As Byte
        Console.WriteLine("#  1  Leitura de classificações e nomes")
        Console.WriteLine("#  2  Mostrar a lista das classificações")
        Console.WriteLine("#  3  Melhor classificação")
        Console.WriteLine("#  4  Pior classificação")
        Console.WriteLine("#  5  Média das classificações")
        Console.WriteLine("#  6  Alunos acima da média")
        Console.WriteLine("#  7  Sair")
        Console.Write("  
Opção: ")
        opt = Console.ReadLine()
        Return opt
    End Function
    Sub espera()
        Console.WriteLine("

Pressione qualquer tecla para continuar...")
        Console.ReadKey()
        Console.Clear()
    End Sub
    Sub introducao(ByRef notas() As Double, ByRef nomes() As String)
        Dim c As Byte
        Dim erro As Boolean = True
        For c = 0 To 27
            Console.Write("Introduza o nome do {0}º aluno: ", c + 1)
            nomes(c) = Console.ReadLine
            Console.Clear()
            Do
                Console.Write("Introduza a nota do aluno {0}º aluno: ", c + 1)
                notas(c) = Console.ReadLine
                Console.Clear()
                If notas(c) < 0 Or notas(c) > 20 Then
                    Console.WriteLine("O valor introduzido está incorreto. Volte a introduzir...")
                    erro = True
                    espera()
                Else
                    erro = False
                End If
            Loop Until erro = False
        Next

    End Sub
    Sub mostraNota(notas() As Double, nomes() As String, numaluno As Byte)
        Dim c As Byte
        If numaluno = -1 Then
            For c = 0 To 27
                Console.WriteLine("Nota de {0}: {0}.", nomes(c + 1), notas(c))
            Next
        Else
            Console.WriteLine("Nota de {0}: {0}.", nomes(numaluno), notas(numaluno - 1))
        End If
    End Sub
    Function melhorAluno(notas() As Double)
        Dim c As Integer
        Dim maior As Double = 0
        For c = 0 To 27
            If notas(c) >= maior Then
                maior = notas(c)
            End If
        Next
        Return maior
    End Function
    Sub melhoresAlunos(notas() As Double, nomes() As String, maior As Double)
        Dim c As Integer
        For c = 0 To 27
            If notas(c) = maior Then
                Console.Write("{0} ", nomes(c))
            End If
        Next
    End Sub
    Function piorNota(notas() As Double)
        Dim c As Integer
        Dim menor As Double = 0
        For c = 0 To 27
            If notas(c) <= menor Then
                menor = notas(c)
            End If
        Next
        Return menor
    End Function
    Function mediaNotas(notas() As Double)
        Dim media As Double
        Dim c As Byte
        For c = 0 To 27
            media += notas(c)
        Next
        media /= 27
        Return media
    End Function
    Sub acimaMedia(notas() As Double, nomes() As String, media As Double)
        Dim c As Byte
        For c = 0 To 27
            If notas(c) > media Then
                Console.Write("{0} ", nomes(c))
            End If
        Next
    End Sub
End Module
