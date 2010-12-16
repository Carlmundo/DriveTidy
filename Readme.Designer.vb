<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Readme
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Readme))
        Me.txtReadme = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtReadme
        '
        Me.txtReadme.Location = New System.Drawing.Point(0, 0)
        Me.txtReadme.Multiline = True
        Me.txtReadme.Name = "txtReadme"
        Me.txtReadme.Size = New System.Drawing.Size(250, 192)
        Me.txtReadme.TabIndex = 0
        Me.txtReadme.Text = resources.GetString("txtReadme.Text")
        '
        'Readme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 190)
        Me.Controls.Add(Me.txtReadme)
        Me.Name = "Readme"
        Me.Text = "Readme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReadme As System.Windows.Forms.TextBox
End Class
