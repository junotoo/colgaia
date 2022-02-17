Module f27ex1
    Sub Main(args As String())
        Dim senha = "senha"
        Dim insertpass As String
        Do
            insertpass = pedirString("Insira a sua palavra passe: ")
            If insertpass = senha Then
                Console.WriteLine("Utilizador Autorizado!!!")
            Else
                Console.WriteLine("Utilizador Bloqueado!!!")
            End If
            esperaAlt()
        Loop Until insertpass = senha
        esperaAlt()

    End Sub

End Module
