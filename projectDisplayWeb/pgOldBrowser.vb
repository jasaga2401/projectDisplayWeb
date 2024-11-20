Public Class pgOldBrowser
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub pgOldBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Navigate to a specific URL
        WebBrowser1.Navigate("https://www.google.com")

    End Sub

    Private Sub lblNext_Click(sender As Object, e As EventArgs) Handles lblNext.Click

        pgPanelViewWeb.Show()
        Me.Hide()

    End Sub
End Class