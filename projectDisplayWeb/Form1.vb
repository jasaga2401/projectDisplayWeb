Imports Microsoft.Web.WebView2.Core

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set the source after the control is potentially loaded
        WebView21.Source = New Uri("https://www.google.com")

    End Sub

    Private Async Sub WebView21_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles WebView21.NavigationCompleted

        If e.IsSuccess Then ' Check for successful navigation
            Dim script As String = "document.documentElement.style.width = '100%'; document.documentElement.style.height = '100%';"
            Await WebView21.CoreWebView2.ExecuteScriptAsync(script)
        End If
    End Sub

    Private Sub lblNext_Click(sender As Object, e As EventArgs) Handles lblNext.Click

        pgOldBrowser.Show()
        Me.Hide()

    End Sub
End Class
