Public Class kfz2
    Public fahrgestellnummer As String

    Public farbe As Color
    Public tuev As Boolean
    Public Bildpfad As String

    Public Hersteller As String
    Public Sub GeneriereFahrgestellnummer()
        Dim s = CInt(Rnd() * 1000).ToString("D7") '(7 stellen führende 0)
        Select Case Hersteller
            Case "BMW"
                fahrgestellnummer = "YK" + s    'drinnen "YK{i:D7}" blöd weil immer wieder, deswegen tostring (D7
            Case "VW"
                fahrgestellnummer = "AB" + s
            Case Else
                fahrgestellnummer = "ZZ" + s
        End Select
    End Sub
End Class
