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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
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
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdLog = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.CleanSubStatus = New System.Windows.Forms.Label
        Me.CleanStatus = New System.Windows.Forms.Label
        Me.TableLayoutPanel2.SuspendLayout()
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Total Space"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(3, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(104, 15)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Free Space Before"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tblStats
        '
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
        Me.tblStats.Location = New System.Drawing.Point(5, 90)
        Me.tblStats.Name = "tblStats"
        Me.tblStats.RowCount = 4
        Me.tblStats.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblStats.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblStats.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblStats.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblStats.Size = New System.Drawing.Size(236, 73)
        Me.tblStats.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Total Space"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(4, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(110, 15)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Free Space Before"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TotalSpace
        '
        Me.TotalSpace.BackColor = System.Drawing.SystemColors.Control
        Me.TotalSpace.Cursor = System.Windows.Forms.Cursors.Default
        Me.TotalSpace.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSpace.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TotalSpace.Location = New System.Drawing.Point(121, 1)
        Me.TotalSpace.Name = "TotalSpace"
        Me.TotalSpace.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TotalSpace.Size = New System.Drawing.Size(111, 16)
        Me.TotalSpace.TabIndex = 34
        Me.TotalSpace.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FreeSpaceBefore
        '
        Me.FreeSpaceBefore.BackColor = System.Drawing.SystemColors.Control
        Me.FreeSpaceBefore.Cursor = System.Windows.Forms.Cursors.Default
        Me.FreeSpaceBefore.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreeSpaceBefore.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FreeSpaceBefore.Location = New System.Drawing.Point(121, 18)
        Me.FreeSpaceBefore.Name = "FreeSpaceBefore"
        Me.FreeSpaceBefore.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FreeSpaceBefore.Size = New System.Drawing.Size(111, 17)
        Me.FreeSpaceBefore.TabIndex = 35
        Me.FreeSpaceBefore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(4, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(110, 15)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Free Space After"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SpaceFreedUp
        '
        Me.SpaceFreedUp.BackColor = System.Drawing.SystemColors.Control
        Me.SpaceFreedUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.SpaceFreedUp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpaceFreedUp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SpaceFreedUp.Location = New System.Drawing.Point(121, 54)
        Me.SpaceFreedUp.Name = "SpaceFreedUp"
        Me.SpaceFreedUp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SpaceFreedUp.Size = New System.Drawing.Size(111, 15)
        Me.SpaceFreedUp.TabIndex = 41
        Me.SpaceFreedUp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FreeSpaceAfter
        '
        Me.FreeSpaceAfter.BackColor = System.Drawing.SystemColors.Control
        Me.FreeSpaceAfter.Cursor = System.Windows.Forms.Cursors.Default
        Me.FreeSpaceAfter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreeSpaceAfter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FreeSpaceAfter.Location = New System.Drawing.Point(121, 36)
        Me.FreeSpaceAfter.Name = "FreeSpaceAfter"
        Me.FreeSpaceAfter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FreeSpaceAfter.Size = New System.Drawing.Size(111, 17)
        Me.FreeSpaceAfter.TabIndex = 36
        Me.FreeSpaceAfter.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(4, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(110, 15)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Space Freed Up"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ProgressBar0
        '
        Me.ProgressBar0.Location = New System.Drawing.Point(48, 59)
        Me.ProgressBar0.Maximum = 13
        Me.ProgressBar0.Minimum = 1
        Me.ProgressBar0.Name = "ProgressBar0"
        Me.ProgressBar0.Size = New System.Drawing.Size(150, 24)
        Me.ProgressBar0.Step = 1
        Me.ProgressBar0.TabIndex = 62
        Me.ProgressBar0.Value = 1
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(78, 169)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(89, 25)
        Me.cmdCancel.TabIndex = 57
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseCompatibleTextRendering = True
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        Me.cmdLog.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLog.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLog.Location = New System.Drawing.Point(34, 169)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLog.Size = New System.Drawing.Size(89, 25)
        Me.cmdLog.TabIndex = 59
        Me.cmdLog.Text = "View Log"
        Me.cmdLog.UseVisualStyleBackColor = True
        Me.cmdLog.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(130, 169)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(89, 25)
        Me.cmdClose.TabIndex = 60
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        Me.cmdClose.Visible = False
        '
        'CleanSubStatus
        '
        Me.CleanSubStatus.BackColor = System.Drawing.SystemColors.Control
        Me.CleanSubStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.CleanSubStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CleanSubStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CleanSubStatus.Location = New System.Drawing.Point(-1, 40)
        Me.CleanSubStatus.Name = "CleanSubStatus"
        Me.CleanSubStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CleanSubStatus.Size = New System.Drawing.Size(250, 17)
        Me.CleanSubStatus.TabIndex = 61
        Me.CleanSubStatus.Text = "See log for details.."
        Me.CleanSubStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CleanStatus
        '
        Me.CleanStatus.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CleanStatus.Location = New System.Drawing.Point(-1, 10)
        Me.CleanStatus.Name = "CleanStatus"
        Me.CleanStatus.Size = New System.Drawing.Size(250, 30)
        Me.CleanStatus.TabIndex = 58
        Me.CleanStatus.Text = "Cleaning..."
        Me.CleanStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CleanerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 202)
        Me.Controls.Add(Me.tblStats)
        Me.Controls.Add(Me.ProgressBar0)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdLog)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.CleanSubStatus)
        Me.Controls.Add(Me.CleanStatus)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CleanerWindow"
        Me.Text = "DriveTidy"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.tblStats.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmStatus As System.Windows.Forms.Timer
    Friend WithEvents tmSpace As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
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
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdLog As System.Windows.Forms.Button
    Public WithEvents cmdClose As System.Windows.Forms.Button
    Public WithEvents CleanSubStatus As System.Windows.Forms.Label
    Friend WithEvents CleanStatus As System.Windows.Forms.Label
End Class
