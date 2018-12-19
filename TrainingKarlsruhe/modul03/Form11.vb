Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Int16 = 1
        Dim ii As Int16 = 1
        While i > 3000
            i += ii
        End While




        Do
            i += ii
        Loop Until i > 3000

        While True
            If i > 3000 Then
                Exit While
            End If

        End While


        'For i = 1 To 10

        'Next
    End Sub
End Class