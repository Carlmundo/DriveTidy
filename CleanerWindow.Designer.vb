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
        Me.tmStatus = New System.Windows.Forms.Timer(Me.components)
        Me.tmSpace = New System.Windows.Forms.Timer(Me.components)
        Me.tblDesign = New System.Windows.Forms.TableLayoutPanel
        Me.flwButtons = New System.Windows.Forms.FlowLayoutPanel
        Me.cmdLog = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.CleanStatus = New System.Windows.Forms.Label
        Me.tblStats = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TotalSpace = New System.Windows.Forms.Label
        Me.FreeSpaceBefore = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SpaceFreedUp = New System.Windows.Forms.Label
        Me.FreeSpaceAfter = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ProgressBar0 = New System.Windows.Forms.ProgressBar
        Me.CleanSubStatus = New System.Windows.Forms.Label
        Me.tblDesign.SuspendLayout()
        Me.flwButtons.SuspendLayout()
        Me.tblStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmStatus
        '
        Me.tmStatus.Enabled = True
        '
        'tmSpace
        '
        Me.tmSpace.Enabled = True
        '
        'tblDesign
        '
        Me.tblDesign.AutoSize = True
        Me.tblDesign.ColumnCount = 1
        Me.tblDesign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDesign.Controls.Add(Me.flwButtons, 0, 4)
        Me.tblDesign.Controls.Add(Me.CleanStatus, 0, 0)
        Me.tblDesign.Controls.Add(Me.tblStats, 0, 3)
        Me.tblDesign.Controls.Add(Me.ProgressBar0, 0, 2)
        Me.tblDesign.Controls.Add(Me.CleanSubStatus, 0, 1)
        Me.tblDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDesign.Location = New System.Drawing.Point(0, 0)
        Me.tblDesign.Name = "tblDesign"
        Me.tblDesign.RowCount = 6
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0.0!))
        Me.tblDesign.Size = New System.Drawing.Size(249, 199)
        Me.tblDesign.TabIndex = 65
        '
        'flwButtons
        '
        Me.flwButtons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.flwButtons.AutoSize = True
        Me.flwButtons.Controls.Add(Me.cmdLog)
        Me.flwButtons.Controls.Add(Me.cmdCancel)
        Me.flwButtons.Controls.Add(Me.cmdClose)
        Me.flwButtons.Location = New System.Drawing.Point(3, 166)
        Me.flwButtons.Name = "flwButtons"
        Me.flwButtons.Size = New System.Drawing.Size(243, 31)
        Me.flwButtons.TabIndex = 65
        Me.flwButtons.WrapContents = False
        '
        'cmdLog
        '
        Me.cmdLog.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdLog.AutoSize = True
        Me.cmdLog.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLog.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLog.Location = New System.Drawing.Point(3, 3)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLog.Size = New System.Drawing.Size(85, 25)
        Me.cmdLog.TabIndex = 59
        Me.cmdLog.Text = "View Log"
        Me.cmdLog.UseVisualStyleBackColor = True
        Me.cmdLog.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCancel.AutoSize = True
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(94, 3)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 57
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseCompatibleTextRendering = True
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdClose.AutoSize = True
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(185, 3)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(85, 25)
        Me.cmdClose.TabIndex = 60
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        Me.cmdClose.Visible = False
        '
        'CleanStatus
        '
        Me.CleanStatus.AutoSize = True
        Me.CleanStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CleanStatus.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CleanStatus.Location = New System.Drawing.Point(0, 0)
        Me.CleanStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.CleanStatus.Name = "CleanStatus"
        Me.CleanStatus.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.CleanStatus.Size = New System.Drawing.Size(249, 34)
        Me.CleanStatus.TabIndex = 58
        Me.CleanStatus.Text = "Cleaning..."
        Me.CleanStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblStats
        '
        Me.tblStats.AutoSize = True
        Me.tblStats.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tblStats.ColumnCount = 2
        Me.tblStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblStats.Controls.Add(Me.Label1, 0, 0)
        Me.tblStats.Controls.Add(Me.Label2, 0, 1)
        Me.tblStats.Controls.Add(Me.TotalSpace, 1, 0)
        Me.tblStats.Controls.Add(Me.FreeSpaceBefore, 1, 1)
        Me.tblStats.Controls.Add(Me.Label3, 0, 2)
        Me.tblStats.Controls.Add(Me.SpaceFreedUp, 1, 3)
        Me.tblStats.Controls.Add(Me.FreeSpaceAfter, 1, 2)
        Me.tblStats.Controls.Add(Me.Label4, 0, 3)
        Me.tblStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblStats.Location = New System.Drawing.Point(3, 91)
        Me.tblStats.Name = "tblStats"
        Me.tblStats.RowCount = 4
        Me.tblStats.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblStats.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblStats.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblStats.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblStats.Size = New System.Drawing.Size(243, 69)
        Me.tblStats.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(22, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Total Space"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(23, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Free Before"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalSpace
        '
        Me.TotalSpace.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TotalSpace.AutoSize = True
        Me.TotalSpace.BackColor = System.Drawing.SystemColors.Control
        Me.TotalSpace.Cursor = System.Windows.Forms.Cursors.Default
        Me.TotalSpace.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSpace.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TotalSpace.Location = New System.Drawing.Point(172, 1)
        Me.TotalSpace.Name = "TotalSpace"
        Me.TotalSpace.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TotalSpace.Size = New System.Drawing.Size(20, 16)
        Me.TotalSpace.TabIndex = 34
        Me.TotalSpace.Text = "..."
        Me.TotalSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FreeSpaceBefore
        '
        Me.FreeSpaceBefore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FreeSpaceBefore.AutoSize = True
        Me.FreeSpaceBefore.BackColor = System.Drawing.SystemColors.Control
        Me.FreeSpaceBefore.Cursor = System.Windows.Forms.Cursors.Default
        Me.FreeSpaceBefore.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreeSpaceBefore.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FreeSpaceBefore.Location = New System.Drawing.Point(172, 18)
        Me.FreeSpaceBefore.Name = "FreeSpaceBefore"
        Me.FreeSpaceBefore.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FreeSpaceBefore.Size = New System.Drawing.Size(20, 16)
        Me.FreeSpaceBefore.TabIndex = 35
        Me.FreeSpaceBefore.Text = "..."
        Me.FreeSpaceBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(28, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Free After"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SpaceFreedUp
        '
        Me.SpaceFreedUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SpaceFreedUp.AutoSize = True
        Me.SpaceFreedUp.BackColor = System.Drawing.SystemColors.Control
        Me.SpaceFreedUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.SpaceFreedUp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpaceFreedUp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SpaceFreedUp.Location = New System.Drawing.Point(172, 52)
        Me.SpaceFreedUp.Name = "SpaceFreedUp"
        Me.SpaceFreedUp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SpaceFreedUp.Size = New System.Drawing.Size(20, 16)
        Me.SpaceFreedUp.TabIndex = 41
        Me.SpaceFreedUp.Text = "..."
        Me.SpaceFreedUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FreeSpaceAfter
        '
        Me.FreeSpaceAfter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FreeSpaceAfter.AutoSize = True
        Me.FreeSpaceAfter.BackColor = System.Drawing.SystemColors.Control
        Me.FreeSpaceAfter.Cursor = System.Windows.Forms.Cursors.Default
        Me.FreeSpaceAfter.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreeSpaceAfter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FreeSpaceAfter.Location = New System.Drawing.Point(172, 35)
        Me.FreeSpaceAfter.Name = "FreeSpaceAfter"
        Me.FreeSpaceAfter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FreeSpaceAfter.Size = New System.Drawing.Size(20, 16)
        Me.FreeSpaceAfter.TabIndex = 36
        Me.FreeSpaceAfter.Text = "..."
        Me.FreeSpaceAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Space Freed"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar0
        '
        Me.ProgressBar0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressBar0.Location = New System.Drawing.Point(49, 56)
        Me.ProgressBar0.Margin = New System.Windows.Forms.Padding(7)
        Me.ProgressBar0.Maximum = 13
        Me.ProgressBar0.Minimum = 1
        Me.ProgressBar0.Name = "ProgressBar0"
        Me.ProgressBar0.Size = New System.Drawing.Size(150, 25)
        Me.ProgressBar0.Step = 1
        Me.ProgressBar0.TabIndex = 62
        Me.ProgressBar0.Value = 1
        '
        'CleanSubStatus
        '
        Me.CleanSubStatus.AutoSize = True
        Me.CleanSubStatus.BackColor = System.Drawing.SystemColors.Control
        Me.CleanSubStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.CleanSubStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CleanSubStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CleanSubStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CleanSubStatus.Location = New System.Drawing.Point(0, 34)
        Me.CleanSubStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.CleanSubStatus.Name = "CleanSubStatus"
        Me.CleanSubStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CleanSubStatus.Size = New System.Drawing.Size(249, 15)
        Me.CleanSubStatus.TabIndex = 61
        Me.CleanSubStatus.Text = "..."
        Me.CleanSubStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CleanerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(249, 199)
        Me.Controls.Add(Me.tblDesign)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CleanerWindow"
        Me.Text = "DriveTidy"
        Me.tblDesign.ResumeLayout(False)
        Me.tblDesign.PerformLayout()
        Me.flwButtons.ResumeLayout(False)
        Me.flwButtons.PerformLayout()
        Me.tblStats.ResumeLayout(False)
        Me.tblStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmStatus As System.Windows.Forms.Timer
    Friend WithEvents tmSpace As System.Windows.Forms.Timer
    Friend WithEvents tblDesign As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents flwButtons As System.Windows.Forms.FlowLayoutPanel
    Public WithEvents cmdLog As System.Windows.Forms.Button
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents CleanStatus As System.Windows.Forms.Label
    Friend WithEvents tblStats As System.Windows.Forms.TableLayoutPanel
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents TotalSpace As System.Windows.Forms.Label
    Public WithEvents FreeSpaceBefore As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents SpaceFreedUp As System.Windows.Forms.Label
    Public WithEvents FreeSpaceAfter As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar0 As System.Windows.Forms.ProgressBar
    Public WithEvents CleanSubStatus As System.Windows.Forms.Label
End Class
