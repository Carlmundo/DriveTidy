<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CleanerWindow
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
        Me.components = New System.ComponentModel.Container
        Me.CleanStatus = New System.Windows.Forms.Label
        Me.CleanSubStatus = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdLog = New System.Windows.Forms.Button
        Me.SpaceFreedUp = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.FreeSpaceAfter = New System.Windows.Forms.Label
        Me.FreeSpaceBefore = New System.Windows.Forms.Label
        Me.TotalSpace = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.FreeSpaceValue = New System.Windows.Forms.Label
        Me.FreeSpaceAfterMB = New System.Windows.Forms.Label
        Me.FreeSpaceAfterGB = New System.Windows.Forms.Label
        Me.FreeSpaceBeforeGB = New System.Windows.Forms.Label
        Me.FreeSpaceBeforeMB = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.cmdClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CleanStatus
        '
        Me.CleanStatus.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CleanStatus.Location = New System.Drawing.Point(3, 12)
        Me.CleanStatus.Name = "CleanStatus"
        Me.CleanStatus.Size = New System.Drawing.Size(251, 34)
        Me.CleanStatus.TabIndex = 1
        Me.CleanStatus.Text = "Cleaning..."
        Me.CleanStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CleanSubStatus
        '
        Me.CleanSubStatus.BackColor = System.Drawing.SystemColors.Control
        Me.CleanSubStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.CleanSubStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CleanSubStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CleanSubStatus.Location = New System.Drawing.Point(-4, 46)
        Me.CleanSubStatus.Name = "CleanSubStatus"
        Me.CleanSubStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CleanSubStatus.Size = New System.Drawing.Size(257, 17)
        Me.CleanSubStatus.TabIndex = 33
        Me.CleanSubStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(79, 159)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(89, 25)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseCompatibleTextRendering = True
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        Me.cmdLog.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLog.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLog.Location = New System.Drawing.Point(35, 159)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLog.Size = New System.Drawing.Size(89, 25)
        Me.cmdLog.TabIndex = 2
        Me.cmdLog.Text = "View Log"
        Me.cmdLog.UseVisualStyleBackColor = True
        Me.cmdLog.Visible = False
        '
        'SpaceFreedUp
        '
        Me.SpaceFreedUp.BackColor = System.Drawing.SystemColors.Control
        Me.SpaceFreedUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.SpaceFreedUp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpaceFreedUp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SpaceFreedUp.Location = New System.Drawing.Point(102, 143)
        Me.SpaceFreedUp.Name = "SpaceFreedUp"
        Me.SpaceFreedUp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SpaceFreedUp.Size = New System.Drawing.Size(135, 20)
        Me.SpaceFreedUp.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(-1, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Space Freed Up:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(4, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Free Space After:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(1, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Free Space Before:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(35, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Total Space:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FreeSpaceAfter
        '
        Me.FreeSpaceAfter.BackColor = System.Drawing.SystemColors.Control
        Me.FreeSpaceAfter.Cursor = System.Windows.Forms.Cursors.Default
        Me.FreeSpaceAfter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreeSpaceAfter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FreeSpaceAfter.Location = New System.Drawing.Point(102, 127)
        Me.FreeSpaceAfter.Name = "FreeSpaceAfter"
        Me.FreeSpaceAfter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FreeSpaceAfter.Size = New System.Drawing.Size(137, 17)
        Me.FreeSpaceAfter.TabIndex = 36
        '
        'FreeSpaceBefore
        '
        Me.FreeSpaceBefore.BackColor = System.Drawing.SystemColors.Control
        Me.FreeSpaceBefore.Cursor = System.Windows.Forms.Cursors.Default
        Me.FreeSpaceBefore.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreeSpaceBefore.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FreeSpaceBefore.Location = New System.Drawing.Point(102, 111)
        Me.FreeSpaceBefore.Name = "FreeSpaceBefore"
        Me.FreeSpaceBefore.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FreeSpaceBefore.Size = New System.Drawing.Size(137, 17)
        Me.FreeSpaceBefore.TabIndex = 35
        '
        'TotalSpace
        '
        Me.TotalSpace.BackColor = System.Drawing.SystemColors.Control
        Me.TotalSpace.Cursor = System.Windows.Forms.Cursors.Default
        Me.TotalSpace.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSpace.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TotalSpace.Location = New System.Drawing.Point(102, 95)
        Me.TotalSpace.Name = "TotalSpace"
        Me.TotalSpace.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TotalSpace.Size = New System.Drawing.Size(137, 16)
        Me.TotalSpace.TabIndex = 34
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'FreeSpaceValue
        '
        Me.FreeSpaceValue.BackColor = System.Drawing.SystemColors.Control
        Me.FreeSpaceValue.Cursor = System.Windows.Forms.Cursors.Default
        Me.FreeSpaceValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FreeSpaceValue.Location = New System.Drawing.Point(291, 125)
        Me.FreeSpaceValue.Name = "FreeSpaceValue"
        Me.FreeSpaceValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FreeSpaceValue.Size = New System.Drawing.Size(121, 17)
        Me.FreeSpaceValue.TabIndex = 49
        Me.FreeSpaceValue.Text = "0"
        '
        'FreeSpaceAfterMB
        '
        Me.FreeSpaceAfterMB.BackColor = System.Drawing.SystemColors.Control
        Me.FreeSpaceAfterMB.Cursor = System.Windows.Forms.Cursors.Default
        Me.FreeSpaceAfterMB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FreeSpaceAfterMB.Location = New System.Drawing.Point(291, 77)
        Me.FreeSpaceAfterMB.Name = "FreeSpaceAfterMB"
        Me.FreeSpaceAfterMB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FreeSpaceAfterMB.Size = New System.Drawing.Size(121, 17)
        Me.FreeSpaceAfterMB.TabIndex = 48
        Me.FreeSpaceAfterMB.Text = "Free Space After MB"
        '
        'FreeSpaceAfterGB
        '
        Me.FreeSpaceAfterGB.BackColor = System.Drawing.SystemColors.Control
        Me.FreeSpaceAfterGB.Cursor = System.Windows.Forms.Cursors.Default
        Me.FreeSpaceAfterGB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FreeSpaceAfterGB.Location = New System.Drawing.Point(291, 93)
        Me.FreeSpaceAfterGB.Name = "FreeSpaceAfterGB"
        Me.FreeSpaceAfterGB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FreeSpaceAfterGB.Size = New System.Drawing.Size(121, 17)
        Me.FreeSpaceAfterGB.TabIndex = 47
        Me.FreeSpaceAfterGB.Text = "Free Space After GB"
        '
        'FreeSpaceBeforeGB
        '
        Me.FreeSpaceBeforeGB.BackColor = System.Drawing.SystemColors.Control
        Me.FreeSpaceBeforeGB.Cursor = System.Windows.Forms.Cursors.Default
        Me.FreeSpaceBeforeGB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FreeSpaceBeforeGB.Location = New System.Drawing.Point(291, 45)
        Me.FreeSpaceBeforeGB.Name = "FreeSpaceBeforeGB"
        Me.FreeSpaceBeforeGB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FreeSpaceBeforeGB.Size = New System.Drawing.Size(121, 17)
        Me.FreeSpaceBeforeGB.TabIndex = 46
        Me.FreeSpaceBeforeGB.Text = "Free Space Before GB"
        '
        'FreeSpaceBeforeMB
        '
        Me.FreeSpaceBeforeMB.BackColor = System.Drawing.SystemColors.Control
        Me.FreeSpaceBeforeMB.Cursor = System.Windows.Forms.Cursors.Default
        Me.FreeSpaceBeforeMB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FreeSpaceBeforeMB.Location = New System.Drawing.Point(291, 29)
        Me.FreeSpaceBeforeMB.Name = "FreeSpaceBeforeMB"
        Me.FreeSpaceBeforeMB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FreeSpaceBeforeMB.Size = New System.Drawing.Size(121, 17)
        Me.FreeSpaceBeforeMB.TabIndex = 45
        Me.FreeSpaceBeforeMB.Text = "Free Space Before MB"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(62, 68)
        Me.ProgressBar1.Maximum = 13
        Me.ProgressBar1.Minimum = 1
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(125, 20)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 55
        Me.ProgressBar1.Value = 1
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(131, 159)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(89, 25)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        Me.cmdClose.Visible = False
        '
        'CleanerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(249, 190)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.FreeSpaceValue)
        Me.Controls.Add(Me.FreeSpaceAfterMB)
        Me.Controls.Add(Me.FreeSpaceAfterGB)
        Me.Controls.Add(Me.FreeSpaceBeforeGB)
        Me.Controls.Add(Me.FreeSpaceBeforeMB)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdLog)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.SpaceFreedUp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FreeSpaceAfter)
        Me.Controls.Add(Me.FreeSpaceBefore)
        Me.Controls.Add(Me.TotalSpace)
        Me.Controls.Add(Me.CleanSubStatus)
        Me.Controls.Add(Me.CleanStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CleanerWindow"
        Me.Text = "DriveTidy"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CleanStatus As System.Windows.Forms.Label
    Public WithEvents CleanSubStatus As System.Windows.Forms.Label
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdLog As System.Windows.Forms.Button
    Public WithEvents SpaceFreedUp As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents FreeSpaceAfter As System.Windows.Forms.Label
    Public WithEvents FreeSpaceBefore As System.Windows.Forms.Label
    Public WithEvents TotalSpace As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Public WithEvents FreeSpaceValue As System.Windows.Forms.Label
    Public WithEvents FreeSpaceAfterMB As System.Windows.Forms.Label
    Public WithEvents FreeSpaceAfterGB As System.Windows.Forms.Label
    Public WithEvents FreeSpaceBeforeGB As System.Windows.Forms.Label
    Public WithEvents FreeSpaceBeforeMB As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Public WithEvents cmdClose As System.Windows.Forms.Button
End Class
