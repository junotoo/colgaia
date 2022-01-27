Module creme
    Function pedirString(Optional msg As String = "Introduza o seu nome: ")
        Dim a As String
        Console.WriteLine(msg)
        a = Console.ReadLine()
        Return a
    End Function

    Function pedirinteger(Optional msg As String = "Introduza um numero inteiro: ", Optional max As Integer = Nothing, Optional min As Integer = Nothing)
        Dim num As Integer
        Dim flag As Boolean
        Do
            Console.Writeline(msg)
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
End Module

