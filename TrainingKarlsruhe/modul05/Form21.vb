Public Class Form21
    Dim NamensListe As New Dictionary(Of String, String)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Key Value
        If Not NamensListe.ContainsKey(TextBox1.Text) Then
            NamensListe.Add(TextBox1.Text,
                        TextBox1.Text)
            refreshListbox1()
        Else
            MessageBox.Show("schon hinzugefügt")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Unbekannter Typ aus Liste muss umgewandelt werden in identen typ von Namensliste (string,string)
        Dim selektiert = CType(ListBox1.SelectedItem, KeyValuePair(Of String, String)).Value

        NamensListe.Remove(selektiert)
        refreshListbox1()
    End Sub
    Sub refreshListbox1()
        'Winforms Thema 
        ListBox1.DataSource = New BindingSource(NamensListe, Nothing)
        ListBox1.DisplayMember = "Value"
        ListBox1.ValueMember = "Key"
    End Sub
End Class