Imports System.IO

Public Class Form28
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        File.AppendAllText("c:\temp\log.txt", Date.Now.ToString + System.Environment.NewLine)
    End Sub
End Class