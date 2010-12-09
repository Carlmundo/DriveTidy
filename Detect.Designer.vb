<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detect
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
        Me.lblCenter = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblCenter
        '
        Me.lblCenter.AutoSize = True
        Me.lblCenter.Location = New System.Drawing.Point(10, 8)
        Me.lblCenter.Name = "lblCenter"
        Me.lblCenter.Size = New System.Drawing.Size(13, 13)
        Me.lblCenter.TabIndex = 0
        Me.lblCenter.Text = "1"
        '
        'Detect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(162, 37)
        Me.Controls.Add(Me.lblCenter)
        Me.Name = "Detect"
        Me.Text = "Detect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCenter As System.Windows.Forms.Label
End Class
