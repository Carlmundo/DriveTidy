Public Class Detect
    Public Sub Definitions()
        If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\Microsoft\Windows\WER\ReportArchive") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\Microsoft\Windows\WER\ReportQueue") Then
                If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Microsoft\Windows\WER\ReportArchive") Then
                    If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Microsoft\Windows\WER\ReportQueue") Then
                        Main.cbErrorReports.Visible = False
                    End If
                End If
            End If
        End If

        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Mozilla\Firefox") Then
            Main.cbFirefox.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Google\Chrome") Then
            Main.cbChrome.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Opera") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("appdata") & "\Opera") Then
                Main.cbOpera.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Apple Computer\Safari") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("appdata") & "\Apple Computer\Safari") Then
                Main.cbSafari.Visible = False
            End If
        End If


        If Not My.Computer.FileSystem.FileExists(Environ("windir") & "\system32\vsp1cln.exe") Then
            Main.cbVistaSP1.Visible = False
        End If
        If Not My.Computer.FileSystem.FileExists(Environ("windir") & "\system32\compcln.exe") Then
            Main.cbVistaSP2.Visible = False
        End If
        If Not My.Computer.FileSystem.FileExists(Environ("systemdrive") & "\hiberfil.sys") Then
            Main.cbHibernate.Visible = False
        End If

        If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Users\Public\Music\Sample Music") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Documents and Settings\All Users\Documents\My Music\Sample Music") Then
                Main.cbSampleMusic.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Users\Public\Pictures\Sample Pictures") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Documents and Settings\All Users\Documents\My Pictures\Sample Pictures") Then
                Main.cbSamplePictures.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Users\Public\Videos\Sample Videos") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Users\Public\Recorded TV\Sample Media") Then
                Main.cbSampleVideos.Visible = False
            End If
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
        If Not My.Computer.FileSystem.DirectoryExists(Environ("appdata") & "\IMVU") Then
            Main.cbIMVU.Visible = False
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
        If Not My.Computer.FileSystem.DirectoryExists(Environ("appdata") & "\Real\RealPlayer") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("appdata") & "\Real\RealOne Player") Then
                Main.cbRealPlayer.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Microsoft\Terminal Server Client\Cache") Then
            Main.cbRDP.Visible = False
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
        If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\TrackMania\Cache") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\VirtualStore\ProgramData\TrackMania\Cache") Then
                Main.cbTrackmania.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Unity\Web Player\Cache") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("locallowappdata") & "\Unity\Web Player\Cache") Then
                Main.cbUnity.Visible = False
            End If
        End If

        'Determines if should show "More..." label
        If Main.lblOtherApps.Location.Y = Main.lblMore.Location.Y + 20 Then
            Main.lblMore.Visible = False
        End If
        'Determines if should show "Other Applications" label
        If Main.lblFileExt.Location.Y = Main.lblOtherApps.Location.Y + 20 Then
            Main.lblOtherApps.Visible = False
        End If
    End Sub

End Class