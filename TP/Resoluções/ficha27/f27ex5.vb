Module f27ex5
    Sub Main(args As String())
        Dim opt As Byte = 9
        Dim nome As String
        Dim lido As Boolean = False
        While opt <> 0
            opt = menu(5, {"Leitura de um nome.", "Inserir um sobrenome.", "Passar para maiúsculas.", "Colocar o nome na ordem inversa.", "Mostrar nome"})
            Select Case opt
                Case 1
                    nome = pedirString()
                    lido = True
                Case 2
                    If lido Then
                        nome &= " " & pedirString("Introduza o sobrenome: ")
                    Else
                        Console.WriteLine("Precisa de introduzir o nome primeiro...")
                    End If
                    esperaAlt()
                Case 3
                    If lido Then
                        nome = LCase(nome)
                        Console.WriteLine("Foi passado para maiusculas.")
                    Else
                        Console.WriteLine("Precisa de introduzir o nome primeiro...")
                    End If
                    esperaAlt()
                Case 4
                    If lido Then
                        nome = StrReverse(nome)
                        Console.WriteLine("O nome foi colocado na ordem inversa.")
                    Else
                        Console.WriteLine("Precisa de introduzir o nome primeiro...")
                    End If
                    esperaAlt()
                Case 5
                    If lido Then
                        Console.WriteLine(nome)
                    Else
                        Console.WriteLine("Precisa de introduzir o nome primeiro...")
                    End If
                    esperaAlt()
            End Select
        End While
    End Sub
End Module
