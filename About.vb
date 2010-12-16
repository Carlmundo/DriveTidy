Public Class About

    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
    'Allows Downloading of file
    Private Declare Function URLDownloadToFile Lib "urlmon" Alias "URLDownloadToFileA" (ByVal pCaller As Integer, ByVal szURL As String, ByVal szFileName As String, ByVal dwReserved As Integer, ByVal lpfnCB As Integer) As Integer

    Private Sub About_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Main.Icon
        lblVersion.Text = "v" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
        Me.Top = Main.Top
        Me.Left = Main.Left - ((Me.Width - Main.Width) / 2)
        lblEmail.TabStop = False 'TabStop is not available in UI
    End Sub

    Private Sub lblEmail_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblEmail.LinkClicked
        On Error Resume Next 'An error may be returned if no mail program is installed
        System.Diagnostics.Process.Start("mailto:DriveTidy@gmail.com?Subject=DriveTidy")
    End Sub

    Private Sub About_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        My.Computer.FileSystem.DeleteFile(Environ("temp") & "\build.txt")
        My.Computer.FileSystem.DeleteFile(Environ("temp") & "\DriveTidy_Readme.txt")
        Main.Top = Me.Top
        Main.Left = Me.Left + (Me.Width - Main.Width)
        Main.Show()
        Main.tmSelectAll.Enabled = True
    End Sub
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Dim BuildCheck As Integer 'The process that downloads the file to the computer
        Dim url As String 'The URL of the build.txt file that contains the most recent build number
        Dim localFileName As String 'Where the file is downloaded to
        Dim BuildValue As Decimal 'Writes the version number as one integer
        Dim BuildFile As Object 'The file to check for FileContent (same as the downloaded location)
        Dim FileContent As Object
        Dim intmessage As Object
        Dim objShell As Object 'Used to open the link to download an updated version
        objShell = CreateObject("WScript.Shell")
        url = "http://www.aspromos.com/build.txt"
        localFileName = Environ("temp") & "\build.txt"
        BuildFile = Environ("temp") & "\build.txt"
        BuildCheck = URLDownloadToFile(0, url, localFileName, 0, 0)
        BuildValue = (Environ("version_value"))
        FileContent = ""
        On Error GoTo UpdateCheckFailed
        FileOpen(5, BuildFile, OpenMode.Input)
        Input(5, FileContent)
        If FileContent > BuildValue Then
            intmessage = MsgBox("A newer version of DriveTidy is available. Do you want to download it?", MsgBoxStyle.YesNo, "Update")
            If intmessage = MsgBoxResult.Yes Then
                MsgBox("Make sure to delete or overwrite your older DriveTidy after downloading the new version.")
                objShell.Run("http://www.aspromos.com/DriveTidy.exe")
                Main.Close()
                Me.Close()
            End If
        ElseIf FileContent = 0 Then  'Some broken links display webcontent depending on hosting provider or DNS. This is read as 0.
            MsgBox("The server appears to be down. Please try again later.", MsgBoxStyle.Exclamation, "Update Failed")
        ElseIf FileContent <= BuildValue Then
            MsgBox("You have the latest version of DriveTidy.", MsgBoxStyle.Information, "Update")
        End If
        FileClose(5)
        Exit Sub
UpdateCheckFailed:
        If Err.Number = 53 Then
            MsgBox("Could not find server. Make sure you are connected to the internet.", MsgBoxStyle.Exclamation, "Update Failed")
        Else
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error " & Err.Number)
        End If
        FileClose(5)
    End Sub

    Private Sub cmdReadme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReadMe.Click
        FileOpen(6, Environ("temp") & "\DriveTidy_Readme.txt", OpenMode.Output)
        PrintLine(6, Readme.txtReadme.Text)
        FileClose(6)
        ShellExecute(0, vbNullString, "notepad", Environ("temp") & "\DriveTidy_Readme.txt", vbNullString, AppWinStyle.NormalFocus)
    End Sub

End Class