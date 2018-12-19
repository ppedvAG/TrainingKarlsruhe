Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Quersumme
        '  Dim counter = 4
        Dim zahl = "1234567890"
        'If counter < zahl.Length Then
        '    counter += 1   '=+ ACHTUNG
        '    ' counter = counter + 1
        'ElseIf counter = 4 And zahl <> "1234" Then
        '    'mach was anderes
        '    Dim xhannes = 0
        'Else
        '    'ende
        'End If
        'If zahl.Substring(0, 4) = "1234" Then
        '    Dim xhannes = 0
        'End If
        Dim quer As Integer = 0
        For index = 1 To zahl.Length
            quer += CInt(zahl.Substring(index - 1, 1))
            If quer > 99 Then
                Exit For
            End If
            Dim x = 0
        Next

        'For index = 0 To zahl.Length - 1
        '    zahl.Substring(index, 1)


    End Sub
End Class