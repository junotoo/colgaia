Module f21ex3



    Sub Main(args As String())



        Dim moeda(14), tipo_de_moeda(14), val As Double



        Console.OutputEncoding = System.Text.Encoding.UTF8



        'Input
        Do
            Console.Write("Introduza o valor monetário que deseja converter: ")
            val = Console.ReadLine
            If val <= 0 Then
                Console.WriteLine("Valor incorreto! Tem que ser maior do que 0")
                Console.WriteLine("Prima qualquer tecla para continuar")
                Console.ReadKey()
            End If
            Console.Clear()
        Loop While val <= 0



        val *= 100



        Do
            Select Case val
                Case >= 50000
                    moeda(14) = val \ 50000
                    val = val Mod 50000
                    tipo_de_moeda(14) = 500
                Case >= 20000
                    moeda(13) = val \ 20000
                    val = val Mod 20000
                    tipo_de_moeda(13) = 200
                Case >= 10000
                    moeda(12) = val \ 10000
                    val = val Mod 10000
                    tipo_de_moeda(12) = 100
                Case >= 5000
                    moeda(11) = val \ 5000
                    val = val Mod 5000
                    tipo_de_moeda(11) = 50
                Case >= 2000
                    moeda(10) = val \ 2000
                    val = val Mod 2000
                    tipo_de_moeda(10) = 20
                Case >= 1000
                    moeda(9) = val \ 1000
                    val = val Mod 1000
                    tipo_de_moeda(9) = 10
                Case >= 500
                    moeda(8) = val \ 500
                    val = val Mod 500
                    tipo_de_moeda(8) = 5
                Case >= 200
                    moeda(7) = val \ 200
                    val = val Mod 200
                    tipo_de_moeda(7) = 2
                Case >= 100
                    moeda(6) = val \ 100
                    val = val Mod 100
                    tipo_de_moeda(6) = 1
                Case >= 50
                    moeda(5) = val \ 50
                    val = val Mod 50
                    tipo_de_moeda(5) = 0.5
                Case >= 20
                    moeda(4) = val \ 20
                    val = val Mod 20
                    tipo_de_moeda(4) = 0.2
                Case >= 10
                    moeda(3) = val \ 10
                    val = val Mod 10
                    tipo_de_moeda(3) = 0.1
                Case >= 5
                    moeda(2) = val \ 5
                    val = val Mod 5
                    tipo_de_moeda(2) = 0.05
                Case >= 2
                    moeda(1) = val \ 2
                    val = val Mod 2
                    tipo_de_moeda(1) = 0.02
                Case >= 1
                    moeda(0) = val \ 1
                    val = val Mod 1
                    tipo_de_moeda(0) = 0.01
            End Select
        Loop While val <> 0




        Console.Write("São necessárias ")
        For i = 14 To 0 Step -1
            If tipo_de_moeda(i) <> 0 Then
                If tipo_de_moeda(i) >= 5 Then
                    Console.WriteLine("{0} notas de {1}€", moeda(i), tipo_de_moeda(i))
                Else
                    Console.WriteLine("{0} moedas de {1}€", moeda(i), tipo_de_moeda(i))
                End If
            End If
        Next



        Console.WriteLine("Prima qualquer tecla para continuar...")
        Console.ReadKey()



    End Sub



End Module
