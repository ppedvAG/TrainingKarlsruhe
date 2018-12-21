Public Class Form27
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '  On Error GoTo fehler
        Try
            Try
                Dim o As Integer
                o = Integer.MaxValue
                o = o + 1
            Catch
            End Try



            Dim a(5) As String
                For index = 1 To 10
                    a(index) = Rnd.ToString
                Next

            Catch ex As OverflowException
                ' MessageBox.Show("dramatic Error" + ex.HResult.ToString)

            Catch ex As Exception
                MessageBox.Show("Hinweis: Programm hat intern folgenden fehler, dwen wir natürlich behoben haben" + ex.Message)


        End Try

        Dim x = 0






        'fehler:
        '        MessageBox.Show("Fehler")

    End Sub
End Class