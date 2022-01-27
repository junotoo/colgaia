Module creme
    Function pedirString(Optional msg As String = "Introduza o seu nome: ")
        Dim a As String
        Console.WriteLine(msg)
        a = Console.ReadLine()
        Return a
    End Function
End Module
