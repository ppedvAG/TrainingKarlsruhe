Public Class kifz4
    Public Shared letzteZufallszahl As Integer
    Public aktuelleLottoZahl As Integer
    Public Shared Function neueLottozahl() As Integer

        Return CInt(Rnd() * 49)
    End Function
End Class
