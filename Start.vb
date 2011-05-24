Public Class Start
    Dim frmMain As New Main
    Dim frmCW
    Dim item As Object

    Private Sub Start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo ErrorHandler
        Load_Main()
        frmCW = New CleanerWindow
        Exit Sub
ErrorHandler:
        If Err.Number = 5 Then
            MsgBox("You may be running the program from a network drive. Please copy the file to a local drive and try again.", MsgBoxStyle.Exclamation, "Error 5")
        Else
            MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Error " & Err.Number)
        End If
        Me.BeginInvoke(New MethodInvoker(AddressOf ForceClose))
    End Sub

    Public Sub ForceClose()
        Me.Close()
    End Sub

    Private Sub Start_FormClosing(ByVal eventsender As System.Object, ByVal eventargs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmCW.cmdCancel.Visible = True Then
            frmCW.Close()
            eventargs.Cancel = True
        Else
            'Deletes files made by the cleanup
            On Error Resume Next
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\cleaner.bat")
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\start.bat")
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\log.txt")
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\cleanchk.txt")
            My.Computer.FileSystem.DeleteDirectory(Environ("appdata") & "\DriveTidy\", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub

    Public Sub Load_Main()
        If frmMain.Visible = False Then
            frmMain = New Main
        End If
        frmMain.TopLevel = False
        frmMain.Visible = True
        Me.Controls.Add(frmMain)
    End Sub

    Public Sub Load_CW()
        If frmCW.Visible = False Then
            frmCW = New CleanerWindow
        End If
        frmCW.TopLevel = False
        frmCW.Visible = True
        Me.Controls.Add(frmCW)
    End Sub

    Public Sub Definitions()

        If Not My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            frmMain.cbWindowsUpdate.Enabled = False
            frmMain.cbHibernate.Enabled = False
            frmMain.cbThumbnails.Enabled = False
            frmMain.cbVistaSP1.Enabled = False
            frmMain.cbVistaSP2.Enabled = False
            frmMain.cbWin7SP1.Enabled = False
        End If

        If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\Microsoft\Windows\WER\ReportArchive") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\Microsoft\Windows\WER\ReportQueue") Then
                If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Microsoft\Windows\WER\ReportArchive") Then
                    If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Microsoft\Windows\WER\ReportQueue") Then
                        frmMain.cbErrorReports.Visible = False
                    End If
                End If
            End If
        End If

        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Mozilla\Firefox") Then
            frmMain.cbFirefox.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Google\Chrome") Then
            frmMain.cbChrome.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Opera") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("appdata") & "\Opera") Then
                frmMain.cbOpera.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Apple Computer\Safari") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("appdata") & "\Apple Computer\Safari") Then
                frmMain.cbSafari.Visible = False
            End If
        End If


        If Not My.Computer.FileSystem.FileExists(Environ("windir") & "\system32\vsp1cln.exe") Then
            frmMain.cbVistaSP1.Visible = False
        End If
        If Not My.Computer.FileSystem.FileExists(Environ("windir") & "\system32\compcln.exe") Then
            frmMain.cbVistaSP2.Visible = False
        End If
        If frmMain.OS_Windows7 = True Then
            If Not Environment.OSVersion.ServicePack = "Service Pack 1" Then
                frmMain.cbWin7SP1.Visible = False
            End If
        Else
            frmMain.cbWin7SP1.Visible = False
        End If
        If Not My.Computer.FileSystem.FileExists(Environ("systemdrive") & "\hiberfil.sys") Then
            frmMain.cbHibernate.Visible = False
        End If

        If Main.OS_WindowsVista = True Then
            If Not My.Computer.FileSystem.FileExists(Environ("localappdata") & "\Microsoft\Windows\Explorerthumbcache_idx.db") Then
                frmMain.cbThumbnails.Visible = False
            End If
        ElseIf Main.OS_Windows7 Or Main.OS_Undetected = True Then
            If Not My.Computer.FileSystem.FileExists(Environ("localappdata") & "\IconCache.db") Then
                frmMain.cbThumbnails.Visible = False
            End If
        End If

        If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Config.Msi") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("programfiles") & "\MSECache") Then
                frmMain.cbMSI.Visible = False
            End If
        End If

        If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Users\Public\Music\Sample Music") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Documents and Settings\All Users\Documents\My Music\Sample Music") Then
                frmMain.cbSampleMusic.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Users\Public\Pictures\Sample Pictures") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Documents and Settings\All Users\Documents\My Pictures\Sample Pictures") Then
                frmMain.cbSamplePictures.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Users\Public\Videos\Sample Videos") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Users\Public\Recorded TV\Sample Media") Then
                frmMain.cbSampleVideos.Visible = False
            End If
        End If

        If Not My.Computer.FileSystem.DirectoryExists(Environ("appdata") & "\Adobe\CameraRaw\Cache") Then
            frmMain.cbAdobeCameraRAW.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("appdata") & "\Adobe\Common\Media Cache") Then
            frmMain.cbAdobeMedia.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Adobe\Acrobat") Then
            frmMain.cbAdobeReader.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\Apple\Installer Cache") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\Apple Computer\Installer Cache") Then
                frmMain.cbAppleInstaller.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\Autodesk") Then
            frmMain.cbAutoDesk.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("programfiles") & "\AVG") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("programfiles(x86)") & "\AVG") Then
                frmMain.cbAVG.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\BigFishGamesCache") Then
            frmMain.cbBigFishGames.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\CCP\EVE") Then
            frmMain.cbEVEcache.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("documents") & "\EVE\Logs") Then
            frmMain.cbEVElogs.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("userprofile") & "\.thumbnails\normal") Then
            frmMain.cbGIMP.Visible = False
        End If
        If Not My.Computer.FileSystem.FileExists(Environ("localappdata") & "\Google\GoogleEarth\dbCache.dat") Then
            If Not My.Computer.FileSystem.FileExists(Environ("localappdata") & "\Google\GoogleEarth\dbCache.dat.index") Then
                If Not My.Computer.FileSystem.FileExists(Environ("locallowappdata") & "\Google\GoogleEarth\dbCache.dat") Then
                    If Not My.Computer.FileSystem.FileExists(Environ("locallowappdata") & "\Google\GoogleEarth\dbCache.dat.index") Then
                        frmMain.cbGoogleEarth.Visible = False
                    End If
                End If
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\Google Updater\cache") Then
            frmMain.cbGoogleUpdater.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\HP\Digital Imaging\cache") Then
            frmMain.cbHPDigitalImaging.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("appdata") & "\IMVU") Then
            frmMain.cbIMVU.Visible = False
        End If
        If Not My.Computer.FileSystem.FileExists(Environ("localappdata") & "\Apple Computer\Cache.db") Then
            If Not My.Computer.FileSystem.FileExists(Environ("localappdata") & "\Apple Computer\iTunes\Cache.db") Then
                frmMain.cbiTunes.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\rscache") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\.jagex_cache_32") Then
                If Not My.Computer.FileSystem.DirectoryExists(Environ("windir") & "\.jagex_cache_32") Then
                    If Not My.Computer.FileSystem.DirectoryExists(Environ("systemdrive") & "\.jagex_cache_64") Then
                        If Not My.Computer.FileSystem.DirectoryExists(Environ("windir") & "\.jagex_cache_64") Then
                            frmMain.cbJagex.Visible = False
                        End If
                    End If
                End If
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("programfiles") & "\Kaspersky Lab") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("programfiles(x86)") & "\Kaspersky Lab") Then
                frmMain.cbKaspersky.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\oviinstallercache") Then
            frmMain.cbNokiaOvi.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Apple Computer\QuickTime\downloads") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("locallowappdata") & "\Apple Computer\QuickTime\downloads") Then
                frmMain.cbQuicktime.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("appdata") & "\Real\RealPlayer") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("appdata") & "\Real\RealOne Player") Then
                frmMain.cbRealPlayer.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Microsoft\Terminal Server Client\Cache") Then
            frmMain.cbRDP.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Microsoft\Silverlight") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("locallowappdata") & "\Microsoft\Silverlight") Then
                frmMain.cbSilverlight.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Spotify\Storage") Then
            frmMain.cbSpotify.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\Symantec Temporary Files") Then
            frmMain.cbSymantec.Visible = False
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("allusersappdata") & "\TrackMania\Cache") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\VirtualStore\ProgramData\TrackMania\Cache") Then
                frmMain.cbTrackmania.Visible = False
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists(Environ("localappdata") & "\Unity\Web Player\Cache") Then
            If Not My.Computer.FileSystem.DirectoryExists(Environ("locallowappdata") & "\Unity\Web Player\Cache") Then
                frmMain.cbUnity.Visible = False
            End If
        End If

        'Determines if should show "More..." label
        Dim CountMore As Integer
        For Each Me.item In frmMain.flwMore.Controls
            If TypeOf item Is CheckBox Then
                If item.Visible = True Then
                    CountMore = CountMore + 1
                End If
            End If
        Next

        If CountMore = 0 Then
            frmMain.lblMore.Visible = False
        End If

        'Determines if should show "Other Applications" label
        Dim CountOtherApps As Integer
        For Each Me.item In frmMain.flwOtherApps.Controls
            If TypeOf item Is CheckBox Then
                If item.Visible = True Then
                    CountOtherApps = CountOtherApps + 1
                End If
            End If
        Next

        If CountOtherApps = 0 Then
            frmMain.lblOtherApps.Visible = False
        End If
    End Sub
End Class