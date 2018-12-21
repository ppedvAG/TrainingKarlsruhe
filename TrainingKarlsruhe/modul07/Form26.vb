Public Class Form26
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim s As String
        'Dim auto As New kfz3()
        'Dim d As Date
        'd = Date.Now

        'Dim lotto = New kifz4
        'lotto.aktuelleLottoZahl = lotto.neueLottozahl()

        'Label1.Text = lotto.aktuelleLottoZahl.ToString


        Label1.Text = kifz4.neueLottozahl().ToString
    End Sub
End Class


