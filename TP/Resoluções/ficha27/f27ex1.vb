Module f27ex1
    Sub Main(args As String())
        Const senha = "senha"
        Dim insertpass As String


        Do
            Console.WriteLine("Insira a sua password:_")
            insertpass = Console.ReadLine()
            If insertpass = "senha" Then
                Console.WriteLine("Utilizador Autorizado!!!")
            Else
                Console.WriteLine("Utilizador Bloqueado!!!")
            End If
            esperaAlt()

        Loop Until insertpass = "senha"
        esperaAlt()

    End Sub

End Module
