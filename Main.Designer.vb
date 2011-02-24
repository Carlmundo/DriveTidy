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
        Me.tmSelectAll = New System.Windows.Forms.Timer(Me.components)
        Me.lblNote = New System.Windows.Forms.Label
        Me.lblProductName = New System.Windows.Forms.Label
        Me.flwOptions = New System.Windows.Forms.FlowLayoutPanel
        Me.lblSystem = New System.Windows.Forms.Label
        Me.cbRecycle = New System.Windows.Forms.CheckBox
        Me.cbTemp = New System.Windows.Forms.CheckBox
        Me.cbRecent = New System.Windows.Forms.CheckBox
        Me.cbWindowsUpdate = New System.Windows.Forms.CheckBox
        Me.cbErrorReports = New System.Windows.Forms.CheckBox
        Me.lblInternet = New System.Windows.Forms.Label
        Me.cbTIF = New System.Windows.Forms.CheckBox
        Me.cbFirefox = New System.Windows.Forms.CheckBox
        Me.cbChrome = New System.Windows.Forms.CheckBox
        Me.cbOpera = New System.Windows.Forms.CheckBox
        Me.cbSafari = New System.Windows.Forms.CheckBox
        Me.cbFlash = New System.Windows.Forms.CheckBox
        Me.cbJava = New System.Windows.Forms.CheckBox
        Me.cbMessenger = New System.Windows.Forms.CheckBox
        Me.lblMore = New System.Windows.Forms.Label
        Me.cbVistaSP1 = New System.Windows.Forms.CheckBox
        Me.cbVistaSP2 = New System.Windows.Forms.CheckBox
        Me.cbHibernate = New System.Windows.Forms.CheckBox
        Me.cbSampleMusic = New System.Windows.Forms.CheckBox
        Me.cbSamplePictures = New System.Windows.Forms.CheckBox
        Me.cbSampleVideos = New System.Windows.Forms.CheckBox
        Me.lblOtherApps = New System.Windows.Forms.Label
        Me.cbAdobeCameraRAW = New System.Windows.Forms.CheckBox
        Me.cbAdobeReader = New System.Windows.Forms.CheckBox
        Me.cbAppleInstaller = New System.Windows.Forms.CheckBox
        Me.cbAutoDesk = New System.Windows.Forms.CheckBox
        Me.cbAVG = New System.Windows.Forms.CheckBox
        Me.cbBigFishGames = New System.Windows.Forms.CheckBox
        Me.cbGIMP = New System.Windows.Forms.CheckBox
        Me.cbGoogleEarth = New System.Windows.Forms.CheckBox
        Me.cbGoogleUpdater = New System.Windows.Forms.CheckBox
        Me.cbHPDigitalImaging = New System.Windows.Forms.CheckBox
        Me.cbIMVU = New System.Windows.Forms.CheckBox
        Me.cbiTunes = New System.Windows.Forms.CheckBox
        Me.cbJagex = New System.Windows.Forms.CheckBox
        Me.cbKaspersky = New System.Windows.Forms.CheckBox
        Me.cbNokiaOvi = New System.Windows.Forms.CheckBox
        Me.cbQuicktime = New System.Windows.Forms.CheckBox
        Me.cbRealPlayer = New System.Windows.Forms.CheckBox
        Me.cbRDP = New System.Windows.Forms.CheckBox
        Me.cbSilverlight = New System.Windows.Forms.CheckBox
        Me.cbSpotify = New System.Windows.Forms.CheckBox
        Me.cbSymantec = New System.Windows.Forms.CheckBox
        Me.cbTrackmania = New System.Windows.Forms.CheckBox
        Me.cbUnity = New System.Windows.Forms.CheckBox
        Me.lblFileExt = New System.Windows.Forms.Label
        Me.cbTMP = New System.Windows.Forms.CheckBox
        Me.cbLOG = New System.Windows.Forms.CheckBox
        Me.cbCHK = New System.Windows.Forms.CheckBox
        Me.cbDMP = New System.Windows.Forms.CheckBox
        Me.cb_MP = New System.Windows.Forms.CheckBox
        Me.cbERR = New System.Windows.Forms.CheckBox
        Me.cmdClean = New System.Windows.Forms.Button
        Me.cmdSelectAll = New System.Windows.Forms.LinkLabel
        Me.cmdAdvanced = New System.Windows.Forms.Button
        Me.cmdQuick = New System.Windows.Forms.Button
        Me.tblDesign = New System.Windows.Forms.TableLayoutPanel
        Me.flwPresets = New System.Windows.Forms.FlowLayoutPanel
        Me.cmdAbout = New System.Windows.Forms.Button
        Me.cbMSI = New System.Windows.Forms.CheckBox
        Me.cbThumbnails = New System.Windows.Forms.CheckBox
        Me.flwOptions.SuspendLayout()
        Me.tblDesign.SuspendLayout()
        Me.flwPresets.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmSelectAll
        '
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNote.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(13, 38)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(223, 15)
        Me.lblNote.TabIndex = 1
        Me.lblNote.Text = "BETA"
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProductName.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(10, 10)
        Me.lblProductName.Margin = New System.Windows.Forms.Padding(0)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(229, 28)
        Me.lblProductName.TabIndex = 0
        Me.lblProductName.Text = "DriveTidy"
        Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flwOptions
        '
        Me.flwOptions.AutoScroll = True
        Me.flwOptions.Controls.Add(Me.lblSystem)
        Me.flwOptions.Controls.Add(Me.cbRecycle)
        Me.flwOptions.Controls.Add(Me.cbTemp)
        Me.flwOptions.Controls.Add(Me.cbRecent)
        Me.flwOptions.Controls.Add(Me.cbWindowsUpdate)
        Me.flwOptions.Controls.Add(Me.cbErrorReports)
        Me.flwOptions.Controls.Add(Me.lblInternet)
        Me.flwOptions.Controls.Add(Me.cbTIF)
        Me.flwOptions.Controls.Add(Me.cbFirefox)
        Me.flwOptions.Controls.Add(Me.cbChrome)
        Me.flwOptions.Controls.Add(Me.cbOpera)
        Me.flwOptions.Controls.Add(Me.cbSafari)
        Me.flwOptions.Controls.Add(Me.cbFlash)
        Me.flwOptions.Controls.Add(Me.cbJava)
        Me.flwOptions.Controls.Add(Me.cbMessenger)
        Me.flwOptions.Controls.Add(Me.lblMore)
        Me.flwOptions.Controls.Add(Me.cbVistaSP1)
        Me.flwOptions.Controls.Add(Me.cbVistaSP2)
        Me.flwOptions.Controls.Add(Me.cbHibernate)
        Me.flwOptions.Controls.Add(Me.cbThumbnails)
        Me.flwOptions.Controls.Add(Me.cbMSI)
        Me.flwOptions.Controls.Add(Me.cbSampleMusic)
        Me.flwOptions.Controls.Add(Me.cbSamplePictures)
        Me.flwOptions.Controls.Add(Me.cbSampleVideos)
        Me.flwOptions.Controls.Add(Me.lblOtherApps)
        Me.flwOptions.Controls.Add(Me.cbAdobeCameraRAW)
        Me.flwOptions.Controls.Add(Me.cbAdobeReader)
        Me.flwOptions.Controls.Add(Me.cbAppleInstaller)
        Me.flwOptions.Controls.Add(Me.cbAutoDesk)
        Me.flwOptions.Controls.Add(Me.cbAVG)
        Me.flwOptions.Controls.Add(Me.cbBigFishGames)
        Me.flwOptions.Controls.Add(Me.cbGIMP)
        Me.flwOptions.Controls.Add(Me.cbGoogleEarth)
        Me.flwOptions.Controls.Add(Me.cbGoogleUpdater)
        Me.flwOptions.Controls.Add(Me.cbHPDigitalImaging)
        Me.flwOptions.Controls.Add(Me.cbIMVU)
        Me.flwOptions.Controls.Add(Me.cbiTunes)
        Me.flwOptions.Controls.Add(Me.cbJagex)
        Me.flwOptions.Controls.Add(Me.cbKaspersky)
        Me.flwOptions.Controls.Add(Me.cbNokiaOvi)
        Me.flwOptions.Controls.Add(Me.cbQuicktime)
        Me.flwOptions.Controls.Add(Me.cbRealPlayer)
        Me.flwOptions.Controls.Add(Me.cbRDP)
        Me.flwOptions.Controls.Add(Me.cbSilverlight)
        Me.flwOptions.Controls.Add(Me.cbSpotify)
        Me.flwOptions.Controls.Add(Me.cbSymantec)
        Me.flwOptions.Controls.Add(Me.cbTrackmania)
        Me.flwOptions.Controls.Add(Me.cbUnity)
        Me.flwOptions.Controls.Add(Me.lblFileExt)
        Me.flwOptions.Controls.Add(Me.cbTMP)
        Me.flwOptions.Controls.Add(Me.cbLOG)
        Me.flwOptions.Controls.Add(Me.cbCHK)
        Me.flwOptions.Controls.Add(Me.cbDMP)
        Me.flwOptions.Controls.Add(Me.cb_MP)
        Me.flwOptions.Controls.Add(Me.cbERR)
        Me.flwOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flwOptions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flwOptions.Location = New System.Drawing.Point(13, 94)
        Me.flwOptions.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.flwOptions.Name = "flwOptions"
        Me.flwOptions.Size = New System.Drawing.Size(223, 209)
        Me.flwOptions.TabIndex = 4
        Me.flwOptions.WrapContents = False
        '
        'lblSystem
        '
        Me.lblSystem.AutoSize = True
        Me.lblSystem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystem.Location = New System.Drawing.Point(3, 0)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(52, 20)
        Me.lblSystem.TabIndex = 0
        Me.lblSystem.Text = "System"
        Me.lblSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSystem.UseCompatibleTextRendering = True
        '
        'cbRecycle
        '
        Me.cbRecycle.AutoSize = True
        Me.cbRecycle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRecycle.Location = New System.Drawing.Point(0, 20)
        Me.cbRecycle.Margin = New System.Windows.Forms.Padding(0)
        Me.cbRecycle.Name = "cbRecycle"
        Me.cbRecycle.Size = New System.Drawing.Size(90, 19)
        Me.cbRecycle.TabIndex = 1
        Me.cbRecycle.Text = "Recycle Bin"
        Me.cbRecycle.UseVisualStyleBackColor = True
        '
        'cbTemp
        '
        Me.cbTemp.AutoSize = True
        Me.cbTemp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTemp.Location = New System.Drawing.Point(0, 39)
        Me.cbTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.cbTemp.Name = "cbTemp"
        Me.cbTemp.Size = New System.Drawing.Size(115, 19)
        Me.cbTemp.TabIndex = 2
        Me.cbTemp.Text = "Temporary Files"
        Me.cbTemp.UseVisualStyleBackColor = True
        '
        'cbRecent
        '
        Me.cbRecent.AutoSize = True
        Me.cbRecent.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRecent.Location = New System.Drawing.Point(0, 58)
        Me.cbRecent.Margin = New System.Windows.Forms.Padding(0)
        Me.cbRecent.Name = "cbRecent"
        Me.cbRecent.Size = New System.Drawing.Size(117, 19)
        Me.cbRecent.TabIndex = 3
        Me.cbRecent.Text = "Recent File Data"
        Me.cbRecent.UseVisualStyleBackColor = True
        '
        'cbWindowsUpdate
        '
        Me.cbWindowsUpdate.AutoSize = True
        Me.cbWindowsUpdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbWindowsUpdate.Location = New System.Drawing.Point(0, 77)
        Me.cbWindowsUpdate.Margin = New System.Windows.Forms.Padding(0)
        Me.cbWindowsUpdate.Name = "cbWindowsUpdate"
        Me.cbWindowsUpdate.Size = New System.Drawing.Size(159, 19)
        Me.cbWindowsUpdate.TabIndex = 4
        Me.cbWindowsUpdate.Text = "Windows Update Cache"
        Me.cbWindowsUpdate.UseVisualStyleBackColor = True
        '
        'cbErrorReports
        '
        Me.cbErrorReports.AutoSize = True
        Me.cbErrorReports.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbErrorReports.Location = New System.Drawing.Point(0, 96)
        Me.cbErrorReports.Margin = New System.Windows.Forms.Padding(0)
        Me.cbErrorReports.Name = "cbErrorReports"
        Me.cbErrorReports.Size = New System.Drawing.Size(100, 19)
        Me.cbErrorReports.TabIndex = 5
        Me.cbErrorReports.Text = "Error Reports"
        Me.cbErrorReports.UseVisualStyleBackColor = True
        '
        'lblInternet
        '
        Me.lblInternet.AutoSize = True
        Me.lblInternet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInternet.Location = New System.Drawing.Point(3, 115)
        Me.lblInternet.Name = "lblInternet"
        Me.lblInternet.Size = New System.Drawing.Size(54, 20)
        Me.lblInternet.TabIndex = 6
        Me.lblInternet.Text = "Internet"
        Me.lblInternet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblInternet.UseCompatibleTextRendering = True
        '
        'cbTIF
        '
        Me.cbTIF.AutoSize = True
        Me.cbTIF.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTIF.Location = New System.Drawing.Point(0, 135)
        Me.cbTIF.Margin = New System.Windows.Forms.Padding(0)
        Me.cbTIF.Name = "cbTIF"
        Me.cbTIF.Size = New System.Drawing.Size(159, 19)
        Me.cbTIF.TabIndex = 7
        Me.cbTIF.Text = "Temporary Internet Files"
        Me.cbTIF.UseVisualStyleBackColor = True
        '
        'cbFirefox
        '
        Me.cbFirefox.AutoSize = True
        Me.cbFirefox.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFirefox.Location = New System.Drawing.Point(0, 154)
        Me.cbFirefox.Margin = New System.Windows.Forms.Padding(0)
        Me.cbFirefox.Name = "cbFirefox"
        Me.cbFirefox.Size = New System.Drawing.Size(102, 19)
        Me.cbFirefox.TabIndex = 8
        Me.cbFirefox.Text = "Mozilla Firefox"
        Me.cbFirefox.UseVisualStyleBackColor = True
        '
        'cbChrome
        '
        Me.cbChrome.AutoSize = True
        Me.cbChrome.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChrome.Location = New System.Drawing.Point(0, 173)
        Me.cbChrome.Margin = New System.Windows.Forms.Padding(0)
        Me.cbChrome.Name = "cbChrome"
        Me.cbChrome.Size = New System.Drawing.Size(114, 19)
        Me.cbChrome.TabIndex = 9
        Me.cbChrome.Text = "Google Chrome"
        Me.cbChrome.UseVisualStyleBackColor = True
        '
        'cbOpera
        '
        Me.cbOpera.AutoSize = True
        Me.cbOpera.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOpera.Location = New System.Drawing.Point(0, 192)
        Me.cbOpera.Margin = New System.Windows.Forms.Padding(0)
        Me.cbOpera.Name = "cbOpera"
        Me.cbOpera.Size = New System.Drawing.Size(60, 19)
        Me.cbOpera.TabIndex = 10
        Me.cbOpera.Text = "Opera"
        Me.cbOpera.UseVisualStyleBackColor = True
        '
        'cbSafari
        '
        Me.cbSafari.AutoSize = True
        Me.cbSafari.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSafari.Location = New System.Drawing.Point(0, 211)
        Me.cbSafari.Margin = New System.Windows.Forms.Padding(0)
        Me.cbSafari.Name = "cbSafari"
        Me.cbSafari.Size = New System.Drawing.Size(58, 19)
        Me.cbSafari.TabIndex = 11
        Me.cbSafari.Text = "Safari"
        Me.cbSafari.UseVisualStyleBackColor = True
        '
        'cbFlash
        '
        Me.cbFlash.AutoSize = True
        Me.cbFlash.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFlash.Location = New System.Drawing.Point(0, 230)
        Me.cbFlash.Margin = New System.Windows.Forms.Padding(0)
        Me.cbFlash.Name = "cbFlash"
        Me.cbFlash.Size = New System.Drawing.Size(94, 19)
        Me.cbFlash.TabIndex = 12
        Me.cbFlash.Text = "Flash Player"
        Me.cbFlash.UseVisualStyleBackColor = True
        '
        'cbJava
        '
        Me.cbJava.AutoSize = True
        Me.cbJava.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJava.Location = New System.Drawing.Point(0, 249)
        Me.cbJava.Margin = New System.Windows.Forms.Padding(0)
        Me.cbJava.Name = "cbJava"
        Me.cbJava.Size = New System.Drawing.Size(51, 19)
        Me.cbJava.TabIndex = 13
        Me.cbJava.Text = "Java"
        Me.cbJava.UseVisualStyleBackColor = True
        '
        'cbMessenger
        '
        Me.cbMessenger.AutoSize = True
        Me.cbMessenger.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMessenger.Location = New System.Drawing.Point(0, 268)
        Me.cbMessenger.Margin = New System.Windows.Forms.Padding(0)
        Me.cbMessenger.Name = "cbMessenger"
        Me.cbMessenger.Size = New System.Drawing.Size(88, 19)
        Me.cbMessenger.TabIndex = 14
        Me.cbMessenger.Text = "Messenger"
        Me.cbMessenger.UseVisualStyleBackColor = True
        '
        'lblMore
        '
        Me.lblMore.AutoSize = True
        Me.lblMore.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMore.Location = New System.Drawing.Point(3, 287)
        Me.lblMore.Name = "lblMore"
        Me.lblMore.Size = New System.Drawing.Size(48, 20)
        Me.lblMore.TabIndex = 15
        Me.lblMore.Text = "More..."
        Me.lblMore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMore.UseCompatibleTextRendering = True
        '
        'cbVistaSP1
        '
        Me.cbVistaSP1.AutoSize = True
        Me.cbVistaSP1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVistaSP1.Location = New System.Drawing.Point(0, 307)
        Me.cbVistaSP1.Margin = New System.Windows.Forms.Padding(0)
        Me.cbVistaSP1.Name = "cbVistaSP1"
        Me.cbVistaSP1.Size = New System.Drawing.Size(129, 19)
        Me.cbVistaSP1.TabIndex = 16
        Me.cbVistaSP1.Text = "Vista SP1 Cleanup"
        Me.cbVistaSP1.UseVisualStyleBackColor = True
        '
        'cbVistaSP2
        '
        Me.cbVistaSP2.AutoSize = True
        Me.cbVistaSP2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVistaSP2.Location = New System.Drawing.Point(0, 326)
        Me.cbVistaSP2.Margin = New System.Windows.Forms.Padding(0)
        Me.cbVistaSP2.Name = "cbVistaSP2"
        Me.cbVistaSP2.Size = New System.Drawing.Size(129, 19)
        Me.cbVistaSP2.TabIndex = 17
        Me.cbVistaSP2.Text = "Vista SP2 Cleanup"
        Me.cbVistaSP2.UseVisualStyleBackColor = True
        '
        'cbHibernate
        '
        Me.cbHibernate.AutoSize = True
        Me.cbHibernate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHibernate.Location = New System.Drawing.Point(0, 345)
        Me.cbHibernate.Margin = New System.Windows.Forms.Padding(0)
        Me.cbHibernate.Name = "cbHibernate"
        Me.cbHibernate.Size = New System.Drawing.Size(126, 19)
        Me.cbHibernate.TabIndex = 18
        Me.cbHibernate.Text = "Disable Hibernate"
        Me.cbHibernate.UseVisualStyleBackColor = True
        '
        'cbSampleMusic
        '
        Me.cbSampleMusic.AutoSize = True
        Me.cbSampleMusic.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSampleMusic.Location = New System.Drawing.Point(0, 402)
        Me.cbSampleMusic.Margin = New System.Windows.Forms.Padding(0)
        Me.cbSampleMusic.Name = "cbSampleMusic"
        Me.cbSampleMusic.Size = New System.Drawing.Size(104, 19)
        Me.cbSampleMusic.TabIndex = 19
        Me.cbSampleMusic.Text = "Sample Music"
        Me.cbSampleMusic.UseVisualStyleBackColor = True
        '
        'cbSamplePictures
        '
        Me.cbSamplePictures.AutoSize = True
        Me.cbSamplePictures.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSamplePictures.Location = New System.Drawing.Point(0, 421)
        Me.cbSamplePictures.Margin = New System.Windows.Forms.Padding(0)
        Me.cbSamplePictures.Name = "cbSamplePictures"
        Me.cbSamplePictures.Size = New System.Drawing.Size(117, 19)
        Me.cbSamplePictures.TabIndex = 20
        Me.cbSamplePictures.Text = "Sample Pictures"
        Me.cbSamplePictures.UseVisualStyleBackColor = True
        '
        'cbSampleVideos
        '
        Me.cbSampleVideos.AutoSize = True
        Me.cbSampleVideos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSampleVideos.Location = New System.Drawing.Point(0, 440)
        Me.cbSampleVideos.Margin = New System.Windows.Forms.Padding(0)
        Me.cbSampleVideos.Name = "cbSampleVideos"
        Me.cbSampleVideos.Size = New System.Drawing.Size(110, 19)
        Me.cbSampleVideos.TabIndex = 21
        Me.cbSampleVideos.Text = "Sample Videos"
        Me.cbSampleVideos.UseVisualStyleBackColor = True
        '
        'lblOtherApps
        '
        Me.lblOtherApps.AutoSize = True
        Me.lblOtherApps.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtherApps.Location = New System.Drawing.Point(3, 459)
        Me.lblOtherApps.Name = "lblOtherApps"
        Me.lblOtherApps.Size = New System.Drawing.Size(125, 20)
        Me.lblOtherApps.TabIndex = 22
        Me.lblOtherApps.Text = "Other Applications"
        Me.lblOtherApps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblOtherApps.UseCompatibleTextRendering = True
        '
        'cbAdobeCameraRAW
        '
        Me.cbAdobeCameraRAW.AutoSize = True
        Me.cbAdobeCameraRAW.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAdobeCameraRAW.Location = New System.Drawing.Point(0, 479)
        Me.cbAdobeCameraRAW.Margin = New System.Windows.Forms.Padding(0)
        Me.cbAdobeCameraRAW.Name = "cbAdobeCameraRAW"
        Me.cbAdobeCameraRAW.Size = New System.Drawing.Size(139, 19)
        Me.cbAdobeCameraRAW.TabIndex = 23
        Me.cbAdobeCameraRAW.Text = "Adobe Camera RAW"
        Me.cbAdobeCameraRAW.UseVisualStyleBackColor = True
        '
        'cbAdobeReader
        '
        Me.cbAdobeReader.AutoSize = True
        Me.cbAdobeReader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAdobeReader.Location = New System.Drawing.Point(0, 498)
        Me.cbAdobeReader.Margin = New System.Windows.Forms.Padding(0)
        Me.cbAdobeReader.Name = "cbAdobeReader"
        Me.cbAdobeReader.Size = New System.Drawing.Size(105, 19)
        Me.cbAdobeReader.TabIndex = 24
        Me.cbAdobeReader.Text = "Adobe Reader"
        Me.cbAdobeReader.UseVisualStyleBackColor = True
        '
        'cbAppleInstaller
        '
        Me.cbAppleInstaller.AutoSize = True
        Me.cbAppleInstaller.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAppleInstaller.Location = New System.Drawing.Point(0, 517)
        Me.cbAppleInstaller.Margin = New System.Windows.Forms.Padding(0)
        Me.cbAppleInstaller.Name = "cbAppleInstaller"
        Me.cbAppleInstaller.Size = New System.Drawing.Size(104, 19)
        Me.cbAppleInstaller.TabIndex = 25
        Me.cbAppleInstaller.Text = "Apple Installer"
        Me.cbAppleInstaller.UseVisualStyleBackColor = True
        '
        'cbAutoDesk
        '
        Me.cbAutoDesk.AutoSize = True
        Me.cbAutoDesk.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAutoDesk.Location = New System.Drawing.Point(0, 536)
        Me.cbAutoDesk.Margin = New System.Windows.Forms.Padding(0)
        Me.cbAutoDesk.Name = "cbAutoDesk"
        Me.cbAutoDesk.Size = New System.Drawing.Size(79, 19)
        Me.cbAutoDesk.TabIndex = 26
        Me.cbAutoDesk.Text = "AutoDesk"
        Me.cbAutoDesk.UseVisualStyleBackColor = True
        '
        'cbAVG
        '
        Me.cbAVG.AutoSize = True
        Me.cbAVG.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAVG.Location = New System.Drawing.Point(0, 555)
        Me.cbAVG.Margin = New System.Windows.Forms.Padding(0)
        Me.cbAVG.Name = "cbAVG"
        Me.cbAVG.Size = New System.Drawing.Size(49, 19)
        Me.cbAVG.TabIndex = 27
        Me.cbAVG.Text = "AVG"
        Me.cbAVG.UseVisualStyleBackColor = True
        '
        'cbBigFishGames
        '
        Me.cbBigFishGames.AutoSize = True
        Me.cbBigFishGames.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBigFishGames.Location = New System.Drawing.Point(0, 574)
        Me.cbBigFishGames.Margin = New System.Windows.Forms.Padding(0)
        Me.cbBigFishGames.Name = "cbBigFishGames"
        Me.cbBigFishGames.Size = New System.Drawing.Size(115, 19)
        Me.cbBigFishGames.TabIndex = 28
        Me.cbBigFishGames.Text = "Big Fish Games"
        Me.cbBigFishGames.UseVisualStyleBackColor = True
        '
        'cbGIMP
        '
        Me.cbGIMP.AutoSize = True
        Me.cbGIMP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGIMP.Location = New System.Drawing.Point(0, 593)
        Me.cbGIMP.Margin = New System.Windows.Forms.Padding(0)
        Me.cbGIMP.Name = "cbGIMP"
        Me.cbGIMP.Size = New System.Drawing.Size(55, 19)
        Me.cbGIMP.TabIndex = 29
        Me.cbGIMP.Text = "GIMP"
        Me.cbGIMP.UseVisualStyleBackColor = True
        '
        'cbGoogleEarth
        '
        Me.cbGoogleEarth.AutoSize = True
        Me.cbGoogleEarth.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGoogleEarth.Location = New System.Drawing.Point(0, 612)
        Me.cbGoogleEarth.Margin = New System.Windows.Forms.Padding(0)
        Me.cbGoogleEarth.Name = "cbGoogleEarth"
        Me.cbGoogleEarth.Size = New System.Drawing.Size(98, 19)
        Me.cbGoogleEarth.TabIndex = 30
        Me.cbGoogleEarth.Text = "Google Earth"
        Me.cbGoogleEarth.UseVisualStyleBackColor = True
        '
        'cbGoogleUpdater
        '
        Me.cbGoogleUpdater.AutoSize = True
        Me.cbGoogleUpdater.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGoogleUpdater.Location = New System.Drawing.Point(0, 631)
        Me.cbGoogleUpdater.Margin = New System.Windows.Forms.Padding(0)
        Me.cbGoogleUpdater.Name = "cbGoogleUpdater"
        Me.cbGoogleUpdater.Size = New System.Drawing.Size(113, 19)
        Me.cbGoogleUpdater.TabIndex = 31
        Me.cbGoogleUpdater.Text = "Google Updater"
        Me.cbGoogleUpdater.UseVisualStyleBackColor = True
        '
        'cbHPDigitalImaging
        '
        Me.cbHPDigitalImaging.AutoSize = True
        Me.cbHPDigitalImaging.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHPDigitalImaging.Location = New System.Drawing.Point(0, 650)
        Me.cbHPDigitalImaging.Margin = New System.Windows.Forms.Padding(0)
        Me.cbHPDigitalImaging.Name = "cbHPDigitalImaging"
        Me.cbHPDigitalImaging.Size = New System.Drawing.Size(129, 19)
        Me.cbHPDigitalImaging.TabIndex = 32
        Me.cbHPDigitalImaging.Text = "HP Digital Imaging"
        Me.cbHPDigitalImaging.UseVisualStyleBackColor = True
        '
        'cbIMVU
        '
        Me.cbIMVU.AutoSize = True
        Me.cbIMVU.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIMVU.Location = New System.Drawing.Point(0, 669)
        Me.cbIMVU.Margin = New System.Windows.Forms.Padding(0)
        Me.cbIMVU.Name = "cbIMVU"
        Me.cbIMVU.Size = New System.Drawing.Size(54, 19)
        Me.cbIMVU.TabIndex = 33
        Me.cbIMVU.Text = "IMVU"
        Me.cbIMVU.UseVisualStyleBackColor = True
        '
        'cbiTunes
        '
        Me.cbiTunes.AutoSize = True
        Me.cbiTunes.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbiTunes.Location = New System.Drawing.Point(0, 688)
        Me.cbiTunes.Margin = New System.Windows.Forms.Padding(0)
        Me.cbiTunes.Name = "cbiTunes"
        Me.cbiTunes.Size = New System.Drawing.Size(64, 19)
        Me.cbiTunes.TabIndex = 34
        Me.cbiTunes.Text = "iTunes"
        Me.cbiTunes.UseVisualStyleBackColor = True
        '
        'cbJagex
        '
        Me.cbJagex.AutoSize = True
        Me.cbJagex.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJagex.Location = New System.Drawing.Point(0, 707)
        Me.cbJagex.Margin = New System.Windows.Forms.Padding(0)
        Me.cbJagex.Name = "cbJagex"
        Me.cbJagex.Size = New System.Drawing.Size(58, 19)
        Me.cbJagex.TabIndex = 35
        Me.cbJagex.Text = "Jagex"
        Me.cbJagex.UseVisualStyleBackColor = True
        '
        'cbKaspersky
        '
        Me.cbKaspersky.AutoSize = True
        Me.cbKaspersky.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKaspersky.Location = New System.Drawing.Point(0, 726)
        Me.cbKaspersky.Margin = New System.Windows.Forms.Padding(0)
        Me.cbKaspersky.Name = "cbKaspersky"
        Me.cbKaspersky.Size = New System.Drawing.Size(84, 19)
        Me.cbKaspersky.TabIndex = 36
        Me.cbKaspersky.Text = "Kaspersky"
        Me.cbKaspersky.UseVisualStyleBackColor = True
        '
        'cbNokiaOvi
        '
        Me.cbNokiaOvi.AutoSize = True
        Me.cbNokiaOvi.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNokiaOvi.Location = New System.Drawing.Point(0, 745)
        Me.cbNokiaOvi.Margin = New System.Windows.Forms.Padding(0)
        Me.cbNokiaOvi.Name = "cbNokiaOvi"
        Me.cbNokiaOvi.Size = New System.Drawing.Size(109, 19)
        Me.cbNokiaOvi.TabIndex = 37
        Me.cbNokiaOvi.Text = "Nokia Ovi Suite"
        Me.cbNokiaOvi.UseVisualStyleBackColor = True
        '
        'cbQuicktime
        '
        Me.cbQuicktime.AutoSize = True
        Me.cbQuicktime.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbQuicktime.Location = New System.Drawing.Point(0, 764)
        Me.cbQuicktime.Margin = New System.Windows.Forms.Padding(0)
        Me.cbQuicktime.Name = "cbQuicktime"
        Me.cbQuicktime.Size = New System.Drawing.Size(81, 19)
        Me.cbQuicktime.TabIndex = 38
        Me.cbQuicktime.Text = "Quicktime"
        Me.cbQuicktime.UseVisualStyleBackColor = True
        '
        'cbRealPlayer
        '
        Me.cbRealPlayer.AutoSize = True
        Me.cbRealPlayer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRealPlayer.Location = New System.Drawing.Point(0, 783)
        Me.cbRealPlayer.Margin = New System.Windows.Forms.Padding(0)
        Me.cbRealPlayer.Name = "cbRealPlayer"
        Me.cbRealPlayer.Size = New System.Drawing.Size(86, 19)
        Me.cbRealPlayer.TabIndex = 39
        Me.cbRealPlayer.Text = "RealPlayer"
        Me.cbRealPlayer.UseVisualStyleBackColor = True
        '
        'cbRDP
        '
        Me.cbRDP.AutoSize = True
        Me.cbRDP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRDP.Location = New System.Drawing.Point(0, 802)
        Me.cbRDP.Margin = New System.Windows.Forms.Padding(0)
        Me.cbRDP.Name = "cbRDP"
        Me.cbRDP.Size = New System.Drawing.Size(119, 19)
        Me.cbRDP.TabIndex = 0
        Me.cbRDP.Text = "Remote Desktop"
        Me.cbRDP.UseVisualStyleBackColor = True
        '
        'cbSilverlight
        '
        Me.cbSilverlight.AutoSize = True
        Me.cbSilverlight.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSilverlight.Location = New System.Drawing.Point(0, 821)
        Me.cbSilverlight.Margin = New System.Windows.Forms.Padding(0)
        Me.cbSilverlight.Name = "cbSilverlight"
        Me.cbSilverlight.Size = New System.Drawing.Size(79, 19)
        Me.cbSilverlight.TabIndex = 41
        Me.cbSilverlight.Text = "Silverlight"
        Me.cbSilverlight.UseVisualStyleBackColor = True
        '
        'cbSpotify
        '
        Me.cbSpotify.AutoSize = True
        Me.cbSpotify.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSpotify.Location = New System.Drawing.Point(0, 840)
        Me.cbSpotify.Margin = New System.Windows.Forms.Padding(0)
        Me.cbSpotify.Name = "cbSpotify"
        Me.cbSpotify.Size = New System.Drawing.Size(62, 19)
        Me.cbSpotify.TabIndex = 42
        Me.cbSpotify.Text = "Spotify"
        Me.cbSpotify.UseVisualStyleBackColor = True
        '
        'cbSymantec
        '
        Me.cbSymantec.AutoSize = True
        Me.cbSymantec.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSymantec.Location = New System.Drawing.Point(0, 859)
        Me.cbSymantec.Margin = New System.Windows.Forms.Padding(0)
        Me.cbSymantec.Name = "cbSymantec"
        Me.cbSymantec.Size = New System.Drawing.Size(80, 19)
        Me.cbSymantec.TabIndex = 43
        Me.cbSymantec.Text = "Symantec"
        Me.cbSymantec.UseVisualStyleBackColor = True
        '
        'cbTrackmania
        '
        Me.cbTrackmania.AutoSize = True
        Me.cbTrackmania.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTrackmania.Location = New System.Drawing.Point(0, 878)
        Me.cbTrackmania.Margin = New System.Windows.Forms.Padding(0)
        Me.cbTrackmania.Name = "cbTrackmania"
        Me.cbTrackmania.Size = New System.Drawing.Size(89, 19)
        Me.cbTrackmania.TabIndex = 44
        Me.cbTrackmania.Text = "TrackMania"
        Me.cbTrackmania.UseVisualStyleBackColor = True
        '
        'cbUnity
        '
        Me.cbUnity.AutoSize = True
        Me.cbUnity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUnity.Location = New System.Drawing.Point(0, 897)
        Me.cbUnity.Margin = New System.Windows.Forms.Padding(0)
        Me.cbUnity.Name = "cbUnity"
        Me.cbUnity.Size = New System.Drawing.Size(118, 19)
        Me.cbUnity.TabIndex = 45
        Me.cbUnity.Text = "Unity Web Player"
        Me.cbUnity.UseVisualStyleBackColor = True
        '
        'lblFileExt
        '
        Me.lblFileExt.AutoSize = True
        Me.lblFileExt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileExt.Location = New System.Drawing.Point(3, 916)
        Me.lblFileExt.Name = "lblFileExt"
        Me.lblFileExt.Size = New System.Drawing.Size(103, 20)
        Me.lblFileExt.TabIndex = 46
        Me.lblFileExt.Text = "File Extensions"
        Me.lblFileExt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFileExt.UseCompatibleTextRendering = True
        '
        'cbTMP
        '
        Me.cbTMP.AutoSize = True
        Me.cbTMP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTMP.Location = New System.Drawing.Point(0, 936)
        Me.cbTMP.Margin = New System.Windows.Forms.Padding(0)
        Me.cbTMP.Name = "cbTMP"
        Me.cbTMP.Size = New System.Drawing.Size(50, 19)
        Me.cbTMP.TabIndex = 47
        Me.cbTMP.Text = ".tmp"
        Me.cbTMP.UseVisualStyleBackColor = True
        '
        'cbLOG
        '
        Me.cbLOG.AutoSize = True
        Me.cbLOG.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLOG.Location = New System.Drawing.Point(0, 955)
        Me.cbLOG.Margin = New System.Windows.Forms.Padding(0)
        Me.cbLOG.Name = "cbLOG"
        Me.cbLOG.Size = New System.Drawing.Size(46, 19)
        Me.cbLOG.TabIndex = 48
        Me.cbLOG.Text = ".log"
        Me.cbLOG.UseVisualStyleBackColor = True
        '
        'cbCHK
        '
        Me.cbCHK.AutoSize = True
        Me.cbCHK.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCHK.Location = New System.Drawing.Point(0, 974)
        Me.cbCHK.Margin = New System.Windows.Forms.Padding(0)
        Me.cbCHK.Name = "cbCHK"
        Me.cbCHK.Size = New System.Drawing.Size(48, 19)
        Me.cbCHK.TabIndex = 49
        Me.cbCHK.Text = ".chk"
        Me.cbCHK.UseVisualStyleBackColor = True
        '
        'cbDMP
        '
        Me.cbDMP.AutoSize = True
        Me.cbDMP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDMP.Location = New System.Drawing.Point(0, 993)
        Me.cbDMP.Margin = New System.Windows.Forms.Padding(0)
        Me.cbDMP.Name = "cbDMP"
        Me.cbDMP.Size = New System.Drawing.Size(54, 19)
        Me.cbDMP.TabIndex = 50
        Me.cbDMP.Text = ".dmp"
        Me.cbDMP.UseVisualStyleBackColor = True
        '
        'cb_MP
        '
        Me.cb_MP.AutoSize = True
        Me.cb_MP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_MP.Location = New System.Drawing.Point(0, 1012)
        Me.cb_MP.Margin = New System.Windows.Forms.Padding(0)
        Me.cb_MP.Name = "cb_MP"
        Me.cb_MP.Size = New System.Drawing.Size(54, 19)
        Me.cb_MP.TabIndex = 51
        Me.cb_MP.Text = "._mp"
        Me.cb_MP.UseVisualStyleBackColor = True
        '
        'cbERR
        '
        Me.cbERR.AutoSize = True
        Me.cbERR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbERR.Location = New System.Drawing.Point(0, 1031)
        Me.cbERR.Margin = New System.Windows.Forms.Padding(0)
        Me.cbERR.Name = "cbERR"
        Me.cbERR.Size = New System.Drawing.Size(44, 19)
        Me.cbERR.TabIndex = 52
        Me.cbERR.Text = ".err"
        Me.cbERR.UseVisualStyleBackColor = True
        '
        'cmdClean
        '
        Me.cmdClean.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdClean.AutoSize = True
        Me.cmdClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdClean.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClean.Location = New System.Drawing.Point(67, 309)
        Me.cmdClean.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.cmdClean.Name = "cmdClean"
        Me.cmdClean.Size = New System.Drawing.Size(115, 34)
        Me.cmdClean.TabIndex = 5
        Me.cmdClean.Text = "Start Cleanup"
        Me.cmdClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdClean.UseVisualStyleBackColor = True
        '
        'cmdSelectAll
        '
        Me.cmdSelectAll.AutoSize = True
        Me.cmdSelectAll.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectAll.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.cmdSelectAll.Location = New System.Drawing.Point(13, 80)
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.Size = New System.Drawing.Size(52, 14)
        Me.cmdSelectAll.TabIndex = 3
        Me.cmdSelectAll.TabStop = True
        Me.cmdSelectAll.Text = "Select All"
        '
        'cmdAdvanced
        '
        Me.cmdAdvanced.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdvanced.Location = New System.Drawing.Point(94, 0)
        Me.cmdAdvanced.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.cmdAdvanced.Name = "cmdAdvanced"
        Me.cmdAdvanced.Size = New System.Drawing.Size(85, 21)
        Me.cmdAdvanced.TabIndex = 1
        Me.cmdAdvanced.Text = "Advanced"
        Me.cmdAdvanced.UseVisualStyleBackColor = True
        '
        'cmdQuick
        '
        Me.cmdQuick.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuick.Location = New System.Drawing.Point(3, 0)
        Me.cmdQuick.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.cmdQuick.Name = "cmdQuick"
        Me.cmdQuick.Size = New System.Drawing.Size(85, 21)
        Me.cmdQuick.TabIndex = 0
        Me.cmdQuick.Text = "Quick"
        Me.cmdQuick.UseVisualStyleBackColor = True
        '
        'tblDesign
        '
        Me.tblDesign.AutoSize = True
        Me.tblDesign.ColumnCount = 1
        Me.tblDesign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDesign.Controls.Add(Me.lblProductName, 0, 0)
        Me.tblDesign.Controls.Add(Me.cmdClean, 0, 5)
        Me.tblDesign.Controls.Add(Me.flwOptions, 0, 4)
        Me.tblDesign.Controls.Add(Me.lblNote, 0, 1)
        Me.tblDesign.Controls.Add(Me.flwPresets, 0, 2)
        Me.tblDesign.Controls.Add(Me.cmdSelectAll, 0, 3)
        Me.tblDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDesign.Location = New System.Drawing.Point(0, 0)
        Me.tblDesign.Margin = New System.Windows.Forms.Padding(5)
        Me.tblDesign.Name = "tblDesign"
        Me.tblDesign.Padding = New System.Windows.Forms.Padding(10)
        Me.tblDesign.RowCount = 7
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblDesign.Size = New System.Drawing.Size(249, 350)
        Me.tblDesign.TabIndex = 1
        '
        'flwPresets
        '
        Me.flwPresets.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.flwPresets.AutoSize = True
        Me.flwPresets.Controls.Add(Me.cmdQuick)
        Me.flwPresets.Controls.Add(Me.cmdAdvanced)
        Me.flwPresets.Location = New System.Drawing.Point(33, 56)
        Me.flwPresets.Name = "flwPresets"
        Me.flwPresets.Size = New System.Drawing.Size(182, 21)
        Me.flwPresets.TabIndex = 2
        '
        'cmdAbout
        '
        Me.cmdAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAbout.AutoSize = True
        Me.cmdAbout.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.Location = New System.Drawing.Point(215, 9)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(28, 28)
        Me.cmdAbout.TabIndex = 0
        Me.cmdAbout.Text = "?"
        Me.cmdAbout.UseVisualStyleBackColor = True
        '
        'cbMSI
        '
        Me.cbMSI.AutoSize = True
        Me.cbMSI.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMSI.Location = New System.Drawing.Point(0, 383)
        Me.cbMSI.Margin = New System.Windows.Forms.Padding(0)
        Me.cbMSI.Name = "cbMSI"
        Me.cbMSI.Size = New System.Drawing.Size(174, 19)
        Me.cbMSI.TabIndex = 53
        Me.cbMSI.Text = "Windows Installer Cleanup"
        Me.cbMSI.UseVisualStyleBackColor = True
        '
        'cbThumbnails
        '
        Me.cbThumbnails.AutoSize = True
        Me.cbThumbnails.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbThumbnails.Location = New System.Drawing.Point(0, 364)
        Me.cbThumbnails.Margin = New System.Windows.Forms.Padding(0)
        Me.cbThumbnails.Name = "cbThumbnails"
        Me.cbThumbnails.Size = New System.Drawing.Size(124, 19)
        Me.cbThumbnails.TabIndex = 54
        Me.cbThumbnails.Text = "Thumbnail Cache"
        Me.cbThumbnails.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(249, 350)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.tblDesign)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DriveTidy"
        Me.flwOptions.ResumeLayout(False)
        Me.flwOptions.PerformLayout()
        Me.tblDesign.ResumeLayout(False)
        Me.tblDesign.PerformLayout()
        Me.flwPresets.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmSelectAll As System.Windows.Forms.Timer
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents flwOptions As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblSystem As System.Windows.Forms.Label
    Friend WithEvents cbRecycle As System.Windows.Forms.CheckBox
    Friend WithEvents cbTemp As System.Windows.Forms.CheckBox
    Friend WithEvents cbRecent As System.Windows.Forms.CheckBox
    Friend WithEvents cbWindowsUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents cbErrorReports As System.Windows.Forms.CheckBox
    Friend WithEvents lblInternet As System.Windows.Forms.Label
    Friend WithEvents cbTIF As System.Windows.Forms.CheckBox
    Friend WithEvents cbFirefox As System.Windows.Forms.CheckBox
    Friend WithEvents cbChrome As System.Windows.Forms.CheckBox
    Friend WithEvents cbOpera As System.Windows.Forms.CheckBox
    Friend WithEvents cbSafari As System.Windows.Forms.CheckBox
    Friend WithEvents cbFlash As System.Windows.Forms.CheckBox
    Friend WithEvents cbJava As System.Windows.Forms.CheckBox
    Friend WithEvents cbMessenger As System.Windows.Forms.CheckBox
    Friend WithEvents lblMore As System.Windows.Forms.Label
    Friend WithEvents cbVistaSP1 As System.Windows.Forms.CheckBox
    Friend WithEvents cbVistaSP2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbHibernate As System.Windows.Forms.CheckBox
    Friend WithEvents cbSampleMusic As System.Windows.Forms.CheckBox
    Friend WithEvents cbSamplePictures As System.Windows.Forms.CheckBox
    Friend WithEvents cbSampleVideos As System.Windows.Forms.CheckBox
    Friend WithEvents lblOtherApps As System.Windows.Forms.Label
    Friend WithEvents cbAdobeCameraRAW As System.Windows.Forms.CheckBox
    Friend WithEvents cbAdobeReader As System.Windows.Forms.CheckBox
    Friend WithEvents cbAppleInstaller As System.Windows.Forms.CheckBox
    Friend WithEvents cbAVG As System.Windows.Forms.CheckBox
    Friend WithEvents cbGIMP As System.Windows.Forms.CheckBox
    Friend WithEvents cbGoogleEarth As System.Windows.Forms.CheckBox
    Friend WithEvents cbGoogleUpdater As System.Windows.Forms.CheckBox
    Friend WithEvents cbHPDigitalImaging As System.Windows.Forms.CheckBox
    Friend WithEvents cbIMVU As System.Windows.Forms.CheckBox
    Friend WithEvents cbiTunes As System.Windows.Forms.CheckBox
    Friend WithEvents cbKaspersky As System.Windows.Forms.CheckBox
    Friend WithEvents cbNokiaOvi As System.Windows.Forms.CheckBox
    Friend WithEvents cbQuicktime As System.Windows.Forms.CheckBox
    Friend WithEvents cbRealPlayer As System.Windows.Forms.CheckBox
    Friend WithEvents cbRDP As System.Windows.Forms.CheckBox
    Friend WithEvents cbSilverlight As System.Windows.Forms.CheckBox
    Friend WithEvents cbSpotify As System.Windows.Forms.CheckBox
    Friend WithEvents cbSymantec As System.Windows.Forms.CheckBox
    Friend WithEvents cbTrackmania As System.Windows.Forms.CheckBox
    Friend WithEvents cbUnity As System.Windows.Forms.CheckBox
    Friend WithEvents lblFileExt As System.Windows.Forms.Label
    Friend WithEvents cbTMP As System.Windows.Forms.CheckBox
    Friend WithEvents cbLOG As System.Windows.Forms.CheckBox
    Friend WithEvents cbCHK As System.Windows.Forms.CheckBox
    Friend WithEvents cbDMP As System.Windows.Forms.CheckBox
    Friend WithEvents cb_MP As System.Windows.Forms.CheckBox
    Friend WithEvents cbERR As System.Windows.Forms.CheckBox
    Friend WithEvents cmdClean As System.Windows.Forms.Button
    Friend WithEvents cmdSelectAll As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdAdvanced As System.Windows.Forms.Button
    Friend WithEvents cmdQuick As System.Windows.Forms.Button
    Friend WithEvents tblDesign As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents flwPresets As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cmdAbout As System.Windows.Forms.Button
    Friend WithEvents cbJagex As System.Windows.Forms.CheckBox
    Friend WithEvents cbBigFishGames As System.Windows.Forms.CheckBox
    Friend WithEvents cbAutoDesk As System.Windows.Forms.CheckBox
    Friend WithEvents cbMSI As System.Windows.Forms.CheckBox
    Friend WithEvents cbThumbnails As System.Windows.Forms.CheckBox
End Class
