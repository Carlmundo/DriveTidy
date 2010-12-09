<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommandList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CommandList))
        Me.txtHeader = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRecycle = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTemp = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRecent = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTIF = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtAltBrowser = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtWindowsUpdate = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtJava = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtFlash = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtMessenger = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtStart1 = New System.Windows.Forms.TextBox
        Me.txtTMP = New System.Windows.Forms.TextBox
        Me.txtLOG = New System.Windows.Forms.TextBox
        Me.txtCHK = New System.Windows.Forms.TextBox
        Me.txtDMP = New System.Windows.Forms.TextBox
        Me.txt_MP = New System.Windows.Forms.TextBox
        Me.txtERR = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFinish = New System.Windows.Forms.TextBox
        Me.txtAttribRecycle = New System.Windows.Forms.TextBox
        Me.txtAttribSQM = New System.Windows.Forms.TextBox
        Me.txtStart2 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtHeader
        '
        Me.txtHeader.Location = New System.Drawing.Point(378, 34)
        Me.txtHeader.Multiline = True
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(107, 84)
        Me.txtHeader.TabIndex = 23
        Me.txtHeader.Text = "@echo off" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cd %temp%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo DriveTidy %version%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo %osd%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo ..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(374, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 22)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Header"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 22)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Recycle Bin"
        '
        'txtRecycle
        '
        Me.txtRecycle.Location = New System.Drawing.Point(12, 151)
        Me.txtRecycle.Multiline = True
        Me.txtRecycle.Name = "txtRecycle"
        Me.txtRecycle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecycle.Size = New System.Drawing.Size(302, 55)
        Me.txtRecycle.TabIndex = 25
        Me.txtRecycle.Text = "echo Q1 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo Emptying Recycle Bin..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f" & _
            " /s /q ""%recycle%"""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 22)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Temporary files"
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(12, 234)
        Me.txtTemp.Multiline = True
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTemp.Size = New System.Drawing.Size(302, 72)
        Me.txtTemp.TabIndex = 27
        Me.txtTemp.Text = resources.GetString("txtTemp.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 22)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Recent accessed file data"
        '
        'txtRecent
        '
        Me.txtRecent.Location = New System.Drawing.Point(12, 334)
        Me.txtRecent.Multiline = True
        Me.txtRecent.Name = "txtRecent"
        Me.txtRecent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecent.Size = New System.Drawing.Size(302, 59)
        Me.txtRecent.TabIndex = 29
        Me.txtRecent.Text = "echo Q4 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo Clearing recent accessed file d" & _
            "ata..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%recent%""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%appdata%\Microsoft\Office\Recent" & _
            "\*.*"""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 396)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(232, 22)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Temporary internet files"
        '
        'txtTIF
        '
        Me.txtTIF.Location = New System.Drawing.Point(12, 421)
        Me.txtTIF.Multiline = True
        Me.txtTIF.Name = "txtTIF"
        Me.txtTIF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTIF.Size = New System.Drawing.Size(302, 63)
        Me.txtTIF.TabIndex = 31
        Me.txtTIF.Text = resources.GetString("txtTIF.Text")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 487)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 22)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Alt. Browser Caches"
        '
        'txtAltBrowser
        '
        Me.txtAltBrowser.Location = New System.Drawing.Point(12, 512)
        Me.txtAltBrowser.Multiline = True
        Me.txtAltBrowser.Name = "txtAltBrowser"
        Me.txtAltBrowser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAltBrowser.Size = New System.Drawing.Size(325, 95)
        Me.txtAltBrowser.TabIndex = 33
        Me.txtAltBrowser.Text = resources.GetString("txtAltBrowser.Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(339, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(225, 22)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Windows Update cache"
        '
        'txtWindowsUpdate
        '
        Me.txtWindowsUpdate.Location = New System.Drawing.Point(343, 151)
        Me.txtWindowsUpdate.Multiline = True
        Me.txtWindowsUpdate.Name = "txtWindowsUpdate"
        Me.txtWindowsUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWindowsUpdate.Size = New System.Drawing.Size(379, 61)
        Me.txtWindowsUpdate.TabIndex = 35
        Me.txtWindowsUpdate.Text = resources.GetString("txtWindowsUpdate.Text")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(339, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 22)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Java cache"
        '
        'txtJava
        '
        Me.txtJava.Location = New System.Drawing.Point(343, 240)
        Me.txtJava.Multiline = True
        Me.txtJava.Name = "txtJava"
        Me.txtJava.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJava.Size = New System.Drawing.Size(379, 63)
        Me.txtJava.TabIndex = 37
        Me.txtJava.Text = resources.GetString("txtJava.Text")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(339, 306)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 22)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Flash Player cache"
        '
        'txtFlash
        '
        Me.txtFlash.Location = New System.Drawing.Point(343, 331)
        Me.txtFlash.Multiline = True
        Me.txtFlash.Name = "txtFlash"
        Me.txtFlash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFlash.Size = New System.Drawing.Size(379, 62)
        Me.txtFlash.TabIndex = 39
        Me.txtFlash.Text = resources.GetString("txtFlash.Text")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(342, 396)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(175, 22)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Messenger cache"
        '
        'txtMessenger
        '
        Me.txtMessenger.Location = New System.Drawing.Point(346, 421)
        Me.txtMessenger.Multiline = True
        Me.txtMessenger.Name = "txtMessenger"
        Me.txtMessenger.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessenger.Size = New System.Drawing.Size(376, 128)
        Me.txtMessenger.TabIndex = 41
        Me.txtMessenger.Text = resources.GetString("txtMessenger.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 22)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "CleanerStart"
        '
        'txtStart1
        '
        Me.txtStart1.Location = New System.Drawing.Point(13, 34)
        Me.txtStart1.Multiline = True
        Me.txtStart1.Name = "txtStart1"
        Me.txtStart1.Size = New System.Drawing.Size(164, 40)
        Me.txtStart1.TabIndex = 51
        Me.txtStart1.Text = "%systemdrive%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cd %appdata%\DriveTidy\"
        '
        'txtTMP
        '
        Me.txtTMP.Location = New System.Drawing.Point(12, 622)
        Me.txtTMP.Multiline = True
        Me.txtTMP.Name = "txtTMP"
        Me.txtTMP.Size = New System.Drawing.Size(182, 52)
        Me.txtTMP.TabIndex = 52
        Me.txtTMP.Text = "echo F1 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo Clearing .tmp files..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f " & _
            "/s /q %systemdrive%\*.tmp"
        Me.txtTMP.WordWrap = False
        '
        'txtLOG
        '
        Me.txtLOG.Location = New System.Drawing.Point(200, 622)
        Me.txtLOG.Multiline = True
        Me.txtLOG.Name = "txtLOG"
        Me.txtLOG.Size = New System.Drawing.Size(172, 52)
        Me.txtLOG.TabIndex = 53
        Me.txtLOG.Text = "echo F2 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo Clearing .log files..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f " & _
            "/s /q %systemdrive%\*.log"
        Me.txtLOG.WordWrap = False
        '
        'txtCHK
        '
        Me.txtCHK.Location = New System.Drawing.Point(378, 622)
        Me.txtCHK.Multiline = True
        Me.txtCHK.Name = "txtCHK"
        Me.txtCHK.Size = New System.Drawing.Size(174, 52)
        Me.txtCHK.TabIndex = 54
        Me.txtCHK.Text = "echo F3 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo Clearing .chk files..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f " & _
            "/s /q %systemdrive%\*.chk"
        Me.txtCHK.WordWrap = False
        '
        'txtDMP
        '
        Me.txtDMP.Location = New System.Drawing.Point(558, 622)
        Me.txtDMP.Multiline = True
        Me.txtDMP.Name = "txtDMP"
        Me.txtDMP.Size = New System.Drawing.Size(164, 52)
        Me.txtDMP.TabIndex = 55
        Me.txtDMP.Text = "echo F4 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo Clearing .dmp files..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f " & _
            "/s /q %systemdrive%\*.dmp"
        Me.txtDMP.WordWrap = False
        '
        'txt_MP
        '
        Me.txt_MP.Location = New System.Drawing.Point(13, 680)
        Me.txt_MP.Multiline = True
        Me.txt_MP.Name = "txt_MP"
        Me.txt_MP.Size = New System.Drawing.Size(181, 52)
        Me.txt_MP.TabIndex = 56
        Me.txt_MP.Text = "echo F5 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo Clearing ._mp files..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f " & _
            "/s /q %systemdrive%\*._mp"
        Me.txt_MP.WordWrap = False
        '
        'txtERR
        '
        Me.txtERR.Location = New System.Drawing.Point(200, 680)
        Me.txtERR.Multiline = True
        Me.txtERR.Name = "txtERR"
        Me.txtERR.Size = New System.Drawing.Size(172, 52)
        Me.txtERR.TabIndex = 57
        Me.txtERR.Text = "echo F6 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo Clearing .err files..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f " & _
            "/s /q %systemdrive%\*.err"
        Me.txtERR.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(485, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 22)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Finish"
        '
        'txtFinish
        '
        Me.txtFinish.Location = New System.Drawing.Point(489, 34)
        Me.txtFinish.Multiline = True
        Me.txtFinish.Name = "txtFinish"
        Me.txtFinish.Size = New System.Drawing.Size(238, 84)
        Me.txtFinish.TabIndex = 59
        Me.txtFinish.Text = "echo ..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo Cleanup Complete." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo FIN >""%appdata%\DriveTidy\cleanchk.txt"""
        '
        'txtAttribRecycle
        '
        Me.txtAttribRecycle.Location = New System.Drawing.Point(183, 34)
        Me.txtAttribRecycle.Multiline = True
        Me.txtAttribRecycle.Name = "txtAttribRecycle"
        Me.txtAttribRecycle.Size = New System.Drawing.Size(98, 84)
        Me.txtAttribRecycle.TabIndex = 61
        Me.txtAttribRecycle.Text = ":AttribRecycle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IF NOT EXIST ""%recycle%"" GOTO EndAttribRecycle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "attrib -r -s -h /" & _
            "s /d ""%recycle%\*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":EndAttribRecycle"
        '
        'txtAttribSQM
        '
        Me.txtAttribSQM.Location = New System.Drawing.Point(287, 34)
        Me.txtAttribSQM.Multiline = True
        Me.txtAttribSQM.Name = "txtAttribSQM"
        Me.txtAttribSQM.Size = New System.Drawing.Size(85, 84)
        Me.txtAttribSQM.TabIndex = 62
        Me.txtAttribSQM.Text = ":AttribSQM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IF NOT EXIST ""%systemdrive%\*.sqm"" GOTO EndAttribSQM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "attrib -r -s -h" & _
            " +a ""%systemdrive%\*.sqm""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":EndAttribSQM"
        '
        'txtStart2
        '
        Me.txtStart2.Location = New System.Drawing.Point(13, 78)
        Me.txtStart2.Multiline = True
        Me.txtStart2.Name = "txtStart2"
        Me.txtStart2.Size = New System.Drawing.Size(164, 40)
        Me.txtStart2.TabIndex = 63
        Me.txtStart2.Text = "cleaner.bat >""%appdata%\DriveTidy\log.txt"""
        '
        'CommandList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 748)
        Me.Controls.Add(Me.txtStart2)
        Me.Controls.Add(Me.txtAttribSQM)
        Me.Controls.Add(Me.txtAttribRecycle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFinish)
        Me.Controls.Add(Me.txtERR)
        Me.Controls.Add(Me.txt_MP)
        Me.Controls.Add(Me.txtDMP)
        Me.Controls.Add(Me.txtCHK)
        Me.Controls.Add(Me.txtLOG)
        Me.Controls.Add(Me.txtTMP)
        Me.Controls.Add(Me.txtStart1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtMessenger)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtFlash)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtJava)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtWindowsUpdate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAltBrowser)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTIF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRecent)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRecycle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CommandList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHeader As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRecycle As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRecent As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTIF As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAltBrowser As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtWindowsUpdate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtJava As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFlash As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMessenger As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStart1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTMP As System.Windows.Forms.TextBox
    Friend WithEvents txtLOG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHK As System.Windows.Forms.TextBox
    Friend WithEvents txtDMP As System.Windows.Forms.TextBox
    Friend WithEvents txt_MP As System.Windows.Forms.TextBox
    Friend WithEvents txtERR As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFinish As System.Windows.Forms.TextBox
    Friend WithEvents txtAttribRecycle As System.Windows.Forms.TextBox
    Friend WithEvents txtAttribSQM As System.Windows.Forms.TextBox
    Friend WithEvents txtStart2 As System.Windows.Forms.TextBox
End Class
