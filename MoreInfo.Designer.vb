<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoreInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MoreInfo))
        Me.txtFAQ = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtFAQ
        '
        Me.txtFAQ.Location = New System.Drawing.Point(0, 0)
        Me.txtFAQ.Multiline = True
        Me.txtFAQ.Name = "txtFAQ"
        Me.txtFAQ.Size = New System.Drawing.Size(251, 192)
        Me.txtFAQ.TabIndex = 0
        Me.txtFAQ.Text = resources.GetString("txtFAQ.Text")
        '
        'MoreInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 190)
        Me.Controls.Add(Me.txtFAQ)
        Me.Name = "MoreInfo"
        Me.Text = "More Info..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFAQ As System.Windows.Forms.TextBox
End Class
