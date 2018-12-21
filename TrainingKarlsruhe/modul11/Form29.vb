Public Class Form29

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Form29_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Interval = 1000
        AddHandler Timer1.Tick, AddressOf Ticken
    End Sub

    Private Sub bewegung(sender As Object, e As MouseEventArgs)
        Label2.Text = e.Location.X.ToString + ":" + e.Location.Y.ToString
    End Sub

    Public Sub Ticken(sender As Object, e As EventArgs)
        Label1.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        RemoveHandler Timer1.Tick, AddressOf Ticken

        AddHandler Panel1.MouseMove, AddressOf bewegung
    End Sub


End Class