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
        Me.flwButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdReadme = New System.Windows.Forms.Button()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.tblDesign = New System.Windows.Forms.TableLayoutPanel()
        Me.flwSocial = New System.Windows.Forms.FlowLayoutPanel()
        Me.lnkWeb = New System.Windows.Forms.LinkLabel()
        Me.flwButtons.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblDesign.SuspendLayout()
        Me.flwSocial.SuspendLayout()
        Me.SuspendLayout()
        '
        'flwButtons
        '
        Me.flwButtons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.flwButtons.AutoSize = True
        Me.flwButtons.Controls.Add(Me.cmdUpdate)
        Me.flwButtons.Controls.Add(Me.cmdReadme)
        Me.flwButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flwButtons.Location = New System.Drawing.Point(21, 95)
        Me.flwButtons.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.flwButtons.Name = "flwButtons"
        Me.flwButtons.Size = New System.Drawing.Size(167, 70)
        Me.flwButtons.TabIndex = 26
        Me.flwButtons.WrapContents = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdUpdate.AutoSize = True
        Me.cmdUpdate.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(2, 3)
        Me.cmdUpdate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(163, 29)
        Me.cmdUpdate.TabIndex = 4
        Me.cmdUpdate.Text = "Check For Updates"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdReadme
        '
        Me.cmdReadme.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdReadme.AutoSize = True
        Me.cmdReadme.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReadme.Location = New System.Drawing.Point(42, 38)
        Me.cmdReadme.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdReadme.Name = "cmdReadme"
        Me.cmdReadme.Size = New System.Drawing.Size(82, 29)
        Me.cmdReadme.TabIndex = 5
        Me.cmdReadme.Text = "Readme"
        Me.cmdReadme.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(89, 4)
        Me.pbLogo.Margin = New System.Windows.Forms.Padding(4)
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
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(4, 40)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(202, 32)
        Me.lblTitle.TabIndex = 27
        Me.lblTitle.Text = "DriveTidy"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(4, 72)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(202, 19)
        Me.lblVersion.TabIndex = 29
        Me.lblVersion.Text = "Version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblDesign
        '
        Me.tblDesign.AutoSize = True
        Me.tblDesign.ColumnCount = 1
        Me.tblDesign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDesign.Controls.Add(Me.lblVersion, 0, 2)
        Me.tblDesign.Controls.Add(Me.lblTitle, 0, 1)
        Me.tblDesign.Controls.Add(Me.pbLogo, 0, 0)
        Me.tblDesign.Controls.Add(Me.flwButtons, 0, 4)
        Me.tblDesign.Controls.Add(Me.flwSocial, 0, 5)
        Me.tblDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDesign.Location = New System.Drawing.Point(6, 4)
        Me.tblDesign.Margin = New System.Windows.Forms.Padding(4)
        Me.tblDesign.Name = "tblDesign"
        Me.tblDesign.RowCount = 6
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tblDesign.Size = New System.Drawing.Size(210, 185)
        Me.tblDesign.TabIndex = 24
        '
        'flwSocial
        '
        Me.flwSocial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.flwSocial.AutoSize = True
        Me.flwSocial.Controls.Add(Me.lnkWeb)
        Me.flwSocial.Location = New System.Drawing.Point(68, 165)
        Me.flwSocial.Margin = New System.Windows.Forms.Padding(0)
        Me.flwSocial.Name = "flwSocial"
        Me.flwSocial.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.flwSocial.Size = New System.Drawing.Size(74, 24)
        Me.flwSocial.TabIndex = 31
        Me.flwSocial.WrapContents = False
        '
        'lnkWeb
        '
        Me.lnkWeb.AutoSize = True
        Me.lnkWeb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnkWeb.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkWeb.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkWeb.LinkColor = System.Drawing.SystemColors.Highlight
        Me.lnkWeb.Location = New System.Drawing.Point(0, 0)
        Me.lnkWeb.Margin = New System.Windows.Forms.Padding(0)
        Me.lnkWeb.Name = "lnkWeb"
        Me.lnkWeb.Size = New System.Drawing.Size(74, 19)
        Me.lnkWeb.TabIndex = 14
        Me.lnkWeb.TabStop = True
        Me.lnkWeb.Text = "FixKB.com"
        Me.lnkWeb.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lnkWeb.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(240, Byte), Integer))
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(222, 189)
        Me.Controls.Add(Me.tblDesign)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "About"
        Me.Padding = New System.Windows.Forms.Padding(6, 4, 6, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About DriveTidy"
        Me.flwButtons.ResumeLayout(False)
        Me.flwButtons.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblDesign.ResumeLayout(False)
        Me.tblDesign.PerformLayout()
        Me.flwSocial.ResumeLayout(False)
        Me.flwSocial.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents flwButtons As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents tblDesign As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdReadme As System.Windows.Forms.Button
    Friend WithEvents flwSocial As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lnkWeb As System.Windows.Forms.LinkLabel
End Class
