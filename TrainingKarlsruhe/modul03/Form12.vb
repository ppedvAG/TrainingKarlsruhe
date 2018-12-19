Public Class Form12

    Dim a(6) As Date
    Dim clickcount As Integer = 0
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        a(clickcount) = Date.Now
        clickcount += 1
        If clickcount >= a.Length Then
            ReDim Preserve a(a.Length + 12)
        End If
        ListBox1.DataSource = a


        'Dim aa As New ArrayList


        'For index = 1 To a.Length

        'Next
        For Each franz As Date In a
            Debug.WriteLine(franz)
        Next


    End Sub
End Class