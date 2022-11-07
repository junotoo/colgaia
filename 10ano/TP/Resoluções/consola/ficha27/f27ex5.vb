Module f27ex5
    Sub Main(args As String())
        Dim opt As Byte
        Dim nome As String
        Dim sobrenome As String

        Do
            menu_f27(opt)
            esperaAlt()

            Select Case opt
                Case 1
                    Console.WriteLine("Insira um nome:")
                    nome = Console.ReadLine()
                Case 2
                    Console.WriteLine("Insira um Sobrenome:")
                    sobrenome = Console.ReadLine()
                Case 3
                    Console.WriteLine(UCase(nome) & " " & UCase(sobrenome))
                Case 4
                    Console.WriteLine(StrReverse(nome) & " " & StrReverse(sobrenome))

            End Select

            esperaAlt()
        Loop Until opt = 5

    End Sub
End Module
