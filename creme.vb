Module creme
    Function pedirString(Optional msg As String = "Introduza o seu nome: ")
        Dim a As String
        Console.WriteLine(msg)
        a = Console.ReadLine()
        Console.Clear()
        Return a
    End Function

    Function pedirInteger(Optional msg As String = "Introduza um numero inteiro: ", Optional max As Integer = Nothing, Optional min As Integer = Nothing)
        Dim num As Integer
        Dim flag As Boolean
        Do
            Console.WriteLine(msg)
            num = Console.ReadLine
            If num > max Or num < min Then
                flag = False
                Console.WriteLine("O número introduzido é inválido!")
                Console.WriteLine("Pressione qualquer tecla para continuar...")
                Console.ReadKey()
                Console.Clear()
            Else
                flag = True
            End If
        Loop Until flag = False
        Return num
    End Function
    Function media(numelementos As Byte, val1 As Double, val2 As Double, Optional val3 As Double = Nothing, Optional val4 As Double = Nothing)
        Dim med As Double
        med = ((val1 + val2 + val3 + val4) / numelementos)
        Return med
    End Function
    Sub espera()
        Console.WriteLine("Pressione qualquer tecla para continuar...")
        Console.ReadKey()
    End Sub
    Sub esperaAlt()
        Console.WriteLine("Pressione qualquer tecla para continuar...")
        Console.ReadKey()
        Console.Clear()
    End Sub
End Module

