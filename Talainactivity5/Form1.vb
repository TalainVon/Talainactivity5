Imports System.Linq.Expressions

Public Class Form1
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim a As Integer
            Dim b As Integer
            a = Txtbox1.Text
            b = Txtbox2.Text
            Txtbox3.Text = a / b
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
End Class
