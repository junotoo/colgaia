Module f21ex2
    Sub Main(args As String())
        Dim vogal As Char
        Dim bool As Boolean
        Do
            Console.Write("Introduza a vogal em minusculo: ")
            vogal = Console.ReadLine()
            bool = 0
            Console.Clear()

            Select Case vogal
                Case "a"
                    Console.WriteLine(“A")
                Case "e"
                    Console.WriteLine(“E")
                Case "i"
                    Console.WriteLine(“I")
                Case "o"
                    Console.WriteLine(“O")
                Case "u"
                    Console.WriteLine("U")
                Case Else
                    Console.WriteLine("O carater introduzido esta errado")
                    Console.WriteLine("Prima qualquer tecla para continuar...")
                    Console.ReadKey()
                    Console.Clear()
                    bool = 1
            End Select
        Loop Until bool = 0
        Console.WriteLine("Prima qualquer tecla para continuar...")
        Console.ReadKey()
    End Sub
End Module
