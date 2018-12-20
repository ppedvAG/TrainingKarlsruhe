Public Class Form17
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Umlaute(TextBox1.Text)
    End Sub

    Function Umlaute(zeichen As String) As String
        Dim a() = {"1", "2", "3"}

        Dim UmlauteErsetzung(6, 1) As String
        UmlauteErsetzung = {
            {"Ö", "Oe"},
            {"ö", "oe"},
            {"Ä", "Ae"},
            {"ä", "ae"},
            {"Ü", "Ue"},
            {"ü", "ue"},
            {"ß", "ss"}}
        'UmlauteErsetzung(0, 0) = "Ö"
        'UmlauteErsetzung(0, 1) = "OE"

        For index = 0 To 6
            zeichen = zeichen.Replace(UmlauteErsetzung(index, 0),
                                      UmlauteErsetzung(index, 1))

        Next



        'zeichen = zeichen.Replace("Ö", "OE")
        'zeichen = zeichen.Replace("Ä", "AE")
        'zeichen = zeichen.Replace("Ü", "UE")
        'zeichen = zeichen.Replace("ß", "SS")


        Return zeichen
    End Function
End Class