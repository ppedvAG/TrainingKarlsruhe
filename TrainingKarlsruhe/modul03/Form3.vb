Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim zeichenkette As String
        zeichenkette = "     Hallo Welt
                        hier bin ich      "

        ' Dim reverseZeichenkette = zeichenkette.Replace("i", "00")

        'Dim pos = zeichenkette.IndexOf("i")

        'Label1.Text = pos.ToString


        ' Label1.Text = CStr(CInt(TextBox1.Text) + CInt(TextBox2.Text))
        ' Label1.Text = (CInt(TextBox1.Text) + CInt(TextBox2.Text)).ToString

        'Integer.Parse(TextBox1.Text)
        'Convert.ToInt64(TextBox1.Text)

        Label1.Text = CType(zeichenkette.Reverse, String)

    End Sub


End Class