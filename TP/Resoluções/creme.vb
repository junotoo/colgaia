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
        While num > min And num < max
            Console.Write(msg)
            num = Console.ReadLine
            If num > max Or num < min Then
                Console.WriteLine(msgErro)
                esperaAlt()
            End If
        End While
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
            End If
            If array(c) < min Or array(c) > max Then
                    Console.WriteLine(msgErro)
                    esperaAlt()
                Else
                    c += 1
                End If
        End While
    End Sub
    Sub ARpedirChar(ByRef array() As Char, posicoes As Integer, Optional paragemToggle As Boolean = False, Optional paragem As Char = vbNullChar, Optional msg As Boolean = True, Optional msg1 As String = vbNullString, Optional msg2 As String = vbNullString)
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
            End If
        End While
    End Sub
End Module


