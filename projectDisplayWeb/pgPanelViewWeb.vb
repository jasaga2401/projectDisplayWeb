Public Class pgPanelViewWeb
    Private Sub lblOpenWebPage_Click(sender As Object, e As EventArgs) Handles lblOpenWebPage.Click

        Process.Start("https://www.google.com")

    End Sub

    Private Sub lblNext_Click(sender As Object, e As EventArgs) Handles lblNext.Click

        pgWebHTMLContent.Show()
        Me.Hide()

    End Sub


End Class