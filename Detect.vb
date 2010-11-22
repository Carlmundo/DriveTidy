Public Class Detect
    Public Sub Definitions()
        'If certain files dont exist then delete their button
        If Not My.Computer.FileSystem.FileExists(Environ("windir") & "\system32\vsp1cln.exe") Then
            Main.cbVistaSP1.Visible = False
        End If
        If Not My.Computer.FileSystem.FileExists(Environ("windir") & "\system32\compcln.exe") Then
            Main.cbVistaSP2.Visible = False
        End If
        If Not My.Computer.FileSystem.FileExists(Environ("systemdrive") & "\hiberfil.sys") Then
            Main.cbHibernate.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\Microsoft\Windows\WER\ReportArchive") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\Microsoft\Windows\WER\ReportQueue") Then
                If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Microsoft\Windows\WER\ReportArchive") Then
                    If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Microsoft\Windows\WER\ReportQueue") Then
                        Main.cbErrorReports.Visible = False
                    End If
                End If
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Users\Public\Recorded TV\Sample Media") Then
            Main.cbSampleVideos.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("appdata") & "\Adobe\CameraRaw\Cache") Then
            Main.cbAdobeCameraRAW.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Adobe\Acrobat") Then
            Main.cbAdobeReader.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\Apple\Installer Cache") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\Apple Computer\Installer Cache") Then
                Main.cbAppleInstaller.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("programfiles") & "\AVG") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("programfiles(x86)") & "\AVG") Then
                Main.cbAVG.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("userprofile") & "\.thumbnails\normal") Then
            Main.cbGIMP.Visible = False
        End If
        If Not My.Computer.FileSystem.FileExists(Environ("localappdata") & "\Google\GoogleEarth\dbCache.dat") Then
            If Not My.Computer.FileSystem.FileExists(Environ("localappdata") & "\Google\GoogleEarth\dbCache.dat.index") Then
                If Not My.Computer.FileSystem.FileExists(Environ("locallowappdata") & "\Google\GoogleEarth\dbCache.dat") Then
                    If Not My.Computer.FileSystem.FileExists(Environ("locallowappdata") & "\Google\GoogleEarth\dbCache.dat.index") Then
                        Main.cbGoogleEarth.Visible = False
                    End If
                End If
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\Google Updater\cache") Then
            Main.cbGoogleUpdater.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\HP\Digital Imaging\cache") Then
            Main.cbHPDigitalImaging.Visible = False
        End If
        If Not My.Computer.FileSystem.FileExists(Environ("localappdata") & "\Apple Computer\Cache.db") Then
            If Not My.Computer.FileSystem.FileExists(Environ("localappdata") & "\Apple Computer\iTunes\Cache.db") Then
                Main.cbiTunes.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("programfiles") & "\Kaspersky Lab") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("programfiles(x86)") & "\Kaspersky Lab") Then
                Main.cbKaspersky.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\oviinstallercache") Then
            Main.cbNokiaOvi.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Apple Computer\QuickTime\downloads") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("locallowappdata") & "\Apple Computer\QuickTime\downloads") Then
                Main.cbQuicktime.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Microsoft\Silverlight") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("locallowappdata") & "\Microsoft\Silverlight") Then
                Main.cbSilverlight.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Spotify\Storage") Then
            Main.cbSpotify.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\Symantec Temporary Files") Then
            Main.cbSymantec.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Unity\Web Player\Cache") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("locallowappdata") & "\Unity\Web Player\Cache") Then
                Main.cbUnity.Visible = False
            End If
        End If
    End Sub

    Private Sub Detect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class