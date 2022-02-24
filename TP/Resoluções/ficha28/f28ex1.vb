Module f28ex1
    Sub Main(args As String())
        Dim opt As Byte
        Dim frase1, frase2, frase3 As String

        Do
            menu_f28ex1(opt)
            Console.Clear()

            Select Case opt
                Case 1
                    Console.WriteLine("Insira três frases:")
                    frase1 = Console.ReadLine()
                    frase2 = Console.ReadLine()
                    frase3 = Console.ReadLine()
                Case 2
                    If frase1 = frase2 Or frase1 = frase3 Or frase2 = frase3 Then
                        Console.WriteLine("Existem frases iguais.")


                    End If

            End Select







        Loop



    End Sub

End Module
