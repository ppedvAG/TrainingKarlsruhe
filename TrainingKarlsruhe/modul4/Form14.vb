Public Class Form14
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'halber Weihnachtsbaum
        Dim baum(9) As String
        Dim vieleSternchen = "***********"
        For schleifenzähler = 0 To 9
            If schleifenzähler < 7 Then
                baum(schleifenzähler) = vieleSternchen.Substring(0, schleifenzähler + 1)
            Else
                baum(schleifenzähler) = "*"
            End If


        Next
        ListBox1.DataSource = baum
    End Sub
End Class
'0 *
'1 **
'2 ***
'3
'4



'**********
'Substring(start, wieviel)