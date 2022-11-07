Module f23ex6
    Sub Main(args As String())
        Dim crt As Char
        Dim vog As Byte = 0
        Dim nums As Byte = 0
        Dim pont As Byte = 0
        Dim outros As Byte = 0
        While crt <> " "
            crt = pedirChar()
            Select Case crt
                Case "a", "e", "i", "o", "u"
                    vog += 1
                Case "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"
                    nums += 1
                Case ":", ".", ",", ";", "!", "?"
                    pont += 1
                Case " "
                Case Else
                    outros += 1
            End Select
        End While
        writeAlt("Dos carateres lidos, " & vog & " eram vogais, " & nums & " eram dígitos, " & pont & " eram carateres de pontuação e " & outros & " eram outros.")
    End Sub
End Module
