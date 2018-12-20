Public Class KFZ
    Public fahrgestellnummer As Integer

    Public farbe As Color
    Public tuev As Boolean
    Public Bildpfad As String
    Private _hersteller As String
    Public Property Hersteller() As String
        Get
            Return _hersteller
        End Get
        Set(ByVal value As String)
            _hersteller = value
            If _hersteller = "BMW" Then
                Bildpfad = "bmw.png"
            Else
                Bildpfad = "auto.jpg"
            End If
        End Set
    End Property

End Class
