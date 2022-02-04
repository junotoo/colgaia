Module creme
    Function pedirString(Optional msg As String = "Introduza o seu nome: ")
        Dim a As String
        Console.Write(msg)
        a = Console.ReadLine()
        Console.Clear()
        Return a
    End Function

    Function pedirInteger(Optional msg As String = "Introduza um numero inteiro: ", Optional max As Integer = 32767, Optional min As Integer = -32767)
        Dim num As Integer
        Dim flag As Boolean
        Do
            Console.Write(msg)
            num = Console.ReadLine
            Console.Clear()
            If num > max Or num < min Then
                flag = False
                Console.WriteLine("O número introduzido é inválido!")
                Console.WriteLine("Pressione qualquer tecla para continuar...")
                Console.ReadKey()
                Console.Clear()
            Else
                flag = True
            End If
        Loop Until flag = True
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
    Function pedirDouble(Optional msg As String = "Introduza um numero inteiro: ", Optional max As Double = 1.7976931348623157E+308, Optional min As Double = -1.7976931348623157E+308)
        Dim num As Integer
        Dim flag As Boolean
        Do
            Console.Write(msg)
            num = Console.ReadLine
            If num > max Or num < min Then
                flag = False
                Console.WriteLine("O número introduzido é inválido!")
                esperaAlt()
            Else
                flag = True
            End If
        Loop Until flag = True
        Return num
    End Function
    Function numsPares(num As Integer)
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
End Module

