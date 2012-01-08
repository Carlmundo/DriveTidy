<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.lblStatus = New System.Windows.Forms.Label
        Me.bgUpdate = New System.ComponentModel.BackgroundWorker
        Me.tmCheck = New System.Windows.Forms.Timer(Me.components)
        Me.cbLaunch = New System.Windows.Forms.CheckBox
        Me.tblDesign = New System.Windows.Forms.TableLayoutPanel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.pbLogo = New System.Windows.Forms.PictureBox
        Me.txtError = New System.Windows.Forms.TextBox
        Me.flwInfo = New System.Windows.Forms.FlowLayoutPanel
        Me.cbErrorDetails = New System.Windows.Forms.CheckBox
        Me.lblSuccess = New System.Windows.Forms.Label
        Me.lblFailed = New System.Windows.Forms.Label
        Me.lblManualDL = New System.Windows.Forms.Label
        Me.lnkWebsite = New System.Windows.Forms.LinkLabel
        Me.flwButtons = New System.Windows.Forms.FlowLayoutPanel
        Me.cmdRetry = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.flwImages = New System.Windows.Forms.FlowLayoutPanel
        Me.imgUpdating = New System.Windows.Forms.PictureBox
        Me.imgSuccess = New System.Windows.Forms.PictureBox
        Me.imgFailed = New System.Windows.Forms.PictureBox
        Me.tblDesign.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flwInfo.SuspendLayout()
        Me.flwButtons.SuspendLayout()
        Me.flwImages.SuspendLayout()
        CType(Me.imgUpdating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSuccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFailed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(60, 62)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(83, 18)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Updating..."
        '
        'bgUpdate
        '
        '
        'tmCheck
        '
        Me.tmCheck.Enabled = True
        '
        'cbLaunch
        '
        Me.cbLaunch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbLaunch.AutoSize = True
        Me.cbLaunch.Location = New System.Drawing.Point(36, 362)
        Me.cbLaunch.Margin = New System.Windows.Forms.Padding(0)
        Me.cbLaunch.Name = "cbLaunch"
        Me.cbLaunch.Padding = New System.Windows.Forms.Padding(5)
        Me.cbLaunch.Size = New System.Drawing.Size(130, 29)
        Me.cbLaunch.TabIndex = 3
        Me.cbLaunch.Text = "Launch DriveTidy"
        Me.cbLaunch.UseVisualStyleBackColor = True
        Me.cbLaunch.Visible = False
        '
        'tblDesign
        '
        Me.tblDesign.AutoSize = True
        Me.tblDesign.ColumnCount = 1
        Me.tblDesign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDesign.Controls.Add(Me.lblStatus, 0, 2)
        Me.tblDesign.Controls.Add(Me.lblTitle, 0, 1)
        Me.tblDesign.Controls.Add(Me.pbLogo, 0, 0)
        Me.tblDesign.Controls.Add(Me.cbLaunch, 0, 6)
        Me.tblDesign.Controls.Add(Me.txtError, 0, 5)
        Me.tblDesign.Controls.Add(Me.flwInfo, 0, 4)
        Me.tblDesign.Controls.Add(Me.flwButtons, 0, 7)
        Me.tblDesign.Controls.Add(Me.flwImages, 0, 3)
        Me.tblDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDesign.Location = New System.Drawing.Point(3, 3)
        Me.tblDesign.Name = "tblDesign"
        Me.tblDesign.RowCount = 8
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.Size = New System.Drawing.Size(203, 127)
        Me.tblDesign.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(48, 38)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(107, 24)
        Me.lblTitle.TabIndex = 29
        Me.lblTitle.Text = "DriveTidy"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(85, 3)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(32, 32)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbLogo.TabIndex = 30
        Me.pbLogo.TabStop = False
        '
        'txtError
        '
        Me.txtError.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtError.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtError.Location = New System.Drawing.Point(11, 292)
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.ReadOnly = True
        Me.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtError.Size = New System.Drawing.Size(180, 67)
        Me.txtError.TabIndex = 8
        Me.txtError.Visible = False
        '
        'flwInfo
        '
        Me.flwInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.flwInfo.AutoSize = True
        Me.flwInfo.Controls.Add(Me.cbErrorDetails)
        Me.flwInfo.Controls.Add(Me.lblSuccess)
        Me.flwInfo.Controls.Add(Me.lblFailed)
        Me.flwInfo.Controls.Add(Me.lblManualDL)
        Me.flwInfo.Controls.Add(Me.lnkWebsite)
        Me.flwInfo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flwInfo.Location = New System.Drawing.Point(5, 141)
        Me.flwInfo.Name = "flwInfo"
        Me.flwInfo.Size = New System.Drawing.Size(192, 145)
        Me.flwInfo.TabIndex = 31
        Me.flwInfo.WrapContents = False
        '
        'cbErrorDetails
        '
        Me.cbErrorDetails.AutoSize = True
        Me.cbErrorDetails.Location = New System.Drawing.Point(3, 3)
        Me.cbErrorDetails.Name = "cbErrorDetails"
        Me.cbErrorDetails.Size = New System.Drawing.Size(121, 19)
        Me.cbErrorDetails.TabIndex = 1
        Me.cbErrorDetails.Text = "View error details"
        Me.cbErrorDetails.UseVisualStyleBackColor = True
        Me.cbErrorDetails.Visible = False
        '
        'lblSuccess
        '
        Me.lblSuccess.AutoSize = True
        Me.lblSuccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSuccess.Location = New System.Drawing.Point(3, 25)
        Me.lblSuccess.Name = "lblSuccess"
        Me.lblSuccess.Size = New System.Drawing.Size(186, 30)
        Me.lblSuccess.TabIndex = 0
        Me.lblSuccess.Text = "DriveTidy has now been updated" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and saved to your Dekstop."
        Me.lblSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSuccess.Visible = False
        '
        'lblFailed
        '
        Me.lblFailed.AutoSize = True
        Me.lblFailed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFailed.Location = New System.Drawing.Point(3, 55)
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Size = New System.Drawing.Size(186, 45)
        Me.lblFailed.TabIndex = 2
        Me.lblFailed.Text = "The server may be down or you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "are not connected to the Internet." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblFailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFailed.Visible = False
        '
        'lblManualDL
        '
        Me.lblManualDL.AutoSize = True
        Me.lblManualDL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblManualDL.Location = New System.Drawing.Point(3, 100)
        Me.lblManualDL.Name = "lblManualDL"
        Me.lblManualDL.Size = New System.Drawing.Size(186, 30)
        Me.lblManualDL.TabIndex = 5
        Me.lblManualDL.Text = "Please try again later or get the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "latest version from:"
        Me.lblManualDL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblManualDL.Visible = False
        '
        'lnkWebsite
        '
        Me.lnkWebsite.AutoSize = True
        Me.lnkWebsite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnkWebsite.LinkColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lnkWebsite.Location = New System.Drawing.Point(3, 130)
        Me.lnkWebsite.Name = "lnkWebsite"
        Me.lnkWebsite.Size = New System.Drawing.Size(186, 15)
        Me.lnkWebsite.TabIndex = 2
        Me.lnkWebsite.TabStop = True
        Me.lnkWebsite.Text = "www.fixkb.com/drivetidy"
        Me.lnkWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lnkWebsite.Visible = False
        Me.lnkWebsite.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(240, Byte), Integer))
        '
        'flwButtons
        '
        Me.flwButtons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.flwButtons.AutoSize = True
        Me.flwButtons.Controls.Add(Me.cmdRetry)
        Me.flwButtons.Controls.Add(Me.cmdClose)
        Me.flwButtons.Location = New System.Drawing.Point(37, 394)
        Me.flwButtons.Name = "flwButtons"
        Me.flwButtons.Size = New System.Drawing.Size(128, 33)
        Me.flwButtons.TabIndex = 32
        '
        'cmdRetry
        '
        Me.cmdRetry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdRetry.AutoSize = True
        Me.cmdRetry.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cmdRetry.Location = New System.Drawing.Point(3, 3)
        Me.cmdRetry.Name = "cmdRetry"
        Me.cmdRetry.Size = New System.Drawing.Size(58, 27)
        Me.cmdRetry.TabIndex = 4
        Me.cmdRetry.Text = "Retry"
        Me.cmdRetry.UseVisualStyleBackColor = True
        Me.cmdRetry.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdClose.AutoSize = True
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cmdClose.Location = New System.Drawing.Point(67, 3)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(58, 27)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        Me.cmdClose.Visible = False
        '
        'flwImages
        '
        Me.flwImages.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.flwImages.AutoSize = True
        Me.flwImages.Controls.Add(Me.imgUpdating)
        Me.flwImages.Controls.Add(Me.imgSuccess)
        Me.flwImages.Controls.Add(Me.imgFailed)
        Me.flwImages.Location = New System.Drawing.Point(29, 83)
        Me.flwImages.Name = "flwImages"
        Me.flwImages.Size = New System.Drawing.Size(145, 52)
        Me.flwImages.TabIndex = 33
        '
        'imgUpdating
        '
        Me.imgUpdating.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgUpdating.ErrorImage = Nothing
        Me.imgUpdating.Image = CType(resources.GetObject("imgUpdating.Image"), System.Drawing.Image)
        Me.imgUpdating.InitialImage = Nothing
        Me.imgUpdating.Location = New System.Drawing.Point(0, 5)
        Me.imgUpdating.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.imgUpdating.Name = "imgUpdating"
        Me.imgUpdating.Padding = New System.Windows.Forms.Padding(1, 3, 1, 0)
        Me.imgUpdating.Size = New System.Drawing.Size(41, 42)
        Me.imgUpdating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgUpdating.TabIndex = 2
        Me.imgUpdating.TabStop = False
        '
        'imgSuccess
        '
        Me.imgSuccess.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgSuccess.ErrorImage = Nothing
        Me.imgSuccess.Image = CType(resources.GetObject("imgSuccess.Image"), System.Drawing.Image)
        Me.imgSuccess.InitialImage = Nothing
        Me.imgSuccess.Location = New System.Drawing.Point(43, 2)
        Me.imgSuccess.Margin = New System.Windows.Forms.Padding(2)
        Me.imgSuccess.Name = "imgSuccess"
        Me.imgSuccess.Size = New System.Drawing.Size(48, 48)
        Me.imgSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgSuccess.TabIndex = 32
        Me.imgSuccess.TabStop = False
        Me.imgSuccess.Visible = False
        '
        'imgFailed
        '
        Me.imgFailed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgFailed.ErrorImage = Nothing
        Me.imgFailed.Image = CType(resources.GetObject("imgFailed.Image"), System.Drawing.Image)
        Me.imgFailed.InitialImage = Nothing
        Me.imgFailed.Location = New System.Drawing.Point(95, 2)
        Me.imgFailed.Margin = New System.Windows.Forms.Padding(2)
        Me.imgFailed.Name = "imgFailed"
        Me.imgFailed.Size = New System.Drawing.Size(48, 48)
        Me.imgFailed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgFailed.TabIndex = 31
        Me.imgFailed.TabStop = False
        Me.imgFailed.Visible = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(209, 133)
        Me.Controls.Add(Me.tblDesign)
        Me.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Text = "DriveTidy Update"
        Me.tblDesign.ResumeLayout(False)
        Me.tblDesign.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flwInfo.ResumeLayout(False)
        Me.flwInfo.PerformLayout()
        Me.flwButtons.ResumeLayout(False)
        Me.flwButtons.PerformLayout()
        Me.flwImages.ResumeLayout(False)
        Me.flwImages.PerformLayout()
        CType(Me.imgUpdating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSuccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFailed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bgUpdate As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents tmCheck As System.Windows.Forms.Timer
    Friend WithEvents cbLaunch As System.Windows.Forms.CheckBox
    Friend WithEvents tblDesign As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents flwInfo As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblSuccess As System.Windows.Forms.Label
    Friend WithEvents lblFailed As System.Windows.Forms.Label
    Friend WithEvents lblManualDL As System.Windows.Forms.Label
    Friend WithEvents lnkWebsite As System.Windows.Forms.LinkLabel
    Friend WithEvents txtError As System.Windows.Forms.TextBox
    Friend WithEvents cbErrorDetails As System.Windows.Forms.CheckBox
    Friend WithEvents flwButtons As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdRetry As System.Windows.Forms.Button
    Friend WithEvents flwImages As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents imgUpdating As System.Windows.Forms.PictureBox
    Friend WithEvents imgFailed As System.Windows.Forms.PictureBox
    Friend WithEvents imgSuccess As System.Windows.Forms.PictureBox

End Class
