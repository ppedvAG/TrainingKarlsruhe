Public Class Form13
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hannes As Integer
        hannes = 1
        Dim hannestring As String = CStr(hannes)

        Dim hannes2 = 1
        Dim arr(9) As String
        arr(0) = "Hannes"

        If IsNothing(arr(1)) Then
            arr(1) = "Preishuber"
        Else

        End If

        Select Case hannes
            Case 1

            Case 2

            Case Else

        End Select
        For index = 1 To 10

        Next

    End Sub
End Class