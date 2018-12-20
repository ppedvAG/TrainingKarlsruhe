Public Class Form20
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim umlauteListe As New Dictionary(Of String, String) From
            {
            {"Ö", "Oe"},
            {"ö", "oe"},
            {"Ä", "Ae"},
            {"ä", "ae"},
            {"Ü", "Ue"},
            {"ü", "ue"},
            {"ß", "ss"}}

        umlauteListe.Item("ä") = "Rainer"
        'kurzform         umlauteListe("ä")

        '        umlauteListe.Add("Ö", "OE")
        ' umlauteListe.Count
        For Each item In umlauteListe
            Dim x = item.Key + " " + item.Value
        Next



        Dim UmlauteErsetzung(6, 1) As String
        UmlauteErsetzung = {
            {"Ö", "Oe"},
            {"ö", "oe"},
            {"Ä", "Ae"},
            {"ä", "ae"},
            {"Ü", "Ue"},
            {"ü", "ue"},
            {"ß", "ss"}}


        UmlauteErsetzung(3, 1) = "Rainer"
        ' UmlauteErsetzung.Length
        For Each item In UmlauteErsetzung
            Dim x = item(0) + " " + item(1)
        Next
    End Sub
End Class