Public Class kfz3
    Public fahrgestellnummer As String

    Public farbe As Color
    Public tuev As Boolean
    Public Bildpfad As String

    Public Hersteller As String
    Sub New() 'Konstruktor

    End Sub
    Public Sub New(hersteller As String) 'Konstruktor Überladen
        Me.Hersteller = hersteller
        Dim s = CInt(Rnd() * 1000).ToString("D7")
        Select Case hersteller
            Case "BMW"
                fahrgestellnummer = "YK" + s
            Case "VW"
                fahrgestellnummer = "AB" + s
            Case Else
                fahrgestellnummer = "ZZ" + s
        End Select
    End Sub
End Class
