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
        Me.cmdClose = New System.Windows.Forms.Button
        Me.flwButtons = New System.Windows.Forms.FlowLayoutPanel
        Me.lnkUpdate = New System.Windows.Forms.LinkLabel
        Me.lnkReadme = New System.Windows.Forms.LinkLabel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.pbLogo = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.tblDesign = New System.Windows.Forms.TableLayoutPanel
        Me.flwButtons.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblDesign.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdClose.AutoSize = True
        Me.cmdClose.Location = New System.Drawing.Point(34, 33)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(50, 25)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'flwButtons
        '
        Me.flwButtons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.flwButtons.AutoSize = True
        Me.flwButtons.Controls.Add(Me.lnkUpdate)
        Me.flwButtons.Controls.Add(Me.lnkReadme)
        Me.flwButtons.Controls.Add(Me.cmdClose)
        Me.flwButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flwButtons.Location = New System.Drawing.Point(7, 95)
        Me.flwButtons.Name = "flwButtons"
        Me.flwButtons.Size = New System.Drawing.Size(119, 61)
        Me.flwButtons.TabIndex = 26
        Me.flwButtons.WrapContents = False
        '
        'lnkUpdate
        '
        Me.lnkUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkUpdate.AutoSize = True
        Me.lnkUpdate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkUpdate.Location = New System.Drawing.Point(3, 0)
        Me.lnkUpdate.Name = "lnkUpdate"
        Me.lnkUpdate.Size = New System.Drawing.Size(113, 15)
        Me.lnkUpdate.TabIndex = 2
        Me.lnkUpdate.TabStop = True
        Me.lnkUpdate.Text = "Check For Updates"
        '
        'lnkReadme
        '
        Me.lnkReadme.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkReadme.AutoSize = True
        Me.lnkReadme.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkReadme.Location = New System.Drawing.Point(7, 15)
        Me.lnkReadme.Name = "lnkReadme"
        Me.lnkReadme.Size = New System.Drawing.Size(104, 15)
        Me.lnkReadme.TabIndex = 3
        Me.lnkReadme.TabStop = True
        Me.lnkReadme.Text = "View the Readme"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(66, 166)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel1.TabIndex = 25
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(50, 3)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(32, 32)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbLogo.TabIndex = 28
        Me.pbLogo.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 24)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "DriveTidy"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVersion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(3, 62)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(127, 15)
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
        Me.lblCopyright.Size = New System.Drawing.Size(127, 15)
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
        Me.tblDesign.Controls.Add(Me.Label4, 0, 1)
        Me.tblDesign.Controls.Add(Me.pbLogo, 0, 0)
        Me.tblDesign.Controls.Add(Me.FlowLayoutPanel1, 0, 6)
        Me.tblDesign.Controls.Add(Me.flwButtons, 0, 4)
        Me.tblDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDesign.Location = New System.Drawing.Point(10, 5)
        Me.tblDesign.Name = "tblDesign"
        Me.tblDesign.RowCount = 7
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0.0!))
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblDesign.Size = New System.Drawing.Size(133, 161)
        Me.tblDesign.TabIndex = 24
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(153, 166)
        Me.Controls.Add(Me.tblDesign)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "About"
        Me.Padding = New System.Windows.Forms.Padding(10, 5, 10, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About DriveTidy"
        Me.flwButtons.ResumeLayout(False)
        Me.flwButtons.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblDesign.ResumeLayout(False)
        Me.tblDesign.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents flwButtons As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents tblDesign As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lnkUpdate As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkReadme As System.Windows.Forms.LinkLabel
End Class
