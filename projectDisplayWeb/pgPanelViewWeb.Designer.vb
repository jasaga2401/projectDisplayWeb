<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pgPanelViewWeb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblOpenWebPage = New System.Windows.Forms.Label()
        Me.lblNext = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblOpenWebPage
        '
        Me.lblOpenWebPage.AutoSize = True
        Me.lblOpenWebPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenWebPage.Location = New System.Drawing.Point(364, 274)
        Me.lblOpenWebPage.Name = "lblOpenWebPage"
        Me.lblOpenWebPage.Size = New System.Drawing.Size(192, 29)
        Me.lblOpenWebPage.TabIndex = 0
        Me.lblOpenWebPage.Text = "Open Web Page"
        '
        'lblNext
        '
        Me.lblNext.AutoSize = True
        Me.lblNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNext.Location = New System.Drawing.Point(780, 505)
        Me.lblNext.Name = "lblNext"
        Me.lblNext.Size = New System.Drawing.Size(62, 29)
        Me.lblNext.TabIndex = 1
        Me.lblNext.Text = "Next"
        '
        'pgPanelViewWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 591)
        Me.Controls.Add(Me.lblNext)
        Me.Controls.Add(Me.lblOpenWebPage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pgPanelViewWeb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pgPanelViewWeb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOpenWebPage As Label
    Friend WithEvents lblNext As Label
End Class
