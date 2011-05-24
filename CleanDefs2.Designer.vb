<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CleanDefs2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CleanDefs2))
        Me.txtAdobeCameraRAW = New System.Windows.Forms.TextBox
        Me.FlowLayout = New System.Windows.Forms.FlowLayoutPanel
        Me.txtQ12 = New System.Windows.Forms.TextBox
        Me.txtVistaSP1 = New System.Windows.Forms.TextBox
        Me.txtVistaSP2 = New System.Windows.Forms.TextBox
        Me.txtHibernate = New System.Windows.Forms.TextBox
        Me.txtThumbnails = New System.Windows.Forms.TextBox
        Me.txtThumbnails7 = New System.Windows.Forms.TextBox
        Me.txtThumbnailsVista = New System.Windows.Forms.TextBox
        Me.txtThumbnailsXP = New System.Windows.Forms.TextBox
        Me.txtMSI = New System.Windows.Forms.TextBox
        Me.txtSampleMusic = New System.Windows.Forms.TextBox
        Me.txtSamplePictures = New System.Windows.Forms.TextBox
        Me.txtSampleVideos = New System.Windows.Forms.TextBox
        Me.txtAdobeMedia = New System.Windows.Forms.TextBox
        Me.txtAdobeReader = New System.Windows.Forms.TextBox
        Me.txtAppleInstaller = New System.Windows.Forms.TextBox
        Me.txtAutoDesk = New System.Windows.Forms.TextBox
        Me.txtAVG = New System.Windows.Forms.TextBox
        Me.txtBigFishGames = New System.Windows.Forms.TextBox
        Me.txtGIMP = New System.Windows.Forms.TextBox
        Me.txtGoogleEarth = New System.Windows.Forms.TextBox
        Me.txtGoogleUpdater = New System.Windows.Forms.TextBox
        Me.txtEVEcache = New System.Windows.Forms.TextBox
        Me.txtEVElogs = New System.Windows.Forms.TextBox
        Me.txtHPDigitalImaging = New System.Windows.Forms.TextBox
        Me.txtIMVU = New System.Windows.Forms.TextBox
        Me.txtiTunes = New System.Windows.Forms.TextBox
        Me.txtJagex = New System.Windows.Forms.TextBox
        Me.txtKaspersky = New System.Windows.Forms.TextBox
        Me.txtNokiaOvi = New System.Windows.Forms.TextBox
        Me.txtQuicktime = New System.Windows.Forms.TextBox
        Me.txtRealPlayer = New System.Windows.Forms.TextBox
        Me.txtRDP = New System.Windows.Forms.TextBox
        Me.txtSilverlight = New System.Windows.Forms.TextBox
        Me.txtSpotify = New System.Windows.Forms.TextBox
        Me.txtSymantec = New System.Windows.Forms.TextBox
        Me.txtTrackmania = New System.Windows.Forms.TextBox
        Me.txtUnity = New System.Windows.Forms.TextBox
        Me.txtQ13 = New System.Windows.Forms.TextBox
        Me.txtWin7SP1 = New System.Windows.Forms.TextBox
        Me.FlowLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAdobeCameraRAW
        '
        Me.txtAdobeCameraRAW.Location = New System.Drawing.Point(3, 677)
        Me.txtAdobeCameraRAW.Multiline = True
        Me.txtAdobeCameraRAW.Name = "txtAdobeCameraRAW"
        Me.txtAdobeCameraRAW.Size = New System.Drawing.Size(390, 52)
        Me.txtAdobeCameraRAW.TabIndex = 45
        Me.txtAdobeCameraRAW.Text = "echo [Adobe Camera RAW cache...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%appdata%\Adobe\CameraRaw\Cache\*" & _
            ".*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q ""%appdata%\Adobe\CameraRaw\Cache\"""
        '
        'FlowLayout
        '
        Me.FlowLayout.AutoScroll = True
        Me.FlowLayout.Controls.Add(Me.txtQ12)
        Me.FlowLayout.Controls.Add(Me.txtVistaSP1)
        Me.FlowLayout.Controls.Add(Me.txtVistaSP2)
        Me.FlowLayout.Controls.Add(Me.txtWin7SP1)
        Me.FlowLayout.Controls.Add(Me.txtHibernate)
        Me.FlowLayout.Controls.Add(Me.txtThumbnails)
        Me.FlowLayout.Controls.Add(Me.txtThumbnails7)
        Me.FlowLayout.Controls.Add(Me.txtThumbnailsVista)
        Me.FlowLayout.Controls.Add(Me.txtThumbnailsXP)
        Me.FlowLayout.Controls.Add(Me.txtMSI)
        Me.FlowLayout.Controls.Add(Me.txtSampleMusic)
        Me.FlowLayout.Controls.Add(Me.txtSamplePictures)
        Me.FlowLayout.Controls.Add(Me.txtSampleVideos)
        Me.FlowLayout.Controls.Add(Me.txtAdobeCameraRAW)
        Me.FlowLayout.Controls.Add(Me.txtAdobeMedia)
        Me.FlowLayout.Controls.Add(Me.txtAdobeReader)
        Me.FlowLayout.Controls.Add(Me.txtAppleInstaller)
        Me.FlowLayout.Controls.Add(Me.txtAutoDesk)
        Me.FlowLayout.Controls.Add(Me.txtAVG)
        Me.FlowLayout.Controls.Add(Me.txtBigFishGames)
        Me.FlowLayout.Controls.Add(Me.txtGIMP)
        Me.FlowLayout.Controls.Add(Me.txtGoogleEarth)
        Me.FlowLayout.Controls.Add(Me.txtGoogleUpdater)
        Me.FlowLayout.Controls.Add(Me.txtEVEcache)
        Me.FlowLayout.Controls.Add(Me.txtEVElogs)
        Me.FlowLayout.Controls.Add(Me.txtHPDigitalImaging)
        Me.FlowLayout.Controls.Add(Me.txtIMVU)
        Me.FlowLayout.Controls.Add(Me.txtiTunes)
        Me.FlowLayout.Controls.Add(Me.txtJagex)
        Me.FlowLayout.Controls.Add(Me.txtKaspersky)
        Me.FlowLayout.Controls.Add(Me.txtNokiaOvi)
        Me.FlowLayout.Controls.Add(Me.txtQuicktime)
        Me.FlowLayout.Controls.Add(Me.txtRealPlayer)
        Me.FlowLayout.Controls.Add(Me.txtRDP)
        Me.FlowLayout.Controls.Add(Me.txtSilverlight)
        Me.FlowLayout.Controls.Add(Me.txtSpotify)
        Me.FlowLayout.Controls.Add(Me.txtSymantec)
        Me.FlowLayout.Controls.Add(Me.txtTrackmania)
        Me.FlowLayout.Controls.Add(Me.txtUnity)
        Me.FlowLayout.Controls.Add(Me.txtQ13)
        Me.FlowLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayout.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayout.Name = "FlowLayout"
        Me.FlowLayout.Size = New System.Drawing.Size(416, 397)
        Me.FlowLayout.TabIndex = 47
        Me.FlowLayout.WrapContents = False
        '
        'txtQ12
        '
        Me.txtQ12.Location = New System.Drawing.Point(3, 3)
        Me.txtQ12.Multiline = True
        Me.txtQ12.Name = "txtQ12"
        Me.txtQ12.Size = New System.Drawing.Size(279, 22)
        Me.txtQ12.TabIndex = 61
        Me.txtQ12.Text = "echo Q12 >""%appdata%\DriveTidy\cleanchk.txt"""
        '
        'txtVistaSP1
        '
        Me.txtVistaSP1.Location = New System.Drawing.Point(3, 31)
        Me.txtVistaSP1.Multiline = True
        Me.txtVistaSP1.Name = "txtVistaSP1"
        Me.txtVistaSP1.Size = New System.Drawing.Size(279, 60)
        Me.txtVistaSP1.TabIndex = 64
        Me.txtVistaSP1.Text = "echo [Vista SP1 Cleanup...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo VSP1 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "start" & _
            " /min /wait %windir%\System32\vsp1cln.exe /quiet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo Q12 >""%appdata%\DriveTidy" & _
            "\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtVistaSP1.WordWrap = False
        '
        'txtVistaSP2
        '
        Me.txtVistaSP2.Location = New System.Drawing.Point(3, 97)
        Me.txtVistaSP2.Multiline = True
        Me.txtVistaSP2.Name = "txtVistaSP2"
        Me.txtVistaSP2.Size = New System.Drawing.Size(279, 60)
        Me.txtVistaSP2.TabIndex = 63
        Me.txtVistaSP2.Text = "echo [Vista SP2 Cleanup...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo VSP2 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "start" & _
            " /min /wait %windir%\System32\compcln.exe /quiet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo Q12 >""%appdata%\DriveTidy" & _
            "\cleanchk.txt"""
        Me.txtVistaSP2.WordWrap = False
        '
        'txtHibernate
        '
        Me.txtHibernate.Location = New System.Drawing.Point(3, 229)
        Me.txtHibernate.Multiline = True
        Me.txtHibernate.Name = "txtHibernate"
        Me.txtHibernate.Size = New System.Drawing.Size(279, 50)
        Me.txtHibernate.TabIndex = 66
        Me.txtHibernate.Text = "echo [Disabling Hibernate...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "powercfg /hibernate off" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo You chose to disable" & _
            " hibernate. To re-enable it see: http://support.microsoft.com/kb/920730 for more" & _
            " info."
        Me.txtHibernate.WordWrap = False
        '
        'txtThumbnails
        '
        Me.txtThumbnails.Location = New System.Drawing.Point(3, 285)
        Me.txtThumbnails.Multiline = True
        Me.txtThumbnails.Name = "txtThumbnails"
        Me.txtThumbnails.Size = New System.Drawing.Size(279, 20)
        Me.txtThumbnails.TabIndex = 81
        Me.txtThumbnails.Text = "Thumbnail Cache"
        Me.txtThumbnails.WordWrap = False
        '
        'txtThumbnails7
        '
        Me.txtThumbnails7.Location = New System.Drawing.Point(3, 311)
        Me.txtThumbnails7.Multiline = True
        Me.txtThumbnails7.Name = "txtThumbnails7"
        Me.txtThumbnails7.Size = New System.Drawing.Size(390, 35)
        Me.txtThumbnails7.TabIndex = 82
        Me.txtThumbnails7.Text = "echo [Thumbnail Cache...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /a /f /q ""%localappdata%\IconCache.db"""
        Me.txtThumbnails7.WordWrap = False
        '
        'txtThumbnailsVista
        '
        Me.txtThumbnailsVista.Location = New System.Drawing.Point(3, 352)
        Me.txtThumbnailsVista.Multiline = True
        Me.txtThumbnailsVista.Name = "txtThumbnailsVista"
        Me.txtThumbnailsVista.Size = New System.Drawing.Size(390, 50)
        Me.txtThumbnailsVista.TabIndex = 79
        Me.txtThumbnailsVista.Text = "echo [Thumbnail Cache...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /a /f /q ""%localappdata%\Microsoft\Windows\Explore" & _
            "r\*.db""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "if exist ""%localappdata%\IconCache.db"" del /a /f /q ""%localappdata%\Ico" & _
            "nCache.db"""
        Me.txtThumbnailsVista.WordWrap = False
        '
        'txtThumbnailsXP
        '
        Me.txtThumbnailsXP.Location = New System.Drawing.Point(3, 408)
        Me.txtThumbnailsXP.Multiline = True
        Me.txtThumbnailsXP.Name = "txtThumbnailsXP"
        Me.txtThumbnailsXP.Size = New System.Drawing.Size(390, 34)
        Me.txtThumbnailsXP.TabIndex = 78
        Me.txtThumbnailsXP.Text = "echo [Thumbnail Cache...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /a /f /s /q %systemdrive%\Thumbs.db"
        Me.txtThumbnailsXP.WordWrap = False
        '
        'txtMSI
        '
        Me.txtMSI.Location = New System.Drawing.Point(3, 448)
        Me.txtMSI.Multiline = True
        Me.txtMSI.Name = "txtMSI"
        Me.txtMSI.Size = New System.Drawing.Size(390, 49)
        Me.txtMSI.TabIndex = 77
        Me.txtMSI.Text = "echo [Windows Installer Cleanup...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%systemdrive%\Config.Msi\*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q ""%systemdrive%\Config.Msi\""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%programfiles%\MSECache\*.*" & _
            """" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q ""%programfiles%\MSECache\"""
        '
        'txtSampleMusic
        '
        Me.txtSampleMusic.Location = New System.Drawing.Point(3, 503)
        Me.txtSampleMusic.Multiline = True
        Me.txtSampleMusic.Name = "txtSampleMusic"
        Me.txtSampleMusic.Size = New System.Drawing.Size(390, 52)
        Me.txtSampleMusic.TabIndex = 72
        Me.txtSampleMusic.Text = resources.GetString("txtSampleMusic.Text")
        '
        'txtSamplePictures
        '
        Me.txtSamplePictures.Location = New System.Drawing.Point(3, 561)
        Me.txtSamplePictures.Multiline = True
        Me.txtSamplePictures.Name = "txtSamplePictures"
        Me.txtSamplePictures.Size = New System.Drawing.Size(390, 52)
        Me.txtSamplePictures.TabIndex = 73
        Me.txtSamplePictures.Text = resources.GetString("txtSamplePictures.Text")
        '
        'txtSampleVideos
        '
        Me.txtSampleVideos.Location = New System.Drawing.Point(3, 619)
        Me.txtSampleVideos.Multiline = True
        Me.txtSampleVideos.Name = "txtSampleVideos"
        Me.txtSampleVideos.Size = New System.Drawing.Size(390, 52)
        Me.txtSampleVideos.TabIndex = 62
        Me.txtSampleVideos.Text = resources.GetString("txtSampleVideos.Text")
        '
        'txtAdobeMedia
        '
        Me.txtAdobeMedia.Location = New System.Drawing.Point(3, 735)
        Me.txtAdobeMedia.Multiline = True
        Me.txtAdobeMedia.Name = "txtAdobeMedia"
        Me.txtAdobeMedia.Size = New System.Drawing.Size(390, 52)
        Me.txtAdobeMedia.TabIndex = 80
        Me.txtAdobeMedia.Text = "echo [Adobe Media cache...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%appdata%\Adobe\Common\Media Cache\*.*" & _
            "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q ""%appdata%\Adobe\Common\Media Cache\"""
        '
        'txtAdobeReader
        '
        Me.txtAdobeReader.Location = New System.Drawing.Point(3, 793)
        Me.txtAdobeReader.Multiline = True
        Me.txtAdobeReader.Name = "txtAdobeReader"
        Me.txtAdobeReader.Size = New System.Drawing.Size(390, 105)
        Me.txtAdobeReader.TabIndex = 47
        Me.txtAdobeReader.Text = resources.GetString("txtAdobeReader.Text")
        '
        'txtAppleInstaller
        '
        Me.txtAppleInstaller.Location = New System.Drawing.Point(3, 904)
        Me.txtAppleInstaller.Multiline = True
        Me.txtAppleInstaller.Name = "txtAppleInstaller"
        Me.txtAppleInstaller.Size = New System.Drawing.Size(390, 75)
        Me.txtAppleInstaller.TabIndex = 48
        Me.txtAppleInstaller.Text = resources.GetString("txtAppleInstaller.Text")
        '
        'txtAutoDesk
        '
        Me.txtAutoDesk.Location = New System.Drawing.Point(3, 985)
        Me.txtAutoDesk.Multiline = True
        Me.txtAutoDesk.Name = "txtAutoDesk"
        Me.txtAutoDesk.Size = New System.Drawing.Size(390, 50)
        Me.txtAutoDesk.TabIndex = 76
        Me.txtAutoDesk.Text = "echo [AutoDesk installer cache...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%systemdrive%\Autodesk\*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd" & _
            " /s /q ""%systemdrive%\Autodesk"""
        '
        'txtAVG
        '
        Me.txtAVG.Location = New System.Drawing.Point(3, 1041)
        Me.txtAVG.Multiline = True
        Me.txtAVG.Name = "txtAVG"
        Me.txtAVG.Size = New System.Drawing.Size(390, 112)
        Me.txtAVG.TabIndex = 49
        Me.txtAVG.Text = resources.GetString("txtAVG.Text")
        '
        'txtBigFishGames
        '
        Me.txtBigFishGames.Location = New System.Drawing.Point(3, 1159)
        Me.txtBigFishGames.Multiline = True
        Me.txtBigFishGames.Name = "txtBigFishGames"
        Me.txtBigFishGames.Size = New System.Drawing.Size(390, 49)
        Me.txtBigFishGames.TabIndex = 75
        Me.txtBigFishGames.Text = "echo [Big Fish Games cache...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%systemdrive%\BigFishGamesCache\*.*" & _
            """" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q ""%systemdrive%\BigFishGamesCache\"""
        '
        'txtGIMP
        '
        Me.txtGIMP.Location = New System.Drawing.Point(3, 1214)
        Me.txtGIMP.Multiline = True
        Me.txtGIMP.Name = "txtGIMP"
        Me.txtGIMP.Size = New System.Drawing.Size(390, 47)
        Me.txtGIMP.TabIndex = 60
        Me.txtGIMP.Text = "echo [GIMP thumbnails...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%userprofile%\.thumbnails\normal\*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "r" & _
            "d /s /q ""%userprofile%\.thumbnails\normal\"""
        '
        'txtGoogleEarth
        '
        Me.txtGoogleEarth.Location = New System.Drawing.Point(3, 1267)
        Me.txtGoogleEarth.Multiline = True
        Me.txtGoogleEarth.Name = "txtGoogleEarth"
        Me.txtGoogleEarth.Size = New System.Drawing.Size(390, 75)
        Me.txtGoogleEarth.TabIndex = 50
        Me.txtGoogleEarth.Text = resources.GetString("txtGoogleEarth.Text")
        '
        'txtGoogleUpdater
        '
        Me.txtGoogleUpdater.Location = New System.Drawing.Point(3, 1348)
        Me.txtGoogleUpdater.Multiline = True
        Me.txtGoogleUpdater.Name = "txtGoogleUpdater"
        Me.txtGoogleUpdater.Size = New System.Drawing.Size(390, 50)
        Me.txtGoogleUpdater.TabIndex = 51
        Me.txtGoogleUpdater.Text = "echo [Google Updater cache...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%allusersappdata%\Google Updater\ca" & _
            "che\*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q ""%allusersappdata%\Google Updater\cache\"""
        '
        'txtEVEcache
        '
        Me.txtEVEcache.Location = New System.Drawing.Point(3, 1404)
        Me.txtEVEcache.Multiline = True
        Me.txtEVEcache.Name = "txtEVEcache"
        Me.txtEVEcache.Size = New System.Drawing.Size(390, 50)
        Me.txtEVEcache.TabIndex = 83
        Me.txtEVEcache.Text = resources.GetString("txtEVEcache.Text")
        '
        'txtEVElogs
        '
        Me.txtEVElogs.Location = New System.Drawing.Point(3, 1460)
        Me.txtEVElogs.Multiline = True
        Me.txtEVElogs.Name = "txtEVElogs"
        Me.txtEVElogs.Size = New System.Drawing.Size(390, 50)
        Me.txtEVElogs.TabIndex = 84
        Me.txtEVElogs.Text = "echo [EVE Logs...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%documents%\EVE\Logs\*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q ""%documents" & _
            "%\EVE\Logs\"""
        '
        'txtHPDigitalImaging
        '
        Me.txtHPDigitalImaging.Location = New System.Drawing.Point(3, 1516)
        Me.txtHPDigitalImaging.Multiline = True
        Me.txtHPDigitalImaging.Name = "txtHPDigitalImaging"
        Me.txtHPDigitalImaging.Size = New System.Drawing.Size(390, 50)
        Me.txtHPDigitalImaging.TabIndex = 52
        Me.txtHPDigitalImaging.Text = "echo [HP Digital Imaging cache...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%localappdata%\HP\Digital Imagi" & _
            "ng\cache\*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q ""%localappdata%\HP\Digital Imaging\cache\"""
        '
        'txtIMVU
        '
        Me.txtIMVU.Location = New System.Drawing.Point(3, 1572)
        Me.txtIMVU.Multiline = True
        Me.txtIMVU.Name = "txtIMVU"
        Me.txtIMVU.Size = New System.Drawing.Size(390, 75)
        Me.txtIMVU.TabIndex = 71
        Me.txtIMVU.Text = resources.GetString("txtIMVU.Text")
        '
        'txtiTunes
        '
        Me.txtiTunes.Location = New System.Drawing.Point(3, 1653)
        Me.txtiTunes.Multiline = True
        Me.txtiTunes.Name = "txtiTunes"
        Me.txtiTunes.Size = New System.Drawing.Size(390, 50)
        Me.txtiTunes.TabIndex = 53
        Me.txtiTunes.Text = "echo [iTunes cache...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /q ""%localappdata%\Apple Computer\Cache.db""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /" & _
            "f /q ""%localappdata%\Apple Computer\iTunes\Cache.db"""
        '
        'txtJagex
        '
        Me.txtJagex.Location = New System.Drawing.Point(3, 1709)
        Me.txtJagex.Multiline = True
        Me.txtJagex.Name = "txtJagex"
        Me.txtJagex.Size = New System.Drawing.Size(390, 75)
        Me.txtJagex.TabIndex = 74
        Me.txtJagex.Text = resources.GetString("txtJagex.Text")
        '
        'txtKaspersky
        '
        Me.txtKaspersky.Location = New System.Drawing.Point(3, 1790)
        Me.txtKaspersky.Multiline = True
        Me.txtKaspersky.Name = "txtKaspersky"
        Me.txtKaspersky.Size = New System.Drawing.Size(390, 112)
        Me.txtKaspersky.TabIndex = 54
        Me.txtKaspersky.Text = resources.GetString("txtKaspersky.Text")
        '
        'txtNokiaOvi
        '
        Me.txtNokiaOvi.Location = New System.Drawing.Point(3, 1908)
        Me.txtNokiaOvi.Multiline = True
        Me.txtNokiaOvi.Name = "txtNokiaOvi"
        Me.txtNokiaOvi.Size = New System.Drawing.Size(390, 51)
        Me.txtNokiaOvi.TabIndex = 56
        Me.txtNokiaOvi.Text = "echo [Nokia Ovi Suite cache...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%allusersappdata%\oviinstallercach" & _
            "e\*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q ""%allusersappdata%\OviInstallerCache\"""
        '
        'txtQuicktime
        '
        Me.txtQuicktime.Location = New System.Drawing.Point(3, 1965)
        Me.txtQuicktime.Multiline = True
        Me.txtQuicktime.Name = "txtQuicktime"
        Me.txtQuicktime.Size = New System.Drawing.Size(390, 72)
        Me.txtQuicktime.TabIndex = 57
        Me.txtQuicktime.Text = resources.GetString("txtQuicktime.Text")
        '
        'txtRealPlayer
        '
        Me.txtRealPlayer.Location = New System.Drawing.Point(3, 2043)
        Me.txtRealPlayer.Multiline = True
        Me.txtRealPlayer.Name = "txtRealPlayer"
        Me.txtRealPlayer.Size = New System.Drawing.Size(390, 72)
        Me.txtRealPlayer.TabIndex = 68
        Me.txtRealPlayer.Text = resources.GetString("txtRealPlayer.Text")
        '
        'txtRDP
        '
        Me.txtRDP.Location = New System.Drawing.Point(3, 2121)
        Me.txtRDP.Multiline = True
        Me.txtRDP.Name = "txtRDP"
        Me.txtRDP.Size = New System.Drawing.Size(390, 49)
        Me.txtRDP.TabIndex = 69
        Me.txtRDP.Text = "echo [Remote Desktop cache...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%localappdata%\Microsoft\Terminal S" & _
            "erver Client\Cache\*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q """"%localappdata%\Microsoft\Terminal Server Cli" & _
            "ent\Cache\"""
        '
        'txtSilverlight
        '
        Me.txtSilverlight.Location = New System.Drawing.Point(3, 2176)
        Me.txtSilverlight.Multiline = True
        Me.txtSilverlight.Name = "txtSilverlight"
        Me.txtSilverlight.Size = New System.Drawing.Size(390, 72)
        Me.txtSilverlight.TabIndex = 55
        Me.txtSilverlight.Text = resources.GetString("txtSilverlight.Text")
        '
        'txtSpotify
        '
        Me.txtSpotify.Location = New System.Drawing.Point(3, 2254)
        Me.txtSpotify.Multiline = True
        Me.txtSpotify.Name = "txtSpotify"
        Me.txtSpotify.Size = New System.Drawing.Size(390, 46)
        Me.txtSpotify.TabIndex = 58
        Me.txtSpotify.Text = resources.GetString("txtSpotify.Text")
        '
        'txtSymantec
        '
        Me.txtSymantec.Location = New System.Drawing.Point(3, 2306)
        Me.txtSymantec.Multiline = True
        Me.txtSymantec.Name = "txtSymantec"
        Me.txtSymantec.Size = New System.Drawing.Size(390, 46)
        Me.txtSymantec.TabIndex = 67
        Me.txtSymantec.Text = resources.GetString("txtSymantec.Text")
        '
        'txtTrackmania
        '
        Me.txtTrackmania.Location = New System.Drawing.Point(3, 2358)
        Me.txtTrackmania.Multiline = True
        Me.txtTrackmania.Name = "txtTrackmania"
        Me.txtTrackmania.Size = New System.Drawing.Size(390, 46)
        Me.txtTrackmania.TabIndex = 70
        Me.txtTrackmania.Text = resources.GetString("txtTrackmania.Text")
        '
        'txtUnity
        '
        Me.txtUnity.Location = New System.Drawing.Point(3, 2410)
        Me.txtUnity.Multiline = True
        Me.txtUnity.Name = "txtUnity"
        Me.txtUnity.Size = New System.Drawing.Size(390, 71)
        Me.txtUnity.TabIndex = 59
        Me.txtUnity.Text = resources.GetString("txtUnity.Text")
        '
        'txtQ13
        '
        Me.txtQ13.Location = New System.Drawing.Point(3, 2487)
        Me.txtQ13.Multiline = True
        Me.txtQ13.Name = "txtQ13"
        Me.txtQ13.Size = New System.Drawing.Size(390, 21)
        Me.txtQ13.TabIndex = 46
        Me.txtQ13.Text = "echo Q13 >""%appdata%\DriveTidy\cleanchk.txt"""
        '
        'txtWin7SP1
        '
        Me.txtWin7SP1.Location = New System.Drawing.Point(3, 163)
        Me.txtWin7SP1.Multiline = True
        Me.txtWin7SP1.Name = "txtWin7SP1"
        Me.txtWin7SP1.Size = New System.Drawing.Size(279, 60)
        Me.txtWin7SP1.TabIndex = 85
        Me.txtWin7SP1.Text = "echo [Windows 7 SP1 Cleanup...]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo 7SP1 >""%appdata%\DriveTidy\cleanchk.txt""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "d" & _
            "ism /online /cleanup-image /spsuperseded /hidesp" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo Q12 >""%appdata%\DriveTidy" & _
            "\cleanchk.txt"""
        Me.txtWin7SP1.WordWrap = False
        '
        'CleanDefs2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 397)
        Me.Controls.Add(Me.FlowLayout)
        Me.Name = "CleanDefs2"
        Me.FlowLayout.ResumeLayout(False)
        Me.FlowLayout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtAdobeCameraRAW As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayout As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtQ13 As System.Windows.Forms.TextBox
    Friend WithEvents txtAdobeReader As System.Windows.Forms.TextBox
    Friend WithEvents txtAppleInstaller As System.Windows.Forms.TextBox
    Friend WithEvents txtAVG As System.Windows.Forms.TextBox
    Friend WithEvents txtGoogleEarth As System.Windows.Forms.TextBox
    Friend WithEvents txtGoogleUpdater As System.Windows.Forms.TextBox
    Friend WithEvents txtHPDigitalImaging As System.Windows.Forms.TextBox
    Friend WithEvents txtiTunes As System.Windows.Forms.TextBox
    Friend WithEvents txtKaspersky As System.Windows.Forms.TextBox
    Friend WithEvents txtSilverlight As System.Windows.Forms.TextBox
    Friend WithEvents txtNokiaOvi As System.Windows.Forms.TextBox
    Friend WithEvents txtQuicktime As System.Windows.Forms.TextBox
    Friend WithEvents txtSpotify As System.Windows.Forms.TextBox
    Friend WithEvents txtUnity As System.Windows.Forms.TextBox
    Friend WithEvents txtGIMP As System.Windows.Forms.TextBox
    Friend WithEvents txtQ12 As System.Windows.Forms.TextBox
    Friend WithEvents txtSampleVideos As System.Windows.Forms.TextBox
    Friend WithEvents txtVistaSP1 As System.Windows.Forms.TextBox
    Friend WithEvents txtVistaSP2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHibernate As System.Windows.Forms.TextBox
    Friend WithEvents txtSymantec As System.Windows.Forms.TextBox
    Friend WithEvents txtRealPlayer As System.Windows.Forms.TextBox
    Friend WithEvents txtRDP As System.Windows.Forms.TextBox
    Friend WithEvents txtTrackmania As System.Windows.Forms.TextBox
    Friend WithEvents txtIMVU As System.Windows.Forms.TextBox
    Friend WithEvents txtSampleMusic As System.Windows.Forms.TextBox
    Friend WithEvents txtSamplePictures As System.Windows.Forms.TextBox
    Friend WithEvents txtJagex As System.Windows.Forms.TextBox
    Friend WithEvents txtBigFishGames As System.Windows.Forms.TextBox
    Friend WithEvents txtAutoDesk As System.Windows.Forms.TextBox
    Friend WithEvents txtMSI As System.Windows.Forms.TextBox
    Friend WithEvents txtThumbnailsXP As System.Windows.Forms.TextBox
    Friend WithEvents txtThumbnailsVista As System.Windows.Forms.TextBox
    Friend WithEvents txtAdobeMedia As System.Windows.Forms.TextBox
    Friend WithEvents txtThumbnails As System.Windows.Forms.TextBox
    Friend WithEvents txtThumbnails7 As System.Windows.Forms.TextBox
    Friend WithEvents txtEVEcache As System.Windows.Forms.TextBox
    Friend WithEvents txtEVElogs As System.Windows.Forms.TextBox
    Friend WithEvents txtWin7SP1 As System.Windows.Forms.TextBox
End Class
