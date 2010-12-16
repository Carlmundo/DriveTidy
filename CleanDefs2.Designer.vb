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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.txtQ12 = New System.Windows.Forms.TextBox
        Me.txtVistaSP1 = New System.Windows.Forms.TextBox
        Me.txtVistaSP2 = New System.Windows.Forms.TextBox
        Me.txtHibernate = New System.Windows.Forms.TextBox
        Me.txtSampleMusic = New System.Windows.Forms.TextBox
        Me.txtSamplePictures = New System.Windows.Forms.TextBox
        Me.txtSampleVideos = New System.Windows.Forms.TextBox
        Me.txtAdobeReader = New System.Windows.Forms.TextBox
        Me.txtAppleInstaller = New System.Windows.Forms.TextBox
        Me.txtAVG = New System.Windows.Forms.TextBox
        Me.txtGIMP = New System.Windows.Forms.TextBox
        Me.txtGoogleEarth = New System.Windows.Forms.TextBox
        Me.txtGoogleUpdater = New System.Windows.Forms.TextBox
        Me.txtHPDigitalImaging = New System.Windows.Forms.TextBox
        Me.txtIMVU = New System.Windows.Forms.TextBox
        Me.txtiTunes = New System.Windows.Forms.TextBox
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
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAdobeCameraRAW
        '
        Me.txtAdobeCameraRAW.Location = New System.Drawing.Point(3, 349)
        Me.txtAdobeCameraRAW.Multiline = True
        Me.txtAdobeCameraRAW.Name = "txtAdobeCameraRAW"
        Me.txtAdobeCameraRAW.Size = New System.Drawing.Size(390, 52)
        Me.txtAdobeCameraRAW.TabIndex = 45
        Me.txtAdobeCameraRAW.Text = "echo Adobe Camera RAW cache..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%appdata%\Adobe\CameraRaw\Cache\*.*" & _
            """" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q ""%appdata%\Adobe\CameraRaw\Cache\"""
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.txtQ12)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtVistaSP1)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtVistaSP2)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtHibernate)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSampleMusic)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSamplePictures)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSampleVideos)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtAdobeCameraRAW)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtAdobeReader)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtAppleInstaller)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtAVG)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtGIMP)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtGoogleEarth)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtGoogleUpdater)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtHPDigitalImaging)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtIMVU)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtiTunes)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtKaspersky)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtNokiaOvi)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtQuicktime)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtRealPlayer)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtRDP)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSilverlight)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSpotify)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSymantec)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtTrackmania)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtUnity)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtQ13)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(10, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(413, 377)
        Me.FlowLayoutPanel1.TabIndex = 47
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'txtQ12
        '
        Me.txtQ12.Location = New System.Drawing.Point(3, 3)
        Me.txtQ12.Multiline = True
        Me.txtQ12.Name = "txtQ12"
        Me.txtQ12.Size = New System.Drawing.Size(390, 22)
        Me.txtQ12.TabIndex = 61
        Me.txtQ12.Text = "echo Q12 >""%appdata%\DriveTidy\cleanchk.txt"""
        '
        'txtVistaSP1
        '
        Me.txtVistaSP1.Location = New System.Drawing.Point(3, 31)
        Me.txtVistaSP1.Multiline = True
        Me.txtVistaSP1.Name = "txtVistaSP1"
        Me.txtVistaSP1.Size = New System.Drawing.Size(252, 38)
        Me.txtVistaSP1.TabIndex = 64
        Me.txtVistaSP1.Text = "echo Vista SP1 Cleanup..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo VSP1 >""%appdata%\DriveTidy\cleanchk.txt"""
        Me.txtVistaSP1.WordWrap = False
        '
        'txtVistaSP2
        '
        Me.txtVistaSP2.Location = New System.Drawing.Point(3, 75)
        Me.txtVistaSP2.Multiline = True
        Me.txtVistaSP2.Name = "txtVistaSP2"
        Me.txtVistaSP2.Size = New System.Drawing.Size(252, 38)
        Me.txtVistaSP2.TabIndex = 63
        Me.txtVistaSP2.Text = "echo Vista SP2 Cleanup..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo VSP2 >""%appdata%\DriveTidy\cleanchk.txt"""
        Me.txtVistaSP2.WordWrap = False
        '
        'txtHibernate
        '
        Me.txtHibernate.Location = New System.Drawing.Point(3, 119)
        Me.txtHibernate.Multiline = True
        Me.txtHibernate.Name = "txtHibernate"
        Me.txtHibernate.Size = New System.Drawing.Size(340, 50)
        Me.txtHibernate.TabIndex = 66
        Me.txtHibernate.Text = "echo Disabling Hibernate..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "powercfg /hibernate off" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "echo You chose to disable h" & _
            "ibernate. To re-enable it see: http://support.microsoft.com/kb/920730 for more i" & _
            "nfo."
        Me.txtHibernate.WordWrap = False
        '
        'txtSampleMusic
        '
        Me.txtSampleMusic.Location = New System.Drawing.Point(3, 175)
        Me.txtSampleMusic.Multiline = True
        Me.txtSampleMusic.Name = "txtSampleMusic"
        Me.txtSampleMusic.Size = New System.Drawing.Size(390, 52)
        Me.txtSampleMusic.TabIndex = 72
        Me.txtSampleMusic.Text = resources.GetString("txtSampleMusic.Text")
        '
        'txtSamplePictures
        '
        Me.txtSamplePictures.Location = New System.Drawing.Point(3, 233)
        Me.txtSamplePictures.Multiline = True
        Me.txtSamplePictures.Name = "txtSamplePictures"
        Me.txtSamplePictures.Size = New System.Drawing.Size(390, 52)
        Me.txtSamplePictures.TabIndex = 73
        Me.txtSamplePictures.Text = resources.GetString("txtSamplePictures.Text")
        '
        'txtSampleVideos
        '
        Me.txtSampleVideos.Location = New System.Drawing.Point(3, 291)
        Me.txtSampleVideos.Multiline = True
        Me.txtSampleVideos.Name = "txtSampleVideos"
        Me.txtSampleVideos.Size = New System.Drawing.Size(390, 52)
        Me.txtSampleVideos.TabIndex = 62
        Me.txtSampleVideos.Text = resources.GetString("txtSampleVideos.Text")
        '
        'txtAdobeReader
        '
        Me.txtAdobeReader.Location = New System.Drawing.Point(3, 407)
        Me.txtAdobeReader.Multiline = True
        Me.txtAdobeReader.Name = "txtAdobeReader"
        Me.txtAdobeReader.Size = New System.Drawing.Size(390, 105)
        Me.txtAdobeReader.TabIndex = 47
        Me.txtAdobeReader.Text = resources.GetString("txtAdobeReader.Text")
        '
        'txtAppleInstaller
        '
        Me.txtAppleInstaller.Location = New System.Drawing.Point(3, 518)
        Me.txtAppleInstaller.Multiline = True
        Me.txtAppleInstaller.Name = "txtAppleInstaller"
        Me.txtAppleInstaller.Size = New System.Drawing.Size(390, 75)
        Me.txtAppleInstaller.TabIndex = 48
        Me.txtAppleInstaller.Text = resources.GetString("txtAppleInstaller.Text")
        '
        'txtAVG
        '
        Me.txtAVG.Location = New System.Drawing.Point(3, 599)
        Me.txtAVG.Multiline = True
        Me.txtAVG.Name = "txtAVG"
        Me.txtAVG.Size = New System.Drawing.Size(390, 112)
        Me.txtAVG.TabIndex = 49
        Me.txtAVG.Text = resources.GetString("txtAVG.Text")
        '
        'txtGIMP
        '
        Me.txtGIMP.Location = New System.Drawing.Point(3, 717)
        Me.txtGIMP.Multiline = True
        Me.txtGIMP.Name = "txtGIMP"
        Me.txtGIMP.Size = New System.Drawing.Size(390, 47)
        Me.txtGIMP.TabIndex = 60
        Me.txtGIMP.Text = "echo GIMP thumbnails..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%userprofile%\.thumbnails\normal\*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd " & _
            "/s /q ""%userprofile%\.thumbnails\normal\"""
        '
        'txtGoogleEarth
        '
        Me.txtGoogleEarth.Location = New System.Drawing.Point(3, 770)
        Me.txtGoogleEarth.Multiline = True
        Me.txtGoogleEarth.Name = "txtGoogleEarth"
        Me.txtGoogleEarth.Size = New System.Drawing.Size(390, 75)
        Me.txtGoogleEarth.TabIndex = 50
        Me.txtGoogleEarth.Text = resources.GetString("txtGoogleEarth.Text")
        '
        'txtGoogleUpdater
        '
        Me.txtGoogleUpdater.Location = New System.Drawing.Point(3, 851)
        Me.txtGoogleUpdater.Multiline = True
        Me.txtGoogleUpdater.Name = "txtGoogleUpdater"
        Me.txtGoogleUpdater.Size = New System.Drawing.Size(390, 50)
        Me.txtGoogleUpdater.TabIndex = 51
        Me.txtGoogleUpdater.Text = "echo Google Updater cache..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%allusersappdata%\Google Updater\cach" & _
            "e\*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q ""%allusersappdata%\Google Updater\cache\"""
        '
        'txtHPDigitalImaging
        '
        Me.txtHPDigitalImaging.Location = New System.Drawing.Point(3, 907)
        Me.txtHPDigitalImaging.Multiline = True
        Me.txtHPDigitalImaging.Name = "txtHPDigitalImaging"
        Me.txtHPDigitalImaging.Size = New System.Drawing.Size(390, 50)
        Me.txtHPDigitalImaging.TabIndex = 52
        Me.txtHPDigitalImaging.Text = "echo HP Digital Imaging cache..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%localappdata%\HP\Digital Imaging" & _
            "\cache\*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q ""%localappdata%\HP\Digital Imaging\cache\"""
        '
        'txtIMVU
        '
        Me.txtIMVU.Location = New System.Drawing.Point(3, 963)
        Me.txtIMVU.Multiline = True
        Me.txtIMVU.Name = "txtIMVU"
        Me.txtIMVU.Size = New System.Drawing.Size(390, 75)
        Me.txtIMVU.TabIndex = 71
        Me.txtIMVU.Text = resources.GetString("txtIMVU.Text")
        '
        'txtiTunes
        '
        Me.txtiTunes.Location = New System.Drawing.Point(3, 1044)
        Me.txtiTunes.Multiline = True
        Me.txtiTunes.Name = "txtiTunes"
        Me.txtiTunes.Size = New System.Drawing.Size(390, 50)
        Me.txtiTunes.TabIndex = 53
        Me.txtiTunes.Text = "echo iTunes cache..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /q ""%localappdata%\Apple Computer\Cache.db""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f " & _
            "/q ""%localappdata%\Apple Computer\iTunes\Cache.db"""
        '
        'txtKaspersky
        '
        Me.txtKaspersky.Location = New System.Drawing.Point(3, 1100)
        Me.txtKaspersky.Multiline = True
        Me.txtKaspersky.Name = "txtKaspersky"
        Me.txtKaspersky.Size = New System.Drawing.Size(390, 171)
        Me.txtKaspersky.TabIndex = 54
        Me.txtKaspersky.Text = resources.GetString("txtKaspersky.Text")
        '
        'txtNokiaOvi
        '
        Me.txtNokiaOvi.Location = New System.Drawing.Point(3, 1277)
        Me.txtNokiaOvi.Multiline = True
        Me.txtNokiaOvi.Name = "txtNokiaOvi"
        Me.txtNokiaOvi.Size = New System.Drawing.Size(390, 51)
        Me.txtNokiaOvi.TabIndex = 56
        Me.txtNokiaOvi.Text = "echo Nokia Ovi Suite cache..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%allusersappdata%\oviinstallercache\" & _
            "*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q ""%allusersappdata%\OviInstallerCache\"""
        '
        'txtQuicktime
        '
        Me.txtQuicktime.Location = New System.Drawing.Point(3, 1334)
        Me.txtQuicktime.Multiline = True
        Me.txtQuicktime.Name = "txtQuicktime"
        Me.txtQuicktime.Size = New System.Drawing.Size(390, 72)
        Me.txtQuicktime.TabIndex = 57
        Me.txtQuicktime.Text = resources.GetString("txtQuicktime.Text")
        '
        'txtRealPlayer
        '
        Me.txtRealPlayer.Location = New System.Drawing.Point(3, 1412)
        Me.txtRealPlayer.Multiline = True
        Me.txtRealPlayer.Name = "txtRealPlayer"
        Me.txtRealPlayer.Size = New System.Drawing.Size(390, 72)
        Me.txtRealPlayer.TabIndex = 68
        Me.txtRealPlayer.Text = resources.GetString("txtRealPlayer.Text")
        '
        'txtRDP
        '
        Me.txtRDP.Location = New System.Drawing.Point(3, 1490)
        Me.txtRDP.Multiline = True
        Me.txtRDP.Name = "txtRDP"
        Me.txtRDP.Size = New System.Drawing.Size(390, 49)
        Me.txtRDP.TabIndex = 69
        Me.txtRDP.Text = "echo Remote Desktop cache..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%localappdata%\Microsoft\Terminal Ser" & _
            "ver Client\Cache\*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /q """"%localappdata%\Microsoft\Terminal Server Clien" & _
            "t\Cache\"""
        '
        'txtSilverlight
        '
        Me.txtSilverlight.Location = New System.Drawing.Point(3, 1545)
        Me.txtSilverlight.Multiline = True
        Me.txtSilverlight.Name = "txtSilverlight"
        Me.txtSilverlight.Size = New System.Drawing.Size(390, 72)
        Me.txtSilverlight.TabIndex = 55
        Me.txtSilverlight.Text = resources.GetString("txtSilverlight.Text")
        '
        'txtSpotify
        '
        Me.txtSpotify.Location = New System.Drawing.Point(3, 1623)
        Me.txtSpotify.Multiline = True
        Me.txtSpotify.Name = "txtSpotify"
        Me.txtSpotify.Size = New System.Drawing.Size(390, 46)
        Me.txtSpotify.TabIndex = 58
        Me.txtSpotify.Text = "echo Spotify cache..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del /f /s /q ""%localappdata%\Spotify\Storage\*.*""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rd /s /" & _
            "q ""%localappdata%\Spotify\Storage\"""
        '
        'txtSymantec
        '
        Me.txtSymantec.Location = New System.Drawing.Point(3, 1675)
        Me.txtSymantec.Multiline = True
        Me.txtSymantec.Name = "txtSymantec"
        Me.txtSymantec.Size = New System.Drawing.Size(390, 46)
        Me.txtSymantec.TabIndex = 67
        Me.txtSymantec.Text = resources.GetString("txtSymantec.Text")
        '
        'txtTrackmania
        '
        Me.txtTrackmania.Location = New System.Drawing.Point(3, 1727)
        Me.txtTrackmania.Multiline = True
        Me.txtTrackmania.Name = "txtTrackmania"
        Me.txtTrackmania.Size = New System.Drawing.Size(390, 46)
        Me.txtTrackmania.TabIndex = 70
        Me.txtTrackmania.Text = resources.GetString("txtTrackmania.Text")
        '
        'txtUnity
        '
        Me.txtUnity.Location = New System.Drawing.Point(3, 1779)
        Me.txtUnity.Multiline = True
        Me.txtUnity.Name = "txtUnity"
        Me.txtUnity.Size = New System.Drawing.Size(390, 71)
        Me.txtUnity.TabIndex = 59
        Me.txtUnity.Text = resources.GetString("txtUnity.Text")
        '
        'txtQ13
        '
        Me.txtQ13.Location = New System.Drawing.Point(3, 1856)
        Me.txtQ13.Multiline = True
        Me.txtQ13.Name = "txtQ13"
        Me.txtQ13.Size = New System.Drawing.Size(390, 21)
        Me.txtQ13.TabIndex = 46
        Me.txtQ13.Text = "echo Q13 >""%appdata%\DriveTidy\cleanchk.txt"""
        '
        'CleanDefs2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 397)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "CleanDefs2"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtAdobeCameraRAW As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
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
End Class
