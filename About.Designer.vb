<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.flwButtons = New System.Windows.Forms.FlowLayoutPanel
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.cmdReadme = New System.Windows.Forms.Button
        Me.pbLogo = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.tblDesign = New System.Windows.Forms.TableLayoutPanel
        Me.flwSocial = New System.Windows.Forms.FlowLayoutPanel
        Me.pbWeb = New System.Windows.Forms.PictureBox
        Me.lnkWeb = New System.Windows.Forms.LinkLabel
        Me.pbTwitter = New System.Windows.Forms.PictureBox
        Me.lnkTwitter = New System.Windows.Forms.LinkLabel
        Me.flwButtons.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblDesign.SuspendLayout()
        Me.flwSocial.SuspendLayout()
        CType(Me.pbWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTwitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flwButtons
        '
        Me.flwButtons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.flwButtons.AutoSize = True
        Me.flwButtons.Controls.Add(Me.cmdUpdate)
        Me.flwButtons.Controls.Add(Me.cmdReadme)
        Me.flwButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flwButtons.Location = New System.Drawing.Point(19, 95)
        Me.flwButtons.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.flwButtons.Name = "flwButtons"
        Me.flwButtons.Size = New System.Drawing.Size(133, 54)
        Me.flwButtons.TabIndex = 26
        Me.flwButtons.WrapContents = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdUpdate.Location = New System.Drawing.Point(2, 2)
        Me.cmdUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(129, 23)
        Me.cmdUpdate.TabIndex = 4
        Me.cmdUpdate.Text = "Check For Updates"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdReadme
        '
        Me.cmdReadme.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdReadme.Location = New System.Drawing.Point(26, 29)
        Me.cmdReadme.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdReadme.Name = "cmdReadme"
        Me.cmdReadme.Size = New System.Drawing.Size(81, 23)
        Me.cmdReadme.TabIndex = 5
        Me.cmdReadme.Text = "Readme"
        Me.cmdReadme.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(69, 3)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(32, 32)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbLogo.TabIndex = 28
        Me.pbLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 38)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(165, 24)
        Me.lblTitle.TabIndex = 27
        Me.lblTitle.Text = "DriveTidy"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVersion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(3, 62)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(165, 15)
        Me.lblVersion.TabIndex = 29
        Me.lblVersion.Text = "Version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCopyright.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(3, 77)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(165, 15)
        Me.lblCopyright.TabIndex = 30
        Me.lblCopyright.Text = "Copyright"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblDesign
        '
        Me.tblDesign.AutoSize = True
        Me.tblDesign.ColumnCount = 1
        Me.tblDesign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDesign.Controls.Add(Me.lblCopyright, 0, 3)
        Me.tblDesign.Controls.Add(Me.lblVersion, 0, 2)
        Me.tblDesign.Controls.Add(Me.lblTitle, 0, 1)
        Me.tblDesign.Controls.Add(Me.pbLogo, 0, 0)
        Me.tblDesign.Controls.Add(Me.flwButtons, 0, 4)
        Me.tblDesign.Controls.Add(Me.flwSocial, 0, 5)
        Me.tblDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDesign.Location = New System.Drawing.Point(5, 3)
        Me.tblDesign.Name = "tblDesign"
        Me.tblDesign.RowCount = 6
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblDesign.Size = New System.Drawing.Size(171, 172)
        Me.tblDesign.TabIndex = 24
        '
        'flwSocial
        '
        Me.flwSocial.AutoSize = True
        Me.flwSocial.Controls.Add(Me.pbWeb)
        Me.flwSocial.Controls.Add(Me.lnkWeb)
        Me.flwSocial.Controls.Add(Me.pbTwitter)
        Me.flwSocial.Controls.Add(Me.lnkTwitter)
        Me.flwSocial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flwSocial.Location = New System.Drawing.Point(0, 149)
        Me.flwSocial.Margin = New System.Windows.Forms.Padding(0)
        Me.flwSocial.Name = "flwSocial"
        Me.flwSocial.Padding = New System.Windows.Forms.Padding(5)
        Me.flwSocial.Size = New System.Drawing.Size(171, 26)
        Me.flwSocial.TabIndex = 31
        Me.flwSocial.WrapContents = False
        '
        'pbWeb
        '
        Me.pbWeb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbWeb.ErrorImage = Nothing
        Me.pbWeb.Image = CType(resources.GetObject("pbWeb.Image"), System.Drawing.Image)
        Me.pbWeb.InitialImage = Nothing
        Me.pbWeb.Location = New System.Drawing.Point(5, 5)
        Me.pbWeb.Margin = New System.Windows.Forms.Padding(0)
        Me.pbWeb.Name = "pbWeb"
        Me.pbWeb.Size = New System.Drawing.Size(16, 16)
        Me.pbWeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbWeb.TabIndex = 13
        Me.pbWeb.TabStop = False
        '
        'lnkWeb
        '
        Me.lnkWeb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkWeb.AutoSize = True
        Me.lnkWeb.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkWeb.LinkColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lnkWeb.Location = New System.Drawing.Point(21, 5)
        Me.lnkWeb.Margin = New System.Windows.Forms.Padding(0)
        Me.lnkWeb.Name = "lnkWeb"
        Me.lnkWeb.Size = New System.Drawing.Size(87, 15)
        Me.lnkWeb.TabIndex = 14
        Me.lnkWeb.TabStop = True
        Me.lnkWeb.Text = "www.fixkb.com"
        Me.lnkWeb.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(240, Byte), Integer))
        '
        'pbTwitter
        '
        Me.pbTwitter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbTwitter.ErrorImage = Nothing
        Me.pbTwitter.Image = CType(resources.GetObject("pbTwitter.Image"), System.Drawing.Image)
        Me.pbTwitter.InitialImage = Nothing
        Me.pbTwitter.Location = New System.Drawing.Point(108, 5)
        Me.pbTwitter.Margin = New System.Windows.Forms.Padding(0)
        Me.pbTwitter.Name = "pbTwitter"
        Me.pbTwitter.Size = New System.Drawing.Size(16, 16)
        Me.pbTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbTwitter.TabIndex = 11
        Me.pbTwitter.TabStop = False
        '
        'lnkTwitter
        '
        Me.lnkTwitter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkTwitter.AutoSize = True
        Me.lnkTwitter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkTwitter.LinkColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lnkTwitter.Location = New System.Drawing.Point(124, 5)
        Me.lnkTwitter.Margin = New System.Windows.Forms.Padding(0)
        Me.lnkTwitter.Name = "lnkTwitter"
        Me.lnkTwitter.Size = New System.Drawing.Size(50, 15)
        Me.lnkTwitter.TabIndex = 12
        Me.lnkTwitter.TabStop = True
        Me.lnkTwitter.Text = "@FixKB"
        Me.lnkTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lnkTwitter.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(240, Byte), Integer))
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(181, 175)
        Me.Controls.Add(Me.tblDesign)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "About"
        Me.Padding = New System.Windows.Forms.Padding(5, 3, 5, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About DriveTidy"
        Me.flwButtons.ResumeLayout(False)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblDesign.ResumeLayout(False)
        Me.tblDesign.PerformLayout()
        Me.flwSocial.ResumeLayout(False)
        Me.flwSocial.PerformLayout()
        CType(Me.pbWeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTwitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents flwButtons As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents tblDesign As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdReadme As System.Windows.Forms.Button
    Friend WithEvents flwSocial As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pbWeb As System.Windows.Forms.PictureBox
    Friend WithEvents lnkWeb As System.Windows.Forms.LinkLabel
    Friend WithEvents pbTwitter As System.Windows.Forms.PictureBox
    Friend WithEvents lnkTwitter As System.Windows.Forms.LinkLabel
End Class
