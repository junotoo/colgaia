Module f24ex2
    Sub Main(args As String())
        Dim nome As String
        Dim valor As Double
        Dim c As Byte
        For c = 1 To 15
            nome = pedirString()
            valor = pedirDouble("Introduza o valor das suas compras no ano passado: ", , 0)
            If valor > 1000 Then
                Console.WriteLine("Tem direito a um bônus de 15%")
                esperaAlt()
            Else
                Console.WriteLine("Tem direito a um bônus de 10%")
                esperaAlt()
            End If
        Next
        esperaAlt()
    End Sub
End Module
