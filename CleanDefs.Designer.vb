﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CleanDefs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CleanDefs))
        Me.txtHeader = New System.Windows.Forms.TextBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblRecycle = New System.Windows.Forms.Label()
        Me.txtRecycle = New System.Windows.Forms.TextBox()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.lblRecent = New System.Windows.Forms.Label()
        Me.txtRecent = New System.Windows.Forms.TextBox()
        Me.lblTIF = New System.Windows.Forms.Label()
        Me.txtTIF = New System.Windows.Forms.TextBox()
        Me.lblFirefox = New System.Windows.Forms.Label()
        Me.txtFirefox = New System.Windows.Forms.TextBox()
        Me.lblWindowsUpdate = New System.Windows.Forms.Label()
        Me.txtWindowsUpdate = New System.Windows.Forms.TextBox()
        Me.lblJava = New System.Windows.Forms.Label()
        Me.txtJava = New System.Windows.Forms.TextBox()
        Me.lblFlash = New System.Windows.Forms.Label()
        Me.txtFlash = New System.Windows.Forms.TextBox()
        Me.lblMessenger = New System.Windows.Forms.Label()
        Me.txtMessenger = New System.Windows.Forms.TextBox()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.txtStart1 = New System.Windows.Forms.TextBox()
        Me.txtTMP = New System.Windows.Forms.TextBox()
        Me.txtLOG = New System.Windows.Forms.TextBox()
        Me.txtCHK = New System.Windows.Forms.TextBox()
        Me.txtDMP = New System.Windows.Forms.TextBox()
        Me.txt_MP = New System.Windows.Forms.TextBox()
        Me.txtERR = New System.Windows.Forms.TextBox()
        Me.lblFinish = New System.Windows.Forms.Label()
        Me.txtFinish = New System.Windows.Forms.TextBox()
        Me.txtStart2 = New System.Windows.Forms.TextBox()
        Me.txtOpera = New System.Windows.Forms.TextBox()
        Me.txtChrome = New System.Windows.Forms.TextBox()
        Me.lblOpera = New System.Windows.Forms.Label()
        Me.txtSafari = New System.Windows.Forms.TextBox()
        Me.lblChrome = New System.Windows.Forms.Label()
        Me.lblSafari = New System.Windows.Forms.Label()
        Me.txtErrorReports = New System.Windows.Forms.TextBox()
        Me.lblErrorReports = New System.Windows.Forms.Label()
        Me.lblFileExt = New System.Windows.Forms.Label()
        Me.txtTIF_IE6 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHeader
        '
        Me.txtHeader.Location = New System.Drawing.Point(4, 143)
        Me.txtHeader.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHeader.Multiline = True
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(337, 90)
        Me.txtHeader.TabIndex = 23
        Me.txtHeader.Text = "@echo off" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cd %temp%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo DriveTidy %version%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo %osd%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo ================" &
    "==" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(4, 110)
        Me.lblHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(93, 29)
        Me.lblHeader.TabIndex = 24
        Me.lblHeader.Text = "Header"
        '
        'lblRecycle
        '
        Me.lblRecycle.AutoSize = True
        Me.lblRecycle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecycle.Location = New System.Drawing.Point(4, 237)
        Me.lblRecycle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecycle.Name = "lblRecycle"
        Me.lblRecycle.Size = New System.Drawing.Size(148, 29)
        Me.lblRecycle.TabIndex = 26
        Me.lblRecycle.Text = "Recycle Bin"
        '
        'txtRecycle
        '
        Me.txtRecycle.Location = New System.Drawing.Point(4, 270)
        Me.txtRecycle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRecycle.Multiline = True
        Me.txtRecycle.Name = "txtRecycle"
        Me.txtRecycle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecycle.Size = New System.Drawing.Size(337, 77)
        Me.txtRecycle.TabIndex = 25
        Me.txtRecycle.Text = "echo Q1 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo [Emptying Recycle Bin for %syst" &
    "emdrive%\ ...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /a /f /s /q ""%recycle%"""
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp.Location = New System.Drawing.Point(4, 351)
        Me.lblTemp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(196, 29)
        Me.lblTemp.TabIndex = 28
        Me.lblTemp.Text = "Temporary Files"
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(4, 384)
        Me.txtTemp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTemp.Multiline = True
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTemp.Size = New System.Drawing.Size(337, 67)
        Me.txtTemp.TabIndex = 27
        Me.txtTemp.Text = resources.GetString("txtTemp.Text")
        '
        'lblRecent
        '
        Me.lblRecent.AutoSize = True
        Me.lblRecent.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecent.Location = New System.Drawing.Point(4, 455)
        Me.lblRecent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecent.Name = "lblRecent"
        Me.lblRecent.Size = New System.Drawing.Size(315, 29)
        Me.lblRecent.TabIndex = 30
        Me.lblRecent.Text = "Recent Accessed File Data"
        '
        'txtRecent
        '
        Me.txtRecent.Location = New System.Drawing.Point(4, 488)
        Me.txtRecent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRecent.Multiline = True
        Me.txtRecent.Name = "txtRecent"
        Me.txtRecent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecent.Size = New System.Drawing.Size(337, 67)
        Me.txtRecent.TabIndex = 29
        Me.txtRecent.Text = "echo Q3 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo [Recent accessed file data...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%recent%""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /a /f /s /q ""%appdata%\Microsoft\Office\Recent\*"""
        '
        'lblTIF
        '
        Me.lblTIF.AutoSize = True
        Me.lblTIF.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTIF.Location = New System.Drawing.Point(4, 781)
        Me.lblTIF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTIF.Name = "lblTIF"
        Me.lblTIF.Size = New System.Drawing.Size(291, 29)
        Me.lblTIF.TabIndex = 32
        Me.lblTIF.Text = "Temporary Internet Files"
        '
        'txtTIF
        '
        Me.txtTIF.Location = New System.Drawing.Point(4, 814)
        Me.txtTIF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTIF.Multiline = True
        Me.txtTIF.Name = "txtTIF"
        Me.txtTIF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTIF.Size = New System.Drawing.Size(337, 72)
        Me.txtTIF.TabIndex = 31
        Me.txtTIF.Text = resources.GetString("txtTIF.Text")
        '
        'lblFirefox
        '
        Me.lblFirefox.AutoSize = True
        Me.lblFirefox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirefox.Location = New System.Drawing.Point(4, 999)
        Me.lblFirefox.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirefox.Name = "lblFirefox"
        Me.lblFirefox.Size = New System.Drawing.Size(93, 29)
        Me.lblFirefox.TabIndex = 34
        Me.lblFirefox.Text = "Firefox"
        '
        'txtFirefox
        '
        Me.txtFirefox.Location = New System.Drawing.Point(4, 1032)
        Me.txtFirefox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFirefox.Multiline = True
        Me.txtFirefox.Name = "txtFirefox"
        Me.txtFirefox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFirefox.Size = New System.Drawing.Size(337, 73)
        Me.txtFirefox.TabIndex = 33
        Me.txtFirefox.Text = resources.GetString("txtFirefox.Text")
        '
        'lblWindowsUpdate
        '
        Me.lblWindowsUpdate.AutoSize = True
        Me.lblWindowsUpdate.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWindowsUpdate.Location = New System.Drawing.Point(4, 559)
        Me.lblWindowsUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWindowsUpdate.Name = "lblWindowsUpdate"
        Me.lblWindowsUpdate.Size = New System.Drawing.Size(208, 29)
        Me.lblWindowsUpdate.TabIndex = 36
        Me.lblWindowsUpdate.Text = "Windows Update"
        '
        'txtWindowsUpdate
        '
        Me.txtWindowsUpdate.Location = New System.Drawing.Point(4, 592)
        Me.txtWindowsUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWindowsUpdate.Multiline = True
        Me.txtWindowsUpdate.Name = "txtWindowsUpdate"
        Me.txtWindowsUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWindowsUpdate.Size = New System.Drawing.Size(337, 74)
        Me.txtWindowsUpdate.TabIndex = 35
        Me.txtWindowsUpdate.Text = resources.GetString("txtWindowsUpdate.Text")
        '
        'lblJava
        '
        Me.lblJava.AutoSize = True
        Me.lblJava.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJava.Location = New System.Drawing.Point(4, 1551)
        Me.lblJava.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJava.Name = "lblJava"
        Me.lblJava.Size = New System.Drawing.Size(65, 29)
        Me.lblJava.TabIndex = 38
        Me.lblJava.Text = "Java"
        '
        'txtJava
        '
        Me.txtJava.Location = New System.Drawing.Point(4, 1584)
        Me.txtJava.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtJava.Multiline = True
        Me.txtJava.Name = "txtJava"
        Me.txtJava.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJava.Size = New System.Drawing.Size(337, 77)
        Me.txtJava.TabIndex = 37
        Me.txtJava.Text = resources.GetString("txtJava.Text")
        '
        'lblFlash
        '
        Me.lblFlash.AutoSize = True
        Me.lblFlash.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlash.Location = New System.Drawing.Point(4, 1439)
        Me.lblFlash.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFlash.Name = "lblFlash"
        Me.lblFlash.Size = New System.Drawing.Size(154, 29)
        Me.lblFlash.TabIndex = 40
        Me.lblFlash.Text = "Flash Player"
        '
        'txtFlash
        '
        Me.txtFlash.Location = New System.Drawing.Point(4, 1472)
        Me.txtFlash.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFlash.Multiline = True
        Me.txtFlash.Name = "txtFlash"
        Me.txtFlash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFlash.Size = New System.Drawing.Size(337, 75)
        Me.txtFlash.TabIndex = 39
        Me.txtFlash.Text = resources.GetString("txtFlash.Text")
        '
        'lblMessenger
        '
        Me.lblMessenger.AutoSize = True
        Me.lblMessenger.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessenger.Location = New System.Drawing.Point(4, 1665)
        Me.lblMessenger.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMessenger.Name = "lblMessenger"
        Me.lblMessenger.Size = New System.Drawing.Size(138, 29)
        Me.lblMessenger.TabIndex = 42
        Me.lblMessenger.Text = "Messenger"
        '
        'txtMessenger
        '
        Me.txtMessenger.Location = New System.Drawing.Point(4, 1698)
        Me.txtMessenger.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMessenger.Multiline = True
        Me.txtMessenger.Name = "txtMessenger"
        Me.txtMessenger.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessenger.Size = New System.Drawing.Size(337, 77)
        Me.txtMessenger.TabIndex = 41
        Me.txtMessenger.Text = resources.GetString("txtMessenger.Text")
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(4, 0)
        Me.lblStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(67, 29)
        Me.lblStart.TabIndex = 45
        Me.lblStart.Text = "Start"
        '
        'txtStart1
        '
        Me.txtStart1.Location = New System.Drawing.Point(4, 33)
        Me.txtStart1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStart1.Multiline = True
        Me.txtStart1.Name = "txtStart1"
        Me.txtStart1.Size = New System.Drawing.Size(337, 38)
        Me.txtStart1.TabIndex = 51
        Me.txtStart1.Text = "%systemdrive%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cd ""%appdata%\DriveTidy\"""
        '
        'txtTMP
        '
        Me.txtTMP.Location = New System.Drawing.Point(4, 1812)
        Me.txtTMP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTMP.Multiline = True
        Me.txtTMP.Name = "txtTMP"
        Me.txtTMP.Size = New System.Drawing.Size(337, 63)
        Me.txtTMP.TabIndex = 52
        Me.txtTMP.Text = "echo F1 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo [.tmp files...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q %" &
    "systemdrive%\*.tmp"
        Me.txtTMP.WordWrap = False
        '
        'txtLOG
        '
        Me.txtLOG.Location = New System.Drawing.Point(4, 1883)
        Me.txtLOG.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLOG.Multiline = True
        Me.txtLOG.Name = "txtLOG"
        Me.txtLOG.Size = New System.Drawing.Size(337, 63)
        Me.txtLOG.TabIndex = 53
        Me.txtLOG.Text = "echo F2 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo [.log files...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q %" &
    "systemdrive%\*.log"
        Me.txtLOG.WordWrap = False
        '
        'txtCHK
        '
        Me.txtCHK.Location = New System.Drawing.Point(4, 1954)
        Me.txtCHK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCHK.Multiline = True
        Me.txtCHK.Name = "txtCHK"
        Me.txtCHK.Size = New System.Drawing.Size(337, 63)
        Me.txtCHK.TabIndex = 54
        Me.txtCHK.Text = "echo F3 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo [.chk files...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q %" &
    "systemdrive%\*.chk"
        Me.txtCHK.WordWrap = False
        '
        'txtDMP
        '
        Me.txtDMP.Location = New System.Drawing.Point(4, 2025)
        Me.txtDMP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDMP.Multiline = True
        Me.txtDMP.Name = "txtDMP"
        Me.txtDMP.Size = New System.Drawing.Size(337, 63)
        Me.txtDMP.TabIndex = 55
        Me.txtDMP.Text = "echo F4 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo [.dmp files...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q %" &
    "systemdrive%\*.dmp"
        Me.txtDMP.WordWrap = False
        '
        'txt_MP
        '
        Me.txt_MP.Location = New System.Drawing.Point(4, 2096)
        Me.txt_MP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_MP.Multiline = True
        Me.txt_MP.Name = "txt_MP"
        Me.txt_MP.Size = New System.Drawing.Size(337, 63)
        Me.txt_MP.TabIndex = 56
        Me.txt_MP.Text = "echo F5 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo [._mp files...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q %" &
    "systemdrive%\*._mp"
        Me.txt_MP.WordWrap = False
        '
        'txtERR
        '
        Me.txtERR.Location = New System.Drawing.Point(4, 2167)
        Me.txtERR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtERR.Multiline = True
        Me.txtERR.Name = "txtERR"
        Me.txtERR.Size = New System.Drawing.Size(337, 63)
        Me.txtERR.TabIndex = 57
        Me.txtERR.Text = "echo F6 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo [.err files...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q %" &
    "systemdrive%\*.err"
        Me.txtERR.WordWrap = False
        '
        'lblFinish
        '
        Me.lblFinish.AutoSize = True
        Me.lblFinish.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinish.Location = New System.Drawing.Point(4, 2234)
        Me.lblFinish.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFinish.Name = "lblFinish"
        Me.lblFinish.Size = New System.Drawing.Size(85, 29)
        Me.lblFinish.TabIndex = 60
        Me.lblFinish.Text = "Finish"
        '
        'txtFinish
        '
        Me.txtFinish.Location = New System.Drawing.Point(4, 2267)
        Me.txtFinish.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFinish.Multiline = True
        Me.txtFinish.Name = "txtFinish"
        Me.txtFinish.Size = New System.Drawing.Size(337, 66)
        Me.txtFinish.TabIndex = 59
        Me.txtFinish.Text = "echo ==================" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo [Cleanup Complete.]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo FIN >""%appdata%\DriveTidy" &
    "\cleanchk.txt"""
        '
        'txtStart2
        '
        Me.txtStart2.Location = New System.Drawing.Point(4, 79)
        Me.txtStart2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStart2.Multiline = True
        Me.txtStart2.Name = "txtStart2"
        Me.txtStart2.Size = New System.Drawing.Size(337, 27)
        Me.txtStart2.TabIndex = 63
        Me.txtStart2.Text = "cleaner.bat >""%appdata%\DriveTidy\log.txt"""
        '
        'txtOpera
        '
        Me.txtOpera.Location = New System.Drawing.Point(4, 1252)
        Me.txtOpera.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOpera.Multiline = True
        Me.txtOpera.Name = "txtOpera"
        Me.txtOpera.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOpera.Size = New System.Drawing.Size(337, 73)
        Me.txtOpera.TabIndex = 64
        Me.txtOpera.Text = resources.GetString("txtOpera.Text")
        '
        'txtChrome
        '
        Me.txtChrome.Location = New System.Drawing.Point(4, 1142)
        Me.txtChrome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtChrome.Multiline = True
        Me.txtChrome.Name = "txtChrome"
        Me.txtChrome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChrome.Size = New System.Drawing.Size(337, 73)
        Me.txtChrome.TabIndex = 65
        Me.txtChrome.Text = resources.GetString("txtChrome.Text")
        '
        'lblOpera
        '
        Me.lblOpera.AutoSize = True
        Me.lblOpera.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpera.Location = New System.Drawing.Point(4, 1219)
        Me.lblOpera.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpera.Name = "lblOpera"
        Me.lblOpera.Size = New System.Drawing.Size(81, 29)
        Me.lblOpera.TabIndex = 66
        Me.lblOpera.Text = "Opera"
        '
        'txtSafari
        '
        Me.txtSafari.Location = New System.Drawing.Point(4, 1362)
        Me.txtSafari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSafari.Multiline = True
        Me.txtSafari.Name = "txtSafari"
        Me.txtSafari.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSafari.Size = New System.Drawing.Size(337, 73)
        Me.txtSafari.TabIndex = 67
        Me.txtSafari.Text = resources.GetString("txtSafari.Text")
        '
        'lblChrome
        '
        Me.lblChrome.AutoSize = True
        Me.lblChrome.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChrome.Location = New System.Drawing.Point(4, 1109)
        Me.lblChrome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChrome.Name = "lblChrome"
        Me.lblChrome.Size = New System.Drawing.Size(103, 29)
        Me.lblChrome.TabIndex = 68
        Me.lblChrome.Text = "Chrome"
        '
        'lblSafari
        '
        Me.lblSafari.AutoSize = True
        Me.lblSafari.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSafari.Location = New System.Drawing.Point(4, 1329)
        Me.lblSafari.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSafari.Name = "lblSafari"
        Me.lblSafari.Size = New System.Drawing.Size(79, 29)
        Me.lblSafari.TabIndex = 69
        Me.lblSafari.Text = "Safari"
        '
        'txtErrorReports
        '
        Me.txtErrorReports.Location = New System.Drawing.Point(4, 703)
        Me.txtErrorReports.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtErrorReports.Multiline = True
        Me.txtErrorReports.Name = "txtErrorReports"
        Me.txtErrorReports.Size = New System.Drawing.Size(337, 74)
        Me.txtErrorReports.TabIndex = 70
        Me.txtErrorReports.Text = resources.GetString("txtErrorReports.Text")
        '
        'lblErrorReports
        '
        Me.lblErrorReports.AutoSize = True
        Me.lblErrorReports.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorReports.Location = New System.Drawing.Point(4, 670)
        Me.lblErrorReports.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblErrorReports.Name = "lblErrorReports"
        Me.lblErrorReports.Size = New System.Drawing.Size(168, 29)
        Me.lblErrorReports.TabIndex = 71
        Me.lblErrorReports.Text = "Error Reports"
        '
        'lblFileExt
        '
        Me.lblFileExt.AutoSize = True
        Me.lblFileExt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileExt.Location = New System.Drawing.Point(4, 1779)
        Me.lblFileExt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFileExt.Name = "lblFileExt"
        Me.lblFileExt.Size = New System.Drawing.Size(190, 29)
        Me.lblFileExt.TabIndex = 72
        Me.lblFileExt.Text = "File Extensions"
        '
        'txtTIF_IE6
        '
        Me.txtTIF_IE6.Location = New System.Drawing.Point(4, 923)
        Me.txtTIF_IE6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTIF_IE6.Multiline = True
        Me.txtTIF_IE6.Name = "txtTIF_IE6"
        Me.txtTIF_IE6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTIF_IE6.Size = New System.Drawing.Size(337, 72)
        Me.txtTIF_IE6.TabIndex = 74
        Me.txtTIF_IE6.Text = resources.GetString("txtTIF_IE6.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 890)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 29)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "TIF_IE6"
        '
        'FlowLayout
        '
        Me.FlowLayout.AutoScroll = True
        Me.FlowLayout.Controls.Add(Me.lblStart)
        Me.FlowLayout.Controls.Add(Me.txtStart1)
        Me.FlowLayout.Controls.Add(Me.txtStart2)
        Me.FlowLayout.Controls.Add(Me.lblHeader)
        Me.FlowLayout.Controls.Add(Me.txtHeader)
        Me.FlowLayout.Controls.Add(Me.lblRecycle)
        Me.FlowLayout.Controls.Add(Me.txtRecycle)
        Me.FlowLayout.Controls.Add(Me.lblTemp)
        Me.FlowLayout.Controls.Add(Me.txtTemp)
        Me.FlowLayout.Controls.Add(Me.lblRecent)
        Me.FlowLayout.Controls.Add(Me.txtRecent)
        Me.FlowLayout.Controls.Add(Me.lblWindowsUpdate)
        Me.FlowLayout.Controls.Add(Me.txtWindowsUpdate)
        Me.FlowLayout.Controls.Add(Me.lblErrorReports)
        Me.FlowLayout.Controls.Add(Me.txtErrorReports)
        Me.FlowLayout.Controls.Add(Me.lblTIF)
        Me.FlowLayout.Controls.Add(Me.txtTIF)
        Me.FlowLayout.Controls.Add(Me.Label1)
        Me.FlowLayout.Controls.Add(Me.txtTIF_IE6)
        Me.FlowLayout.Controls.Add(Me.lblFirefox)
        Me.FlowLayout.Controls.Add(Me.txtFirefox)
        Me.FlowLayout.Controls.Add(Me.lblChrome)
        Me.FlowLayout.Controls.Add(Me.txtChrome)
        Me.FlowLayout.Controls.Add(Me.lblOpera)
        Me.FlowLayout.Controls.Add(Me.txtOpera)
        Me.FlowLayout.Controls.Add(Me.lblSafari)
        Me.FlowLayout.Controls.Add(Me.txtSafari)
        Me.FlowLayout.Controls.Add(Me.lblFlash)
        Me.FlowLayout.Controls.Add(Me.txtFlash)
        Me.FlowLayout.Controls.Add(Me.lblJava)
        Me.FlowLayout.Controls.Add(Me.txtJava)
        Me.FlowLayout.Controls.Add(Me.lblMessenger)
        Me.FlowLayout.Controls.Add(Me.txtMessenger)
        Me.FlowLayout.Controls.Add(Me.lblFileExt)
        Me.FlowLayout.Controls.Add(Me.txtTMP)
        Me.FlowLayout.Controls.Add(Me.txtLOG)
        Me.FlowLayout.Controls.Add(Me.txtCHK)
        Me.FlowLayout.Controls.Add(Me.txtDMP)
        Me.FlowLayout.Controls.Add(Me.txt_MP)
        Me.FlowLayout.Controls.Add(Me.txtERR)
        Me.FlowLayout.Controls.Add(Me.lblFinish)
        Me.FlowLayout.Controls.Add(Me.txtFinish)
        Me.FlowLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayout.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayout.Name = "FlowLayout"
        Me.FlowLayout.Size = New System.Drawing.Size(375, 321)
        Me.FlowLayout.TabIndex = 77
        Me.FlowLayout.WrapContents = False
        '
        'CleanDefs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 321)
        Me.Controls.Add(Me.FlowLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CleanDefs"
        Me.FlowLayout.ResumeLayout(False)
        Me.FlowLayout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtHeader As System.Windows.Forms.TextBox
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblRecycle As System.Windows.Forms.Label
    Friend WithEvents txtRecycle As System.Windows.Forms.TextBox
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents txtTemp As System.Windows.Forms.TextBox
    Friend WithEvents lblRecent As System.Windows.Forms.Label
    Friend WithEvents txtRecent As System.Windows.Forms.TextBox
    Friend WithEvents lblTIF As System.Windows.Forms.Label
    Friend WithEvents txtTIF As System.Windows.Forms.TextBox
    Friend WithEvents lblFirefox As System.Windows.Forms.Label
    Friend WithEvents txtFirefox As System.Windows.Forms.TextBox
    Friend WithEvents lblWindowsUpdate As System.Windows.Forms.Label
    Friend WithEvents txtWindowsUpdate As System.Windows.Forms.TextBox
    Friend WithEvents lblJava As System.Windows.Forms.Label
    Friend WithEvents txtJava As System.Windows.Forms.TextBox
    Friend WithEvents lblFlash As System.Windows.Forms.Label
    Friend WithEvents txtFlash As System.Windows.Forms.TextBox
    Friend WithEvents lblMessenger As System.Windows.Forms.Label
    Friend WithEvents txtMessenger As System.Windows.Forms.TextBox
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents txtStart1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTMP As System.Windows.Forms.TextBox
    Friend WithEvents txtLOG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHK As System.Windows.Forms.TextBox
    Friend WithEvents txtDMP As System.Windows.Forms.TextBox
    Friend WithEvents txt_MP As System.Windows.Forms.TextBox
    Friend WithEvents txtERR As System.Windows.Forms.TextBox
    Friend WithEvents lblFinish As System.Windows.Forms.Label
    Friend WithEvents txtFinish As System.Windows.Forms.TextBox
    Friend WithEvents txtStart2 As System.Windows.Forms.TextBox
    Friend WithEvents txtOpera As System.Windows.Forms.TextBox
    Friend WithEvents txtChrome As System.Windows.Forms.TextBox
    Friend WithEvents lblOpera As System.Windows.Forms.Label
    Friend WithEvents txtSafari As System.Windows.Forms.TextBox
    Friend WithEvents lblChrome As System.Windows.Forms.Label
    Friend WithEvents lblSafari As System.Windows.Forms.Label
    Friend WithEvents txtErrorReports As System.Windows.Forms.TextBox
    Friend WithEvents lblErrorReports As System.Windows.Forms.Label
    Friend WithEvents lblFileExt As System.Windows.Forms.Label
    Friend WithEvents txtTIF_IE6 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowLayout As System.Windows.Forms.FlowLayoutPanel
End Class
