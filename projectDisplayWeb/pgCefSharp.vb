Imports CefSharp
Imports CefSharp.WinForms

Public Class pgCefSharp

    Private browser As ChromiumWebBrowser

    Private Sub pgCefSharp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Optional: Add a label below the browser
        Dim label As New Label()
        label.Text = "CerfSharp Import"
        label.Font = New Font("Arial", 16, FontStyle.Bold)
        label.Location = New Point(50, 10)              ' Position the label
        label.AutoSize = True
        Me.Controls.Add(label)

        ' Optional: Add a label below the browser
        Dim label1 As New Label()
        label1.Text = "An embedded Google search engine."
        label1.Location = New Point(50, 550)              ' Position the label
        label1.AutoSize = True
        Me.Controls.Add(label1)

        ' Initialize the form properties
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen  ' Center the form
        Me.Size = New Size(800, 600)                      ' Fixed form size
        Me.FormBorderStyle = FormBorderStyle.FixedDialog  ' Prevent resizing
        Me.MaximizeBox = False                            ' Disable maximize button
        Me.MinimizeBox = False                            ' Disable minimize button

        ' Initialize the browser and set its layout
        browser = New ChromiumWebBrowser("https://www.google.com")
        browser.Size = New Size(700, 400)                 ' Set browser size smaller than the form
        browser.Location = New Point(50, 50)             ' Set browser position within the form
        browser.Anchor = AnchorStyles.Top Or AnchorStyles.Left  ' Prevent auto-resizing with form
        browser.Dock = DockStyle.None                    ' Ensure the browser doesn't dock to the form

        ' Add the browser to the form
        Me.Controls.Add(browser)

    End Sub
End Class