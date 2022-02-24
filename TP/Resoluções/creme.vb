Module creme
    Function pedirString(Optional msg As String = "Introduza o seu nome: ")
        Dim a As String
        Console.Write(msg)
        a = Console.ReadLine()
        Console.Clear()
        Return a
    End Function

    Function pedirInteger(Optional msg As String = "Introduza um numero inteiro: ", Optional max As Integer = 32767, Optional min As Integer = -32767, Optional msgErro As String = "O valor introduzido é inválido!")
        Dim num As Integer = min
        While num > min And num < max
            Console.Write(msg)
            num = Console.ReadLine
            Console.Clear()
            If num > max Or num < min Then
                Console.WriteLine(msgErro)
                esperaAlt()
            End If
        End While
        Return num
    End Function
    Function mediaAlt(numelementos As Integer, Optional msg As String = "Introduza o {0}º número inteiro: ")
        Dim soma As Double = 0
        Dim c As Integer = 0
        Do
            Console.Write(msg, c + 1)
            soma += Console.ReadLine
            c += 1
        Loop Until numelementos = c
        Console.Clear()
        Return soma / numelementos
    End Function
    Sub espera()
        Console.WriteLine("Pressione qualquer tecla para continuar...")
        Console.ReadKey()
    End Sub
    Sub esperaAlt()

        Console.WriteLine("


Pressione qualquer tecla para continuar...")
        Console.ReadKey()
        Console.Clear()
    End Sub
    Function pedirDouble(Optional msg As String = "Introduza um valor: ", Optional max As Double = 1.7976931348623157E+308, Optional min As Double = -1.7976931348623157E+308, Optional msgErro As String = "O valor introduzido é inválido!")
        Dim num As Double = min
        Do
            Console.Write(msg)
            num = Console.ReadLine
            If num > max Or num < min Then
                Console.WriteLine(msgErro)
                esperaAlt()
            End If
        Loop While num > max Or num < min
        Return num
    End Function
    Function numPar(num As Integer)
        Dim par As Integer
        If num \ 2 = 0 Then
            par += 1
        End If
        Return par
    End Function
    Sub maiorMenor(num As Integer, Optional ByRef maior As Integer = -32767, Optional ByRef menor As Integer = 32767)
        If num > maior Then
            maior = num
        End If
        If num < menor Then
            menor = num
        End If
    End Sub
    Function pedirChar(Optional msg As String = "Introduza um carater: ")
        Dim a As Char
        Console.Write(msg)
        a = Console.ReadLine()
        Console.Clear()
        Return a
    End Function
    Sub writeAlt(msg As String)
        Console.WriteLine(msg)
        esperaAlt()
    End Sub
    Sub ARpedirInteger(ByRef array() As Integer, posicoes As Integer, Optional paragemToggle As Boolean = False, Optional paragem As Integer = -1, Optional msg As Boolean = True, Optional msg1 As String = vbNullString, Optional msg2 As String = vbNullString, Optional max As Integer = 32767, Optional min As Integer = -32767, Optional msgErro As String = "O valor introduzido é inválido!")
        Dim c As Integer = 0
        Dim skip As Boolean = False
        While c < posicoes And skip = False And (array(c) > min Or array(c) < max)
            If msg = True Then
                Console.Write("Introduza o valor para a {0}ª posição do vetor: ", c + 1)
            Else
                Console.Write(msg1)
                Console.Write(c + 1)
                Console.Write(msg2)
            End If
            array(c) = Console.ReadLine()
            Console.Clear()
            If paragemToggle = True Then
                If array(c) = paragem Then
                    skip = True
                End If
                If array(c) < min Or array(c) > max Then
                    Console.WriteLine(msgErro)
                    esperaAlt()
                Else
                    c += 1
                End If
            Else
                c += 1
            End If
        End While
    End Sub
    Sub ARpedirDouble(ByRef array() As Double, posicoes As Integer, Optional paragemToggle As Boolean = False, Optional paragem As Double = vbNull, Optional msg As Boolean = True, Optional msg1 As String = vbNullString, Optional msg2 As String = vbNullString, Optional max As Integer = 32767, Optional min As Integer = -32767, Optional msgErro As String = "O valor introduzido é inválido!")
        Dim c As Integer = 0
        Dim skip As Boolean = False
        While c < posicoes And skip = False And (array(c) > min Or array(c) < max)
            If msg = True Then
                Console.Write("Introduza o valor para a {0}ª posição do vetor: ", c + 1)
            Else
                Console.Write(msg1)
                Console.Write(c + 1)
                Console.Write(msg2)
            End If
            array(c) = Console.ReadLine()
            Console.Clear()
            If paragemToggle = True Then
                If array(c) = paragem Then
                    skip = True
                End If
                If array(c) < min Or array(c) > max Then
                    Console.WriteLine(msgErro)
                    esperaAlt()
                Else
                    c += 1
                End If
            Else
                c += 1
            End If
        End While
    End Sub
    Sub ARpedirChar(ByRef array() As Char, posicoes As Integer, Optional paragemToggle As Boolean = False, Optional paragem As Char = vbNullChar, Optional msg As Boolean = True, Optional msg1 As String = vbNullString, Optional msg2 As String = vbNullString)
        Dim c As Integer = 0
        Dim skip As Boolean = False
        While c < posicoes And skip = False
            If msg Then
                Console.Write("Introduza o valor para a {0}ª posição do vetor: ", c + 1)
            Else
                Console.Write(msg1)
                Console.Write(c + 1)
                Console.Write(msg2)
            End If
            array(c) = Console.ReadLine()
            Console.Clear()
            If paragemToggle = True Then
                If array(c) = paragem Then
                    skip = True
                Else
                    c += 1
                End If
            Else
                c += 1
            End If
        End While
    End Sub
    Sub ARpedirString(ByRef array() As String, posicoes As Integer, Optional paragemToggle As Boolean = False, Optional paragem As String = vbNullString, Optional msg As Boolean = True, Optional msg1 As String = vbNullString, Optional msg2 As String = vbNullString)
        Dim c As Integer = 0
        Dim skip As Boolean = False
        While c < posicoes And skip = False
            If msg = True Then
                Console.Write("Introduza o valor para a {0}ª posição do vetor: ", c + 1)
            Else
                Console.Write(msg1)
                Console.Write(c + 1)
                Console.Write(msg2)
            End If
            array(c) = Console.ReadLine()
            Console.Clear()
            If paragemToggle = True Then
                If array(c) = paragem Then
                    skip = True
                Else
                    c += 1
                End If
            Else
                c += 1
            End If
        End While
    End Sub
    Sub ARmostrarChar(array() As Char, posicoes As Integer)
        Dim c As Byte
        For c = 0 To posicoes - 1
            Console.Write(array(c))
            Console.Write(" ")
        Next
    End Sub
    Sub ARmostrarCharAlt(array() As Char, posicoes As Integer)
        Dim c As Byte
        For c = 0 To posicoes - 1
            Console.Write(array(c))
        Next
    End Sub
    Sub ARmostrarInteger(array() As Integer, posicoes As Integer)
        Dim c As Byte
        For c = 0 To posicoes - 1
            Console.Write(array(c))
            Console.Write(" ")
        Next
    End Sub
    Function menu(nopts As Byte, opts() As String)
        Dim optquit As String = "Terminar programa"
        Dim x As Byte
        Dim c, c2 As Integer
        Dim maiorlen As Integer
        For c = 0 To nopts - 1
            If opts(c).Length() > maiorlen Then
                maiorlen = opts(c).Length()
            End If
        Next
        For c = 0 To nopts - 1
            Do
                If opts(c).Length() <= maiorlen + 1 Then
                    opts(c) = opts(c) & " "
                End If
            Loop Until opts(c).Length() = maiorlen + 2

        Next
        Console.Write("╔")
        For c2 = 0 To maiorlen + 7
            Console.Write("═")
        Next
        Console.Write("╗")
        Console.WriteLine("")
        Console.Write("║")
        For c2 = 0 To maiorlen + 7
            Console.Write(" ")
        Next
        Console.WriteLine("║")
        For c = 0 To nopts - 1
            Console.WriteLine("╠═  {0}  {1}║", c + 1, opts(c))
        Next
        Console.Write("║")
        For c2 = 0 To maiorlen + 7
            Console.Write(" ")
        Next
        Console.Write("║")
        Console.WriteLine("")
        Console.Write("╚")
        For c2 = 0 To maiorlen + 7
            Console.Write("═")
        Next
        Console.Write("╝")
        Console.WriteLine("
")
        Console.Write("Opção a selecionar: ")
        x = Console.ReadLine()
        Console.Clear()
        Return x
    End Function
    Function ARmediaInteger(array() As Integer, posicoes As Integer)
        Dim c As Integer
        Dim media As Double
        For c = 0 To posicoes - 1
            media += array(c)
        Next
        media /= posicoes
        Return media
    End Function
    Function ARmediaDouble(array() As Double, posicoes As Integer)
        Dim c As Integer
        Dim media As Double
        For c = 0 To posicoes - 1
            media += array(c)
        Next
        media /= posicoes
        Return media
    End Function
    Sub AR2pedirInteger(ByRef array(,) As Integer, posicoes1 As Integer, posicoes2 As Integer, Optional paragemToggle As Boolean = False, Optional paragem As Integer = -1, Optional msg As Boolean = True, Optional msg1 As String = vbNullString, Optional msg2 As String = vbNullString, Optional msg3 As String = vbNullString, Optional max As Integer = 32767, Optional min As Integer = -32767, Optional msgErro As String = "O valor introduzido é inválido!")
        Dim c, c2 As Integer
        Dim skip As Boolean = False
        For c2 = 0 To posicoes2 - 1
            c = 0
            While c < posicoes1 And skip = False And (array(c, c2) > min Or array(c, c2) < max)
                If msg = True Then
                    Console.Write("Introduza o valor para a {0}ª posição da {1}ª linha: ", c + 1, c2 + 1)
                Else
                    Console.Write(msg1)
                    Console.Write(c + 1)
                    Console.Write(msg2)
                    Console.Write(c2 + 1)
                    Console.Write(msg3)
                End If
                array(c, c2) = Console.ReadLine()
                Console.Clear()
                If paragemToggle = True Then
                    If array(c, c2) = paragem Then
                        skip = True
                    End If
                    If array(c, c2) < min Or array(c, c2) > max Then
                        Console.WriteLine(msgErro)
                        esperaAlt()
                    Else
                        c += 1
                    End If
                Else
                    c += 1
                End If
            End While
        Next
    End Sub
    Sub AR2pedirDouble(ByRef array(,) As Double, posicoes1 As Integer, posicoes2 As Integer, Optional paragemToggle As Boolean = False, Optional paragem As Integer = -1, Optional msg As Boolean = True, Optional msg1 As String = vbNullString, Optional msg2 As String = vbNullString, Optional msg3 As String = vbNullString, Optional max As Integer = 32767, Optional min As Integer = -32767, Optional msgErro As String = "O valor introduzido é inválido!")
        Dim c, c2 As Integer
        Dim skip As Boolean = False
        For c2 = 0 To posicoes2 - 1
            c = 0
            While c < posicoes1 And skip = False And (array(c, c2) > min Or array(c, c2) < max)
                If msg = True Then
                    Console.Write("Introduza o valor para a {0}ª posição da {1}ª linha: ", c + 1, c2 + 1)
                Else
                    Console.Write(msg1)
                    Console.Write(c + 1)
                    Console.Write(msg2)
                    Console.Write(c2 + 1)
                    Console.Write(msg3)
                End If
                array(c, c2) = Console.ReadLine()
                Console.Clear()
                If paragemToggle = True Then
                    If array(c, c2) = paragem Then
                        skip = True
                    End If
                    If array(c, c2) < min Or array(c, c2) > max Then
                        Console.WriteLine(msgErro)
                        esperaAlt()
                    Else
                        c += 1
                    End If
                Else
                    c += 1
                End If
            End While
        Next
    End Sub
    Sub AR2pedirChar(ByRef array(,) As Char, posicoes1 As Integer, posicoes2 As Integer, Optional paragemToggle As Boolean = False, Optional paragem As Char = vbNullChar, Optional msg As Boolean = True, Optional msg1 As String = vbNullString, Optional msg2 As String = vbNullString, Optional msg3 As String = vbNullString)
        Dim c, c2 As Integer
        Dim skip As Boolean = False
        For c2 = 0 To posicoes2 - 1
            c = 0
            While c < posicoes1 And skip = False
                If msg Then
                    Console.Write("Introduza o valor para a {0}ª posição da {1}ª linha: ", c + 1, c2 + 1)
                Else
                    Console.Write(msg1)
                    Console.Write(c + 1)
                    Console.Write(msg2)
                    Console.Write(c2 + 1)
                    Console.Write(msg3)
                End If
                array(c, c2) = Console.ReadLine()
                Console.Clear()
                If paragemToggle = True Then
                    If array(c, c2) = paragem Then
                        skip = True
                    Else
                        c += 1
                    End If
                Else
                    c += 1
                End If
            End While
        Next
    End Sub
    Sub AR2pedirString(ByRef array(,) As String, posicoes1 As Integer, posicoes2 As Integer, Optional paragemToggle As Boolean = False, Optional paragem As String = vbNullString, Optional msg As Boolean = True, Optional msg1 As String = vbNullString, Optional msg2 As String = vbNullString, Optional msg3 As String = vbNullString)
        Dim c, c2 As Integer
        Dim skip As Boolean = False
        For c2 = 0 To posicoes2 - 1
            c = 0
            While c < posicoes1 And skip = False
                If msg = True Then
                    Console.Write("Introduza o valor para a {0}ª posição da {1}ª linha: ", c + 1, c2 + 1)
                Else
                    Console.Write(msg1)
                    Console.Write(c + 1)
                    Console.Write(msg2)
                    Console.Write(c2 + 1)
                    Console.Write(msg3)
                End If
                array(c, c2) = Console.ReadLine()
                Console.Clear()
                If paragemToggle = True Then
                    If array(c, c2) = paragem Then
                        skip = True
                    Else
                        c += 1
                    End If
                Else
                    c += 1
                End If
            End While
        Next
    End Sub
    Sub AR2mostrarString(array(,) As String, posicoes1 As Integer, posicoes2 As Integer, Optional linha As Integer = -1, Optional coluna As Integer = -1)
        Dim c, c2 As Byte
        If linha And coluna <> -1 And linha <> -1 Then
            For c2 = 0 To posicoes2 - 1
                For c = 0 To posicoes1 - 1
                    Console.Write(array(c, c2))
                    Console.Write(" ")
                Next
            Next
        ElseIf linha <> -1 Then
            For c = 0 To posicoes2 - 1
                Console.Write(array(linha - 1, c))
                Console.Write(" ")
            Next
        ElseIf coluna <> -1 Then
            For c = 0 To posicoes1 - 1
                Console.Write(array(c, coluna - 1))
                Console.Write(" ")
            Next
        End If
    End Sub
    Sub AR2mostrarChar(array(,) As Char, posicoes1 As Integer, posicoes2 As Integer, Optional linha As Integer = -1, Optional coluna As Integer = -1)
        Dim c, c2 As Byte
        If linha And coluna <> -1 And linha <> -1 Then
            For c2 = 0 To posicoes2 - 1
                For c = 0 To posicoes1 - 1
                    Console.Write(array(c, c2))
                    Console.Write(" ")
                Next
            Next
        ElseIf linha <> -1 Then
            For c = 0 To posicoes2 - 1
                Console.Write(array(linha - 1, c))
                Console.Write(" ")
            Next
        ElseIf coluna <> -1 Then
            For c = 0 To posicoes1 - 1
                Console.Write(array(c, coluna - 1))
                Console.Write(" ")
            Next
        End If
    End Sub
    Sub AR2mostrarCharAlt(array(,) As Integer, posicoes1 As Integer, posicoes2 As Integer, Optional linha As Integer = -1, Optional coluna As Integer = -1)
        Dim c, c2 As Byte
        If linha And coluna <> -1 And linha <> -1 Then
            For c2 = 0 To posicoes2 - 1
                For c = 0 To posicoes1 - 1
                    Console.Write(array(c, c2))
                Next
            Next
        ElseIf linha <> -1 Then
            For c = 0 To posicoes2 - 1
                Console.Write(array(linha - 1, c))
            Next
        ElseIf coluna <> -1 Then
            For c = 0 To posicoes1 - 1
                Console.Write(array(c, coluna - 1))
            Next
        End If
    End Sub
    Sub AR2mostrarInteger(array(,) As Integer, posicoes1 As Integer, posicoes2 As Integer, Optional linha As Integer = -1, Optional coluna As Integer = -1)
        Dim c, c2 As Byte
        If linha And coluna <> -1 And linha <> -1 Then
            For c2 = 0 To posicoes2 - 1
                For c = 0 To posicoes1 - 1
                    Console.Write(array(c, c2))
                    Console.Write(" ")
                Next
            Next
        ElseIf linha <> -1 Then
            For c = 0 To posicoes2 - 1
                Console.Write(array(linha - 1, c))
                Console.Write(" ")
            Next
        ElseIf coluna <> -1 Then
            For c = 0 To posicoes1 - 1
                Console.Write(array(c, coluna - 1))
                Console.Write(" ")
            Next
        End If
    End Sub
    Sub AR2mostrarDouble(array(,) As Double, posicoes1 As Integer, posicoes2 As Integer, Optional linha As Integer = -1, Optional coluna As Integer = -1)
        Dim c, c2 As Byte
        If linha And coluna <> -1 And linha <> -1 Then
            For c2 = 0 To posicoes2 - 1
                For c = 0 To posicoes1 - 1
                    Console.Write(array(c, c2))
                    Console.Write(" ")
                Next
            Next
        ElseIf linha <> -1 Then
            For c = 0 To posicoes2 - 1
                Console.Write(array(linha - 1, c))
                Console.Write(" ")
            Next
        ElseIf coluna <> -1 Then
            For c = 0 To posicoes1 - 1
                Console.Write(array(c, coluna - 1))
                Console.Write(" ")
            Next
        End If
    End Sub
    Function AR2mediaDouble(array(,) As Double, posicoes1 As Integer, posicoes2 As Integer, Optional somaToggle As Boolean = False, Optional linha As Integer = -1, Optional coluna As Integer = -1)
        Dim c, c2 As Byte
        Dim media As Double
        If linha And coluna <> -1 And linha <> -1 Then
            For c2 = 0 To posicoes2 - 1
                For c = 0 To posicoes1 - 1
                    media += array(c, c2)
                Next
            Next
        ElseIf linha <> -1 Then
            For c = 0 To posicoes2 - 1
                media += array(linha - 1, c)
            Next
        ElseIf coluna <> -1 Then
            For c = 0 To posicoes1 - 1
                media += array(c, coluna - 1)
            Next
        End If
        If Not somaToggle Then
            media /= (posicoes1 * posicoes2)
        End If
        Return media
    End Function
    Function AR2mediaInteger(array(,) As Integer, posicoes1 As Integer, posicoes2 As Integer, Optional somaToggle As Boolean = False, Optional linha As Integer = -1, Optional coluna As Integer = -1)
        Dim c, c2 As Byte
        Dim media As Double
        If linha And coluna <> -1 And linha <> -1 Then
            For c2 = 0 To posicoes2 - 1
                For c = 0 To posicoes1 - 1
                    media += array(c, c2)
                Next
            Next
        ElseIf linha <> -1 Then
            For c = 0 To posicoes2 - 1
                media += array(linha - 1, c)
            Next
        ElseIf coluna <> -1 Then
            For c = 0 To posicoes1 - 1
                media += array(c, coluna - 1)
            Next
        End If
        If Not somaToggle Then
            If linha = -1 And coluna = -1 Then
                media /= (posicoes1 * posicoes2)
            ElseIf linha <> -1 Then
                media /= posicoes2
            ElseIf coluna <> -1 Then
                media /= posicoes1
            End If
        End If
        Return media
    End Function
    Sub AR2MaiorMenor(array(,) As Integer, ByRef maior As Integer, ByRef menor As Integer, posicoes1 As Integer, posicoes2 As Integer, Optional coords As Boolean = False, Optional ByRef cmaior As Integer = -1, Optional ByRef cmenor As Integer = -1, Optional ByRef lmaior As Integer = -1, Optional ByRef lmenor As Integer = -1)
        Dim c, c2 As Integer
        maior = array(0, 0)
        menor = array(0, 0)
        If coords Then
            For c2 = 0 To posicoes2 - 1
                For c = 0 To posicoes1 - 1
                    If array(c, c2) > maior Then
                        maior = array(c, c2)
                        lmaior = c
                        cmaior = c2
                    End If
                    If array(c, c2) < menor Then
                        menor = array(c, c2)
                        cmenor = c2
                        lmenor = c
                    End If
                Next
            Next
        Else
            For c2 = 0 To posicoes2 - 1
                For c = 0 To posicoes1 - 1
                    If array(c, c2) > maior Then
                        maior = array(c, c2)
                    End If
                    If array(c, c2) < menor Then
                        menor = array(c, c2)
                    End If
                Next
            Next
        End If
    End Sub
    Sub AR2diagonal(array(,) As Integer, posicoes As Integer, Optional secundariaToggle As Boolean = False, Optional modif As Integer = 0)
        Dim c As Integer
        If Not secundariaToggle Then
            For c = 0 + modif To posicoes - 1
                If c < 0 Then
                    c = 1
                End If
                If c > posicoes - 1 Then
                    c = posicoes - 1
                End If
                Console.Write(array(c, c) & " ")
            Next
        Else
            For c = 0 + modif To posicoes - 1
                If c < 0 Then
                    c = 1
                End If
                If c > posicoes - 1 Then
                    c = posicoes - 1
                End If
                Console.Write(array(c, (posicoes - 1 - c)) & " ")
            Next
        End If
    End Sub

    Sub melhores(notas(,) As Double, nomes() As String)
        Dim l, c As Integer
        Dim maior_1, maior_2, maior_3
        Dim maior1, maior2, maior3 As String

        For l = 0 To 6
            For c = 0 To 9
                If notas(l, c) > maior_1 Then
                    maior1 = nomes(c)

                End If
                If notas(l, c) > maior_2 And notas(l, c) < maior1 Then
                    maior2 = nomes(c)
                End If
                If notas(l, c) > maior_3 And notas(l, c) < maior2 Then
                    maior3 = nomes(c)
                End If
            Next
        Next
        Console.WriteLine("Os 3 melhores alunos são:{0},{1},{2}", maior1, maior2, maior3)

    End Sub

    Sub vintes(nomes() As String, notas(,) As Double, disciplinas() As String)
        Dim l, c As Integer

        For l = 0 To 6
            For c = 0 To 9
                If notas(l, c) = 20 Then
                    Console.WriteLine("O aluno" & nomes(c) & "teve 20 a " & disciplinas(l) & ".")
                End If
            Next
        Next

    End Sub
    Sub contar_maiorMenor(ByRef c As Integer, repeticoes As Integer, opc As String, Optional maior As Integer = 32767, Optional menor As Integer = -32767)
        Dim c_maior As Integer = 0
        Dim c_menor As Integer = 0
        Dim i As Integer
        Dim num As Integer



        For i = 0 To repeticoes - 1
            num = pedirInteger()
            If num > maior Then
                c_maior += 1
            End If
            If num < menor Then
                c_menor += 1
            End If
        Next



        If opc = "maior" Then
            c = c_maior
        Else
            If opc = "menor" Then
                c = c_menor
            End If
        End If
    End Sub

    Sub menu_f27(ByRef opt As Byte)
        Console.WriteLine("1 - Leitura de um Nome:")
        Console.WriteLine("2 -  Inserir um sobrenome:")
        Console.WriteLine("3 - Passar para Maiusculas:")
        Console.WriteLine("4 - Colocar o nome na ordem inversa:")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine("5 -SAIR")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine("Prima uma tecla:_")
        opt = Console.ReadLine()



    End Sub


    Sub menu_f28ex1(ByRef opt As Byte)

        Console.WriteLine("1 - Inserção de três frases:")
        Console.WriteLine("2 - Comparação entre frases:")
        Console.WriteLine("3 - Frase com mais caracteres:")
        Console.WriteLine("4 - Frase com mais vogais:")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine("5 -SAIR")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine("Prima uma tecla:_")
        opt = Console.ReadLine()



    End Sub


End Module
