Public Class pgWebHTMLContent
    Private Sub pgWebHTMLContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WebBrowser2.DocumentText = "<html><body><h1>Hello World!</h1></body></html>"

    End Sub
End Class