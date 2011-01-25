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
        Me.cmdReadMe = New System.Windows.Forms.Button
        Me.lblEmail = New System.Windows.Forms.LinkLabel
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.lblContact = New System.Windows.Forms.Label
        Me.tblDesign = New System.Windows.Forms.TableLayoutPanel
        Me.flwContact = New System.Windows.Forms.FlowLayoutPanel
        Me.lblCopyright = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.tbDescription = New System.Windows.Forms.TextBox
        Me.flwButtons = New System.Windows.Forms.FlowLayoutPanel
        Me.cmdClose = New System.Windows.Forms.Button
        Me.pbLogo = New System.Windows.Forms.PictureBox
        Me.tblDesign.SuspendLayout()
        Me.flwContact.SuspendLayout()
        Me.flwButtons.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdReadMe
        '
        Me.cmdReadMe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdReadMe.AutoSize = True
        Me.cmdReadMe.Location = New System.Drawing.Point(94, 3)
        Me.cmdReadMe.Name = "cmdReadMe"
        Me.cmdReadMe.Size = New System.Drawing.Size(85, 25)
        Me.cmdReadMe.TabIndex = 1
        Me.cmdReadMe.Text = "Readme"
        Me.cmdReadMe.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblEmail.Location = New System.Drawing.Point(52, 0)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(127, 15)
        Me.lblEmail.TabIndex = 21
        Me.lblEmail.TabStop = True
        Me.lblEmail.Text = "DriveTidy@gmail.com"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdUpdate.AutoSize = True
        Me.cmdUpdate.Location = New System.Drawing.Point(3, 3)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 0
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(0, 0)
        Me.lblContact.Margin = New System.Windows.Forms.Padding(0)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(52, 15)
        Me.lblContact.TabIndex = 23
        Me.lblContact.Text = "Contact:"
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblDesign
        '
        Me.tblDesign.AutoSize = True
        Me.tblDesign.ColumnCount = 1
        Me.tblDesign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDesign.Controls.Add(Me.flwContact, 0, 6)
        Me.tblDesign.Controls.Add(Me.lblCopyright, 0, 3)
        Me.tblDesign.Controls.Add(Me.lblVersion, 0, 2)
        Me.tblDesign.Controls.Add(Me.Label4, 0, 1)
        Me.tblDesign.Controls.Add(Me.pbLogo, 0, 0)
        Me.tblDesign.Controls.Add(Me.FlowLayoutPanel1, 0, 8)
        Me.tblDesign.Controls.Add(Me.tbDescription, 0, 5)
        Me.tblDesign.Controls.Add(Me.flwButtons, 0, 4)
        Me.tblDesign.Controls.Add(Me.cmdClose, 0, 7)
        Me.tblDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDesign.Location = New System.Drawing.Point(0, 0)
        Me.tblDesign.Name = "tblDesign"
        Me.tblDesign.RowCount = 9
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0.0!))
        Me.tblDesign.Size = New System.Drawing.Size(249, 254)
        Me.tblDesign.TabIndex = 24
        '
        'flwContact
        '
        Me.flwContact.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.flwContact.AutoSize = True
        Me.flwContact.Controls.Add(Me.lblContact)
        Me.flwContact.Controls.Add(Me.lblEmail)
        Me.flwContact.Location = New System.Drawing.Point(35, 204)
        Me.flwContact.Margin = New System.Windows.Forms.Padding(0)
        Me.flwContact.Name = "flwContact"
        Me.flwContact.Size = New System.Drawing.Size(179, 15)
        Me.flwContact.TabIndex = 25
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCopyright.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(3, 77)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(243, 15)
        Me.lblCopyright.TabIndex = 30
        Me.lblCopyright.Text = "Copyright"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVersion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(3, 62)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(243, 15)
        Me.lblVersion.TabIndex = 29
        Me.lblVersion.Text = "Version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(243, 24)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "DriveTidy"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(124, 254)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel1.TabIndex = 25
        '
        'tbDescription
        '
        Me.tbDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbDescription.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescription.Location = New System.Drawing.Point(6, 132)
        Me.tbDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.tbDescription.Multiline = True
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.ReadOnly = True
        Me.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbDescription.Size = New System.Drawing.Size(240, 69)
        Me.tbDescription.TabIndex = 31
        Me.tbDescription.TabStop = False
        Me.tbDescription.Text = "A disk cleanup tool that throroughly scans your computer for unnecessary and inva" & _
            "lid files no longer being used by the system."
        '
        'flwButtons
        '
        Me.flwButtons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.flwButtons.AutoSize = True
        Me.flwButtons.Controls.Add(Me.cmdUpdate)
        Me.flwButtons.Controls.Add(Me.cmdReadMe)
        Me.flwButtons.Location = New System.Drawing.Point(33, 95)
        Me.flwButtons.Name = "flwButtons"
        Me.flwButtons.Size = New System.Drawing.Size(182, 31)
        Me.flwButtons.TabIndex = 26
        Me.flwButtons.WrapContents = False
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdClose.AutoSize = True
        Me.cmdClose.Location = New System.Drawing.Point(94, 224)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(61, 25)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(108, 3)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(32, 32)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbLogo.TabIndex = 28
        Me.pbLogo.TabStop = False
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(249, 254)
        Me.Controls.Add(Me.tblDesign)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About DriveTidy"
        Me.tblDesign.ResumeLayout(False)
        Me.tblDesign.PerformLayout()
        Me.flwContact.ResumeLayout(False)
        Me.flwContact.PerformLayout()
        Me.flwButtons.ResumeLayout(False)
        Me.flwButtons.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdReadMe As System.Windows.Forms.Button
    Friend WithEvents lblEmail As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents tblDesign As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flwContact As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flwButtons As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents tbDescription As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
End Class
