Public Class About
    'Allows Downloading of file
    Private Declare Function URLDownloadToFile Lib "urlmon" Alias "URLDownloadToFileA" (ByVal pCaller As Integer, ByVal szURL As String, ByVal szFileName As String, ByVal dwReserved As Integer, ByVal lpfnCB As Integer) As Integer
    Private Sub About_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Start.Icon

        'Display settings to show the form correctly for all DPI settings
        Dim gfx As Graphics
        gfx = Graphics.FromHwnd(Me.Handle)

        If gfx.DpiX > 96 Then
            cmdUpdate.AutoSize = True
            cmdReadme.AutoSize = True
        End If
        gfx.Dispose()

        lblVersion.Text = "v" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
        lblCopyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub About_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        My.Computer.FileSystem.DeleteFile(Environ("temp") & "\build.txt")
        My.Computer.FileSystem.DeleteFile(Environ("temp") & "\DriveTidy_Readme.txt")
        Start.Enabled = True
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        AppUpdate()
    End Sub

    Public Sub AppUpdate()
        Me.Cursor = Cursors.WaitCursor

        'Where the file is downloaded to
        Dim BuildLocalFile As String = Environ("temp") & "\build.txt"
        'The process that downloads the file to the computer
        Dim BuildCheck As Integer = URLDownloadToFile(0, "https://raw.github.com/Carlmundo/DriveTidy/master/build.txt", BuildLocalFile, 0, 0)
        'Writes the version number as one number
        Dim BuildValue As Decimal = (Environ("version_value"))
        'The file to check for FileContent (same as the downloaded location)
        Dim FileContent As Object = ""

        On Error GoTo UpdateCheckFailed
        FileOpen(5, BuildLocalFile, OpenMode.Input)
        Input(5, FileContent)
        FileClose(5)
        Me.Cursor = Cursors.Default

        Dim MsgNewUpdate As Object
        If FileContent > BuildValue Then
            Dim LatestVersion As String = FileContent
            If LatestVersion < 10 Then
                If LatestVersion.Length = 4 Then
                    LatestVersion = LatestVersion.Insert(3, ".")
                ElseIf LatestVersion.Length >= 5 Then
                    LatestVersion = LatestVersion.Insert(3, ".").Insert(5, ".")
                End If
            ElseIf LatestVersion >= 10 Then
                If LatestVersion.Length = 5 Then
                    LatestVersion = LatestVersion.Insert(4, ".")
                ElseIf LatestVersion.Length >= 6 Then
                    LatestVersion = LatestVersion.Insert(4, ".").Insert(6, ".")
                End If
            End If
            MsgNewUpdate = MsgBox("A new update for DriveTidy is available." & vbCrLf & vbCrLf & "Current Version:  " & Environ("version") & vbCrLf & "Latest Version:     " & LatestVersion & vbCrLf & vbCrLf & "Would you like to download it?", MsgBoxStyle.YesNo, "DriveTidy Update")
            If MsgNewUpdate = MsgBoxResult.Yes Then
                Dim DownloadUpdater As Integer = URLDownloadToFile(0, "https://github.com/downloads/Carlmundo/DriveTidy/updater.exe", Environ("temp") & "\updater.exe", 0, 0)
                If IO.File.Exists(Environ("temp") & "\updater.exe") Then
                    On Error Resume Next
                    My.Computer.FileSystem.DeleteFile(Environ("temp") & "\build.txt")
                    My.Computer.FileSystem.DeleteFile(Environ("temp") & "\DriveTidy_Readme.txt")
                    Process.Start(Environ("temp") & "\updater.exe")
                Else
                    If Me.Visible = True Then 'Only if About form is open and not on Main_Load
                        MsgBox("DriveTidy failed to update." & vbNewLine & "Please try again later or get the latest version from:" & vbNewLine & vbNewLine & "www.fixkb.com/drivetidy", MsgBoxStyle.Exclamation, "Update Failed")
                    End If
                End If
            End If
        ElseIf FileContent = 0 Then  'Some broken links display webcontent depending on hosting provider or DNS. This is read as 0.
            If Me.Visible = True Then
                MsgBox("The server appears to be down. Please try again later.", MsgBoxStyle.Exclamation, "Update Failed")
            End If
        ElseIf FileContent <= BuildValue Then
            If Me.Visible = True Then
                MsgBox("You have the latest version of DriveTidy.", MsgBoxStyle.Information, "Update")
            End If
        End If
        Exit Sub
UpdateCheckFailed:
        Me.Cursor = Cursors.Default
        If Err.Number = 53 Then
            MsgBox("Could not find server. Make sure you are connected to the Internet.", MsgBoxStyle.Exclamation, "Update Failed")
        Else
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error " & Err.Number)
        End If
        On Error Resume Next
        FileClose(5)
    End Sub

    Private Sub cmdReadme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReadme.Click
        FileOpen(6, Environ("temp") & "\DriveTidy_Readme.html", OpenMode.Output)
        PrintLine(6, Readme.txtReadme.Text)
        FileClose(6)
        Process.Start(Environ("temp") & "\DriveTidy_Readme.html")
    End Sub

    Private Sub lnkWeb_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkWeb.LinkClicked
        Process.Start("http://www.fixkb.com")
    End Sub

    Private Sub lnkTwitter_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkTwitter.LinkClicked
        Process.Start("http://www.twitter.com/fixkb")
    End Sub
End Class