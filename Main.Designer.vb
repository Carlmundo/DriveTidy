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
        Me.cbMessenger = New System.Windows.Forms.CheckBox
        Me.cbFlash = New System.Windows.Forms.CheckBox
        Me.cbWindowsUpdate = New System.Windows.Forms.CheckBox
        Me.cbSafari = New System.Windows.Forms.CheckBox
        Me.cmdClean = New System.Windows.Forms.Button
        Me.cmdAdvanced = New System.Windows.Forms.Button
        Me.cmdQuick = New System.Windows.Forms.Button
        Me.cmdSelectAll = New System.Windows.Forms.LinkLabel
        Me.cbTIF = New System.Windows.Forms.CheckBox
        Me.cbRecent = New System.Windows.Forms.CheckBox
        Me.cbTemp = New System.Windows.Forms.CheckBox
        Me.cbRecycle = New System.Windows.Forms.CheckBox
        Me.cbJava = New System.Windows.Forms.CheckBox
        Me.cbERR = New System.Windows.Forms.CheckBox
        Me.cb_MP = New System.Windows.Forms.CheckBox
        Me.cbDMP = New System.Windows.Forms.CheckBox
        Me.cbCHK = New System.Windows.Forms.CheckBox
        Me.cbLOG = New System.Windows.Forms.CheckBox
        Me.cbTMP = New System.Windows.Forms.CheckBox
        Me.lblNote = New System.Windows.Forms.Label
        Me.lblProductName = New System.Windows.Forms.Label
        Me.cmdAbout = New System.Windows.Forms.Button
        Me.FlowLayout = New System.Windows.Forms.FlowLayoutPanel
        Me.lblSystem = New System.Windows.Forms.Label
        Me.cbErrorReports = New System.Windows.Forms.CheckBox
        Me.lblInternet = New System.Windows.Forms.Label
        Me.cbFirefox = New System.Windows.Forms.CheckBox
        Me.cbChrome = New System.Windows.Forms.CheckBox
        Me.cbOpera = New System.Windows.Forms.CheckBox
        Me.lblMore = New System.Windows.Forms.Label
        Me.cbVistaSP1 = New System.Windows.Forms.CheckBox
        Me.cbVistaSP2 = New System.Windows.Forms.CheckBox
        Me.cbHibernate = New System.Windows.Forms.CheckBox
        Me.cbSampleVideos = New System.Windows.Forms.CheckBox
        Me.lblOtherApps = New System.Windows.Forms.Label
        Me.cbAdobeCameraRAW = New System.Windows.Forms.CheckBox
        Me.cbAdobeReader = New System.Windows.Forms.CheckBox
        Me.cbAppleInstaller = New System.Windows.Forms.CheckBox
        Me.cbAVG = New System.Windows.Forms.CheckBox
        Me.cbGIMP = New System.Windows.Forms.CheckBox
        Me.cbGoogleEarth = New System.Windows.Forms.CheckBox
        Me.cbGoogleUpdater = New System.Windows.Forms.CheckBox
        Me.cbHPDigitalImaging = New System.Windows.Forms.CheckBox
        Me.cbiTunes = New System.Windows.Forms.CheckBox
        Me.cbKaspersky = New System.Windows.Forms.CheckBox
        Me.cbNokiaOvi = New System.Windows.Forms.CheckBox
        Me.cbQuicktime = New System.Windows.Forms.CheckBox
        Me.cbSilverlight = New System.Windows.Forms.CheckBox
        Me.cbSpotify = New System.Windows.Forms.CheckBox
        Me.cbSymantec = New System.Windows.Forms.CheckBox
        Me.cbUnity = New System.Windows.Forms.CheckBox
        Me.lblFileExt = New System.Windows.Forms.Label
        Me.tmSelectAll = New System.Windows.Forms.Timer(Me.components)
        Me.FlowLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbMessenger
        '
        Me.cbMessenger.AutoSize = True
        Me.cbMessenger.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMessenger.Location = New System.Drawing.Point(0, 252)
        Me.cbMessenger.Margin = New System.Windows.Forms.Padding(0)
        Me.cbMessenger.Name = "cbMessenger"
        Me.cbMessenger.Size = New System.Drawing.Size(80, 18)
        Me.cbMessenger.TabIndex = 12
        Me.cbMessenger.Text = "Messenger"
        Me.cbMessenger.UseVisualStyleBackColor = True
        '
        'cbFlash
        '
        Me.cbFlash.AutoSize = True
        Me.cbFlash.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFlash.Location = New System.Drawing.Point(0, 216)
        Me.cbFlash.Margin = New System.Windows.Forms.Padding(0)
        Me.cbFlash.Name = "cbFlash"
        Me.cbFlash.Size = New System.Drawing.Size(85, 18)
        Me.cbFlash.TabIndex = 10
        Me.cbFlash.Text = "Flash Player"
        Me.cbFlash.UseVisualStyleBackColor = True
        '
        'cbWindowsUpdate
        '
        Me.cbWindowsUpdate.AutoSize = True
        Me.cbWindowsUpdate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbWindowsUpdate.Location = New System.Drawing.Point(0, 72)
        Me.cbWindowsUpdate.Margin = New System.Windows.Forms.Padding(0)
        Me.cbWindowsUpdate.Name = "cbWindowsUpdate"
        Me.cbWindowsUpdate.Size = New System.Drawing.Size(143, 18)
        Me.cbWindowsUpdate.TabIndex = 3
        Me.cbWindowsUpdate.Text = "Windows Update Cache"
        Me.cbWindowsUpdate.UseVisualStyleBackColor = True
        '
        'cbSafari
        '
        Me.cbSafari.AutoSize = True
        Me.cbSafari.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSafari.Location = New System.Drawing.Point(0, 198)
        Me.cbSafari.Margin = New System.Windows.Forms.Padding(0)
        Me.cbSafari.Name = "cbSafari"
        Me.cbSafari.Size = New System.Drawing.Size(55, 18)
        Me.cbSafari.TabIndex = 9
        Me.cbSafari.Text = "Safari"
        Me.cbSafari.UseVisualStyleBackColor = True
        '
        'cmdClean
        '
        Me.cmdClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdClean.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClean.Location = New System.Drawing.Point(73, 282)
        Me.cmdClean.Name = "cmdClean"
        Me.cmdClean.Size = New System.Drawing.Size(102, 36)
        Me.cmdClean.TabIndex = 4
        Me.cmdClean.Text = "Start Cleanup"
        Me.cmdClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdClean.UseVisualStyleBackColor = True
        '
        'cmdAdvanced
        '
        Me.cmdAdvanced.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdvanced.Location = New System.Drawing.Point(124, 54)
        Me.cmdAdvanced.Name = "cmdAdvanced"
        Me.cmdAdvanced.Size = New System.Drawing.Size(85, 22)
        Me.cmdAdvanced.TabIndex = 2
        Me.cmdAdvanced.Text = "Advanced"
        Me.cmdAdvanced.UseVisualStyleBackColor = True
        '
        'cmdQuick
        '
        Me.cmdQuick.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuick.Location = New System.Drawing.Point(33, 54)
        Me.cmdQuick.Name = "cmdQuick"
        Me.cmdQuick.Size = New System.Drawing.Size(85, 22)
        Me.cmdQuick.TabIndex = 1
        Me.cmdQuick.Text = "Quick"
        Me.cmdQuick.UseVisualStyleBackColor = True
        '
        'cmdSelectAll
        '
        Me.cmdSelectAll.AutoSize = True
        Me.cmdSelectAll.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectAll.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.cmdSelectAll.Location = New System.Drawing.Point(7, 82)
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.Size = New System.Drawing.Size(52, 14)
        Me.cmdSelectAll.TabIndex = 3
        Me.cmdSelectAll.TabStop = True
        Me.cmdSelectAll.Text = "Select All"
        '
        'cbTIF
        '
        Me.cbTIF.AutoSize = True
        Me.cbTIF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTIF.Location = New System.Drawing.Point(0, 126)
        Me.cbTIF.Margin = New System.Windows.Forms.Padding(0)
        Me.cbTIF.Name = "cbTIF"
        Me.cbTIF.Size = New System.Drawing.Size(142, 18)
        Me.cbTIF.TabIndex = 5
        Me.cbTIF.Text = "Temporary Internet Files"
        Me.cbTIF.UseVisualStyleBackColor = True
        '
        'cbRecent
        '
        Me.cbRecent.AutoSize = True
        Me.cbRecent.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRecent.Location = New System.Drawing.Point(0, 54)
        Me.cbRecent.Margin = New System.Windows.Forms.Padding(0)
        Me.cbRecent.Name = "cbRecent"
        Me.cbRecent.Size = New System.Drawing.Size(157, 18)
        Me.cbRecent.TabIndex = 2
        Me.cbRecent.Text = "Recent Accessed File Data"
        Me.cbRecent.UseVisualStyleBackColor = True
        '
        'cbTemp
        '
        Me.cbTemp.AutoSize = True
        Me.cbTemp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTemp.Location = New System.Drawing.Point(0, 36)
        Me.cbTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.cbTemp.Name = "cbTemp"
        Me.cbTemp.Size = New System.Drawing.Size(103, 18)
        Me.cbTemp.TabIndex = 1
        Me.cbTemp.Text = "Temporary Files"
        Me.cbTemp.UseVisualStyleBackColor = True
        '
        'cbRecycle
        '
        Me.cbRecycle.AutoSize = True
        Me.cbRecycle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRecycle.Location = New System.Drawing.Point(0, 18)
        Me.cbRecycle.Margin = New System.Windows.Forms.Padding(0)
        Me.cbRecycle.Name = "cbRecycle"
        Me.cbRecycle.Size = New System.Drawing.Size(83, 18)
        Me.cbRecycle.TabIndex = 0
        Me.cbRecycle.Text = "Recycle Bin"
        Me.cbRecycle.UseVisualStyleBackColor = True
        '
        'cbJava
        '
        Me.cbJava.AutoSize = True
        Me.cbJava.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJava.Location = New System.Drawing.Point(0, 234)
        Me.cbJava.Margin = New System.Windows.Forms.Padding(0)
        Me.cbJava.Name = "cbJava"
        Me.cbJava.Size = New System.Drawing.Size(49, 18)
        Me.cbJava.TabIndex = 11
        Me.cbJava.Text = "Java"
        Me.cbJava.UseVisualStyleBackColor = True
        '
        'cbERR
        '
        Me.cbERR.AutoSize = True
        Me.cbERR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbERR.Location = New System.Drawing.Point(0, 774)
        Me.cbERR.Margin = New System.Windows.Forms.Padding(0)
        Me.cbERR.Name = "cbERR"
        Me.cbERR.Size = New System.Drawing.Size(43, 18)
        Me.cbERR.TabIndex = 38
        Me.cbERR.Text = ".err"
        Me.cbERR.UseVisualStyleBackColor = True
        '
        'cb_MP
        '
        Me.cb_MP.AutoSize = True
        Me.cb_MP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_MP.Location = New System.Drawing.Point(0, 756)
        Me.cb_MP.Margin = New System.Windows.Forms.Padding(0)
        Me.cb_MP.Name = "cb_MP"
        Me.cb_MP.Size = New System.Drawing.Size(49, 18)
        Me.cb_MP.TabIndex = 37
        Me.cb_MP.Text = "._mp"
        Me.cb_MP.UseVisualStyleBackColor = True
        '
        'cbDMP
        '
        Me.cbDMP.AutoSize = True
        Me.cbDMP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDMP.Location = New System.Drawing.Point(0, 738)
        Me.cbDMP.Margin = New System.Windows.Forms.Padding(0)
        Me.cbDMP.Name = "cbDMP"
        Me.cbDMP.Size = New System.Drawing.Size(49, 18)
        Me.cbDMP.TabIndex = 36
        Me.cbDMP.Text = ".dmp"
        Me.cbDMP.UseVisualStyleBackColor = True
        '
        'cbCHK
        '
        Me.cbCHK.AutoSize = True
        Me.cbCHK.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCHK.Location = New System.Drawing.Point(0, 720)
        Me.cbCHK.Margin = New System.Windows.Forms.Padding(0)
        Me.cbCHK.Name = "cbCHK"
        Me.cbCHK.Size = New System.Drawing.Size(46, 18)
        Me.cbCHK.TabIndex = 35
        Me.cbCHK.Text = ".chk"
        Me.cbCHK.UseVisualStyleBackColor = True
        '
        'cbLOG
        '
        Me.cbLOG.AutoSize = True
        Me.cbLOG.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLOG.Location = New System.Drawing.Point(0, 702)
        Me.cbLOG.Margin = New System.Windows.Forms.Padding(0)
        Me.cbLOG.Name = "cbLOG"
        Me.cbLOG.Size = New System.Drawing.Size(43, 18)
        Me.cbLOG.TabIndex = 34
        Me.cbLOG.Text = ".log"
        Me.cbLOG.UseVisualStyleBackColor = True
        '
        'cbTMP
        '
        Me.cbTMP.AutoSize = True
        Me.cbTMP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTMP.Location = New System.Drawing.Point(0, 684)
        Me.cbTMP.Margin = New System.Windows.Forms.Padding(0)
        Me.cbTMP.Name = "cbTMP"
        Me.cbTMP.Size = New System.Drawing.Size(46, 18)
        Me.cbTMP.TabIndex = 33
        Me.cbTMP.Text = ".tmp"
        Me.cbTMP.UseVisualStyleBackColor = True
        '
        'lblNote
        '
        Me.lblNote.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(1, 37)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(248, 14)
        Me.lblNote.TabIndex = 1
        Me.lblNote.Text = "BETA"
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(61, 9)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(121, 28)
        Me.lblProductName.TabIndex = 0
        Me.lblProductName.Text = "DriveTidy"
        '
        'cmdAbout
        '
        Me.cmdAbout.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.Location = New System.Drawing.Point(209, 9)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(28, 28)
        Me.cmdAbout.TabIndex = 0
        Me.cmdAbout.Text = "?"
        Me.cmdAbout.UseVisualStyleBackColor = True
        '
        'FlowLayout
        '
        Me.FlowLayout.AutoScroll = True
        Me.FlowLayout.Controls.Add(Me.lblSystem)
        Me.FlowLayout.Controls.Add(Me.cbRecycle)
        Me.FlowLayout.Controls.Add(Me.cbTemp)
        Me.FlowLayout.Controls.Add(Me.cbRecent)
        Me.FlowLayout.Controls.Add(Me.cbWindowsUpdate)
        Me.FlowLayout.Controls.Add(Me.cbErrorReports)
        Me.FlowLayout.Controls.Add(Me.lblInternet)
        Me.FlowLayout.Controls.Add(Me.cbTIF)
        Me.FlowLayout.Controls.Add(Me.cbFirefox)
        Me.FlowLayout.Controls.Add(Me.cbChrome)
        Me.FlowLayout.Controls.Add(Me.cbOpera)
        Me.FlowLayout.Controls.Add(Me.cbSafari)
        Me.FlowLayout.Controls.Add(Me.cbFlash)
        Me.FlowLayout.Controls.Add(Me.cbJava)
        Me.FlowLayout.Controls.Add(Me.cbMessenger)
        Me.FlowLayout.Controls.Add(Me.lblMore)
        Me.FlowLayout.Controls.Add(Me.cbVistaSP1)
        Me.FlowLayout.Controls.Add(Me.cbVistaSP2)
        Me.FlowLayout.Controls.Add(Me.cbHibernate)
        Me.FlowLayout.Controls.Add(Me.cbSampleVideos)
        Me.FlowLayout.Controls.Add(Me.lblOtherApps)
        Me.FlowLayout.Controls.Add(Me.cbAdobeCameraRAW)
        Me.FlowLayout.Controls.Add(Me.cbAdobeReader)
        Me.FlowLayout.Controls.Add(Me.cbAppleInstaller)
        Me.FlowLayout.Controls.Add(Me.cbAVG)
        Me.FlowLayout.Controls.Add(Me.cbGIMP)
        Me.FlowLayout.Controls.Add(Me.cbGoogleEarth)
        Me.FlowLayout.Controls.Add(Me.cbGoogleUpdater)
        Me.FlowLayout.Controls.Add(Me.cbHPDigitalImaging)
        Me.FlowLayout.Controls.Add(Me.cbiTunes)
        Me.FlowLayout.Controls.Add(Me.cbKaspersky)
        Me.FlowLayout.Controls.Add(Me.cbNokiaOvi)
        Me.FlowLayout.Controls.Add(Me.cbQuicktime)
        Me.FlowLayout.Controls.Add(Me.cbSilverlight)
        Me.FlowLayout.Controls.Add(Me.cbSpotify)
        Me.FlowLayout.Controls.Add(Me.cbSymantec)
        Me.FlowLayout.Controls.Add(Me.cbUnity)
        Me.FlowLayout.Controls.Add(Me.lblFileExt)
        Me.FlowLayout.Controls.Add(Me.cbTMP)
        Me.FlowLayout.Controls.Add(Me.cbLOG)
        Me.FlowLayout.Controls.Add(Me.cbCHK)
        Me.FlowLayout.Controls.Add(Me.cbDMP)
        Me.FlowLayout.Controls.Add(Me.cb_MP)
        Me.FlowLayout.Controls.Add(Me.cbERR)
        Me.FlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayout.Location = New System.Drawing.Point(19, 99)
        Me.FlowLayout.Name = "FlowLayout"
        Me.FlowLayout.Size = New System.Drawing.Size(210, 182)
        Me.FlowLayout.TabIndex = 4
        Me.FlowLayout.WrapContents = False
        '
        'lblSystem
        '
        Me.lblSystem.AutoSize = True
        Me.lblSystem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystem.Location = New System.Drawing.Point(3, 0)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(48, 18)
        Me.lblSystem.TabIndex = 0
        Me.lblSystem.Text = "System"
        Me.lblSystem.UseCompatibleTextRendering = True
        '
        'cbErrorReports
        '
        Me.cbErrorReports.AutoSize = True
        Me.cbErrorReports.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbErrorReports.Location = New System.Drawing.Point(0, 90)
        Me.cbErrorReports.Margin = New System.Windows.Forms.Padding(0)
        Me.cbErrorReports.Name = "cbErrorReports"
        Me.cbErrorReports.Size = New System.Drawing.Size(91, 18)
        Me.cbErrorReports.TabIndex = 4
        Me.cbErrorReports.Text = "Error Reports"
        Me.cbErrorReports.UseVisualStyleBackColor = True
        '
        'lblInternet
        '
        Me.lblInternet.AutoSize = True
        Me.lblInternet.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInternet.Location = New System.Drawing.Point(3, 108)
        Me.lblInternet.Name = "lblInternet"
        Me.lblInternet.Size = New System.Drawing.Size(50, 18)
        Me.lblInternet.TabIndex = 1
        Me.lblInternet.Text = "Internet"
        Me.lblInternet.UseCompatibleTextRendering = True
        '
        'cbFirefox
        '
        Me.cbFirefox.AutoSize = True
        Me.cbFirefox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFirefox.Location = New System.Drawing.Point(0, 144)
        Me.cbFirefox.Margin = New System.Windows.Forms.Padding(0)
        Me.cbFirefox.Name = "cbFirefox"
        Me.cbFirefox.Size = New System.Drawing.Size(95, 18)
        Me.cbFirefox.TabIndex = 6
        Me.cbFirefox.Text = "Mozilla Firefox"
        Me.cbFirefox.UseVisualStyleBackColor = True
        '
        'cbChrome
        '
        Me.cbChrome.AutoSize = True
        Me.cbChrome.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChrome.Location = New System.Drawing.Point(0, 162)
        Me.cbChrome.Margin = New System.Windows.Forms.Padding(0)
        Me.cbChrome.Name = "cbChrome"
        Me.cbChrome.Size = New System.Drawing.Size(100, 18)
        Me.cbChrome.TabIndex = 7
        Me.cbChrome.Text = "Google Chrome"
        Me.cbChrome.UseVisualStyleBackColor = True
        '
        'cbOpera
        '
        Me.cbOpera.AutoSize = True
        Me.cbOpera.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOpera.Location = New System.Drawing.Point(0, 180)
        Me.cbOpera.Margin = New System.Windows.Forms.Padding(0)
        Me.cbOpera.Name = "cbOpera"
        Me.cbOpera.Size = New System.Drawing.Size(56, 18)
        Me.cbOpera.TabIndex = 8
        Me.cbOpera.Text = "Opera"
        Me.cbOpera.UseVisualStyleBackColor = True
        '
        'lblMore
        '
        Me.lblMore.AutoSize = True
        Me.lblMore.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMore.Location = New System.Drawing.Point(3, 270)
        Me.lblMore.Name = "lblMore"
        Me.lblMore.Size = New System.Drawing.Size(44, 18)
        Me.lblMore.TabIndex = 2
        Me.lblMore.Text = "More..."
        Me.lblMore.UseCompatibleTextRendering = True
        '
        'cbVistaSP1
        '
        Me.cbVistaSP1.AutoSize = True
        Me.cbVistaSP1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVistaSP1.Location = New System.Drawing.Point(0, 288)
        Me.cbVistaSP1.Margin = New System.Windows.Forms.Padding(0)
        Me.cbVistaSP1.Name = "cbVistaSP1"
        Me.cbVistaSP1.Size = New System.Drawing.Size(115, 18)
        Me.cbVistaSP1.TabIndex = 13
        Me.cbVistaSP1.Text = "Vista SP1 Cleanup"
        Me.cbVistaSP1.UseVisualStyleBackColor = True
        '
        'cbVistaSP2
        '
        Me.cbVistaSP2.AutoSize = True
        Me.cbVistaSP2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVistaSP2.Location = New System.Drawing.Point(0, 306)
        Me.cbVistaSP2.Margin = New System.Windows.Forms.Padding(0)
        Me.cbVistaSP2.Name = "cbVistaSP2"
        Me.cbVistaSP2.Size = New System.Drawing.Size(115, 18)
        Me.cbVistaSP2.TabIndex = 14
        Me.cbVistaSP2.Text = "Vista SP2 Cleanup"
        Me.cbVistaSP2.UseVisualStyleBackColor = True
        '
        'cbHibernate
        '
        Me.cbHibernate.AutoSize = True
        Me.cbHibernate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHibernate.Location = New System.Drawing.Point(0, 324)
        Me.cbHibernate.Margin = New System.Windows.Forms.Padding(0)
        Me.cbHibernate.Name = "cbHibernate"
        Me.cbHibernate.Size = New System.Drawing.Size(110, 18)
        Me.cbHibernate.TabIndex = 15
        Me.cbHibernate.Text = "Disable Hibernate"
        Me.cbHibernate.UseVisualStyleBackColor = True
        '
        'cbSampleVideos
        '
        Me.cbSampleVideos.AutoSize = True
        Me.cbSampleVideos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSampleVideos.Location = New System.Drawing.Point(0, 342)
        Me.cbSampleVideos.Margin = New System.Windows.Forms.Padding(0)
        Me.cbSampleVideos.Name = "cbSampleVideos"
        Me.cbSampleVideos.Size = New System.Drawing.Size(98, 18)
        Me.cbSampleVideos.TabIndex = 16
        Me.cbSampleVideos.Text = "Sample Videos"
        Me.cbSampleVideos.UseVisualStyleBackColor = True
        '
        'lblOtherApps
        '
        Me.lblOtherApps.AutoSize = True
        Me.lblOtherApps.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtherApps.Location = New System.Drawing.Point(3, 360)
        Me.lblOtherApps.Name = "lblOtherApps"
        Me.lblOtherApps.Size = New System.Drawing.Size(115, 18)
        Me.lblOtherApps.TabIndex = 3
        Me.lblOtherApps.Text = "Other Applications"
        Me.lblOtherApps.UseCompatibleTextRendering = True
        '
        'cbAdobeCameraRAW
        '
        Me.cbAdobeCameraRAW.AutoSize = True
        Me.cbAdobeCameraRAW.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAdobeCameraRAW.Location = New System.Drawing.Point(0, 378)
        Me.cbAdobeCameraRAW.Margin = New System.Windows.Forms.Padding(0)
        Me.cbAdobeCameraRAW.Name = "cbAdobeCameraRAW"
        Me.cbAdobeCameraRAW.Size = New System.Drawing.Size(126, 18)
        Me.cbAdobeCameraRAW.TabIndex = 17
        Me.cbAdobeCameraRAW.Text = "Adobe Camera RAW"
        Me.cbAdobeCameraRAW.UseVisualStyleBackColor = True
        '
        'cbAdobeReader
        '
        Me.cbAdobeReader.AutoSize = True
        Me.cbAdobeReader.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAdobeReader.Location = New System.Drawing.Point(0, 396)
        Me.cbAdobeReader.Margin = New System.Windows.Forms.Padding(0)
        Me.cbAdobeReader.Name = "cbAdobeReader"
        Me.cbAdobeReader.Size = New System.Drawing.Size(96, 18)
        Me.cbAdobeReader.TabIndex = 18
        Me.cbAdobeReader.Text = "Adobe Reader"
        Me.cbAdobeReader.UseVisualStyleBackColor = True
        '
        'cbAppleInstaller
        '
        Me.cbAppleInstaller.AutoSize = True
        Me.cbAppleInstaller.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAppleInstaller.Location = New System.Drawing.Point(0, 414)
        Me.cbAppleInstaller.Margin = New System.Windows.Forms.Padding(0)
        Me.cbAppleInstaller.Name = "cbAppleInstaller"
        Me.cbAppleInstaller.Size = New System.Drawing.Size(94, 18)
        Me.cbAppleInstaller.TabIndex = 19
        Me.cbAppleInstaller.Text = "Apple Installer"
        Me.cbAppleInstaller.UseVisualStyleBackColor = True
        '
        'cbAVG
        '
        Me.cbAVG.AutoSize = True
        Me.cbAVG.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAVG.Location = New System.Drawing.Point(0, 432)
        Me.cbAVG.Margin = New System.Windows.Forms.Padding(0)
        Me.cbAVG.Name = "cbAVG"
        Me.cbAVG.Size = New System.Drawing.Size(50, 18)
        Me.cbAVG.TabIndex = 20
        Me.cbAVG.Text = "AVG"
        Me.cbAVG.UseVisualStyleBackColor = True
        '
        'cbGIMP
        '
        Me.cbGIMP.AutoSize = True
        Me.cbGIMP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGIMP.Location = New System.Drawing.Point(0, 450)
        Me.cbGIMP.Margin = New System.Windows.Forms.Padding(0)
        Me.cbGIMP.Name = "cbGIMP"
        Me.cbGIMP.Size = New System.Drawing.Size(50, 18)
        Me.cbGIMP.TabIndex = 21
        Me.cbGIMP.Text = "GIMP"
        Me.cbGIMP.UseVisualStyleBackColor = True
        '
        'cbGoogleEarth
        '
        Me.cbGoogleEarth.AutoSize = True
        Me.cbGoogleEarth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGoogleEarth.Location = New System.Drawing.Point(0, 468)
        Me.cbGoogleEarth.Margin = New System.Windows.Forms.Padding(0)
        Me.cbGoogleEarth.Name = "cbGoogleEarth"
        Me.cbGoogleEarth.Size = New System.Drawing.Size(88, 18)
        Me.cbGoogleEarth.TabIndex = 22
        Me.cbGoogleEarth.Text = "Google Earth"
        Me.cbGoogleEarth.UseVisualStyleBackColor = True
        '
        'cbGoogleUpdater
        '
        Me.cbGoogleUpdater.AutoSize = True
        Me.cbGoogleUpdater.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGoogleUpdater.Location = New System.Drawing.Point(0, 486)
        Me.cbGoogleUpdater.Margin = New System.Windows.Forms.Padding(0)
        Me.cbGoogleUpdater.Name = "cbGoogleUpdater"
        Me.cbGoogleUpdater.Size = New System.Drawing.Size(101, 18)
        Me.cbGoogleUpdater.TabIndex = 23
        Me.cbGoogleUpdater.Text = "Google Updater"
        Me.cbGoogleUpdater.UseVisualStyleBackColor = True
        '
        'cbHPDigitalImaging
        '
        Me.cbHPDigitalImaging.AutoSize = True
        Me.cbHPDigitalImaging.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHPDigitalImaging.Location = New System.Drawing.Point(0, 504)
        Me.cbHPDigitalImaging.Margin = New System.Windows.Forms.Padding(0)
        Me.cbHPDigitalImaging.Name = "cbHPDigitalImaging"
        Me.cbHPDigitalImaging.Size = New System.Drawing.Size(109, 18)
        Me.cbHPDigitalImaging.TabIndex = 24
        Me.cbHPDigitalImaging.Text = "HP Digital Imaging"
        Me.cbHPDigitalImaging.UseVisualStyleBackColor = True
        '
        'cbiTunes
        '
        Me.cbiTunes.AutoSize = True
        Me.cbiTunes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbiTunes.Location = New System.Drawing.Point(0, 522)
        Me.cbiTunes.Margin = New System.Windows.Forms.Padding(0)
        Me.cbiTunes.Name = "cbiTunes"
        Me.cbiTunes.Size = New System.Drawing.Size(58, 18)
        Me.cbiTunes.TabIndex = 25
        Me.cbiTunes.Text = "iTunes"
        Me.cbiTunes.UseVisualStyleBackColor = True
        '
        'cbKaspersky
        '
        Me.cbKaspersky.AutoSize = True
        Me.cbKaspersky.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKaspersky.Location = New System.Drawing.Point(0, 540)
        Me.cbKaspersky.Margin = New System.Windows.Forms.Padding(0)
        Me.cbKaspersky.Name = "cbKaspersky"
        Me.cbKaspersky.Size = New System.Drawing.Size(78, 18)
        Me.cbKaspersky.TabIndex = 26
        Me.cbKaspersky.Text = "Kaspersky"
        Me.cbKaspersky.UseVisualStyleBackColor = True
        '
        'cbNokiaOvi
        '
        Me.cbNokiaOvi.AutoSize = True
        Me.cbNokiaOvi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNokiaOvi.Location = New System.Drawing.Point(0, 558)
        Me.cbNokiaOvi.Margin = New System.Windows.Forms.Padding(0)
        Me.cbNokiaOvi.Name = "cbNokiaOvi"
        Me.cbNokiaOvi.Size = New System.Drawing.Size(98, 18)
        Me.cbNokiaOvi.TabIndex = 0
        Me.cbNokiaOvi.Text = "Nokia Ovi Suite"
        Me.cbNokiaOvi.UseVisualStyleBackColor = True
        '
        'cbQuicktime
        '
        Me.cbQuicktime.AutoSize = True
        Me.cbQuicktime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbQuicktime.Location = New System.Drawing.Point(0, 576)
        Me.cbQuicktime.Margin = New System.Windows.Forms.Padding(0)
        Me.cbQuicktime.Name = "cbQuicktime"
        Me.cbQuicktime.Size = New System.Drawing.Size(72, 18)
        Me.cbQuicktime.TabIndex = 28
        Me.cbQuicktime.Text = "Quicktime"
        Me.cbQuicktime.UseVisualStyleBackColor = True
        '
        'cbSilverlight
        '
        Me.cbSilverlight.AutoSize = True
        Me.cbSilverlight.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSilverlight.Location = New System.Drawing.Point(0, 594)
        Me.cbSilverlight.Margin = New System.Windows.Forms.Padding(0)
        Me.cbSilverlight.Name = "cbSilverlight"
        Me.cbSilverlight.Size = New System.Drawing.Size(72, 18)
        Me.cbSilverlight.TabIndex = 29
        Me.cbSilverlight.Text = "Silverlight"
        Me.cbSilverlight.UseVisualStyleBackColor = True
        '
        'cbSpotify
        '
        Me.cbSpotify.AutoSize = True
        Me.cbSpotify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSpotify.Location = New System.Drawing.Point(0, 612)
        Me.cbSpotify.Margin = New System.Windows.Forms.Padding(0)
        Me.cbSpotify.Name = "cbSpotify"
        Me.cbSpotify.Size = New System.Drawing.Size(60, 18)
        Me.cbSpotify.TabIndex = 30
        Me.cbSpotify.Text = "Spotify"
        Me.cbSpotify.UseVisualStyleBackColor = True
        '
        'cbSymantec
        '
        Me.cbSymantec.AutoSize = True
        Me.cbSymantec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSymantec.Location = New System.Drawing.Point(0, 630)
        Me.cbSymantec.Margin = New System.Windows.Forms.Padding(0)
        Me.cbSymantec.Name = "cbSymantec"
        Me.cbSymantec.Size = New System.Drawing.Size(74, 18)
        Me.cbSymantec.TabIndex = 31
        Me.cbSymantec.Text = "Symantec" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cbSymantec.UseVisualStyleBackColor = True
        '
        'cbUnity
        '
        Me.cbUnity.AutoSize = True
        Me.cbUnity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUnity.Location = New System.Drawing.Point(0, 648)
        Me.cbUnity.Margin = New System.Windows.Forms.Padding(0)
        Me.cbUnity.Name = "cbUnity"
        Me.cbUnity.Size = New System.Drawing.Size(108, 18)
        Me.cbUnity.TabIndex = 32
        Me.cbUnity.Text = "Unity Web Player"
        Me.cbUnity.UseVisualStyleBackColor = True
        '
        'lblFileExt
        '
        Me.lblFileExt.AutoSize = True
        Me.lblFileExt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileExt.Location = New System.Drawing.Point(3, 666)
        Me.lblFileExt.Name = "lblFileExt"
        Me.lblFileExt.Size = New System.Drawing.Size(95, 18)
        Me.lblFileExt.TabIndex = 4
        Me.lblFileExt.Text = "File Extensions"
        Me.lblFileExt.UseCompatibleTextRendering = True
        '
        'tmSelectAll
        '
        Me.tmSelectAll.Enabled = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 328)
        Me.Controls.Add(Me.FlowLayout)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.cmdClean)
        Me.Controls.Add(Me.cmdAdvanced)
        Me.Controls.Add(Me.cmdQuick)
        Me.Controls.Add(Me.cmdSelectAll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "DriveTidy"
        Me.FlowLayout.ResumeLayout(False)
        Me.FlowLayout.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbMessenger As System.Windows.Forms.CheckBox
    Friend WithEvents cbFlash As System.Windows.Forms.CheckBox
    Friend WithEvents cbWindowsUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents cbSafari As System.Windows.Forms.CheckBox
    Friend WithEvents cmdClean As System.Windows.Forms.Button
    Friend WithEvents cmdAdvanced As System.Windows.Forms.Button
    Friend WithEvents cmdQuick As System.Windows.Forms.Button
    Friend WithEvents cmdSelectAll As System.Windows.Forms.LinkLabel
    Friend WithEvents cbTIF As System.Windows.Forms.CheckBox
    Friend WithEvents cbRecent As System.Windows.Forms.CheckBox
    Friend WithEvents cbTemp As System.Windows.Forms.CheckBox
    Friend WithEvents cbRecycle As System.Windows.Forms.CheckBox
    Friend WithEvents cbJava As System.Windows.Forms.CheckBox
    Friend WithEvents cbERR As System.Windows.Forms.CheckBox
    Friend WithEvents cb_MP As System.Windows.Forms.CheckBox
    Friend WithEvents cbDMP As System.Windows.Forms.CheckBox
    Friend WithEvents cbCHK As System.Windows.Forms.CheckBox
    Friend WithEvents cbLOG As System.Windows.Forms.CheckBox
    Friend WithEvents cbTMP As System.Windows.Forms.CheckBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents cmdAbout As System.Windows.Forms.Button
    Friend WithEvents FlowLayout As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cbVistaSP1 As System.Windows.Forms.CheckBox
    Friend WithEvents cbVistaSP2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbAdobeReader As System.Windows.Forms.CheckBox
    Friend WithEvents cbAdobeCameraRAW As System.Windows.Forms.CheckBox
    Friend WithEvents cbAppleInstaller As System.Windows.Forms.CheckBox
    Friend WithEvents cbAVG As System.Windows.Forms.CheckBox
    Friend WithEvents cbGIMP As System.Windows.Forms.CheckBox
    Friend WithEvents cbGoogleEarth As System.Windows.Forms.CheckBox
    Friend WithEvents cbGoogleUpdater As System.Windows.Forms.CheckBox
    Friend WithEvents cbHPDigitalImaging As System.Windows.Forms.CheckBox
    Friend WithEvents cbiTunes As System.Windows.Forms.CheckBox
    Friend WithEvents cbKaspersky As System.Windows.Forms.CheckBox
    Friend WithEvents cbNokiaOvi As System.Windows.Forms.CheckBox
    Friend WithEvents cbSilverlight As System.Windows.Forms.CheckBox
    Friend WithEvents cbQuicktime As System.Windows.Forms.CheckBox
    Friend WithEvents cbSpotify As System.Windows.Forms.CheckBox
    Friend WithEvents cbUnity As System.Windows.Forms.CheckBox
    Friend WithEvents cbSampleVideos As System.Windows.Forms.CheckBox
    Friend WithEvents cbErrorReports As System.Windows.Forms.CheckBox
    Friend WithEvents cbHibernate As System.Windows.Forms.CheckBox
    Friend WithEvents cbSymantec As System.Windows.Forms.CheckBox
    Friend WithEvents lblSystem As System.Windows.Forms.Label
    Friend WithEvents lblFileExt As System.Windows.Forms.Label
    Friend WithEvents tmSelectAll As System.Windows.Forms.Timer
    Friend WithEvents lblInternet As System.Windows.Forms.Label
    Friend WithEvents cbFirefox As System.Windows.Forms.CheckBox
    Friend WithEvents cbOpera As System.Windows.Forms.CheckBox
    Friend WithEvents cbChrome As System.Windows.Forms.CheckBox
    Friend WithEvents lblMore As System.Windows.Forms.Label
    Friend WithEvents lblOtherApps As System.Windows.Forms.Label
End Class
