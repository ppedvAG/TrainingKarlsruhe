Public Class Form18
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        If CInt(TextBox1.Text) = Anrede.Herr Then
            'dann ist das mann
            Dim int = Anrede.Herr 'integer wert
            Dim str = Anrede.Herr.ToString 'Zeichenkette

        End If

        If ComboBox1.SelectedIndex = Anrede.Hallo Then
            MessageBox.Show("Hallo Herrt ")
        End If

    End Sub

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim a As Array       ' ala Dim a(9) nur beliebig groß
        a = System.Enum.GetValues(GetType(Anrede))
        ComboBox1.DataSource = a

    End Sub

    Enum Anrede
        Herr = 0
        Frau = 1
        Hallo = 2
    End Enum
End Class