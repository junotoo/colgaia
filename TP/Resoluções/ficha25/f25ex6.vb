Module f25ex6
    Sub Main(args As String())
        Dim opt As Byte
        Dim array(10) As Integer
        Dim lido As Boolean = False
        Dim quit As Boolean = False
        While quit = False
            Console.Clear()
            opt = menu(4, {"Leitura de 10 valores", "Mostrar valores", "Inverter Valores", "Média"})
            Select Case opt
                Case 1
                    ARpedirInteger(array, 10)
                    lido = True
                Case 2
                    If lido Then
                        ARmostrarInteger(array, 10)
                    Else
                        Console.WriteLine("Tem de efetuar a leitura dos valores primeiro!")
                    End If

                Case 3
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
                    array.Reverse(array)
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
                    Console.WriteLine("Valores Invertidos!")
                Case 4
                    Console.WriteLine("A média dos valores introduzidos é {0}.", ARmediaInteger(array, 10))
                Case 0
                    quit = True
                Case Else
                    Console.WriteLine("A opção escolhida não pertence ao menu, escolha novamente...")
            End Select
            esperaAlt()
        End While
    End Sub
End Module