Public Class Main
    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
    Private Declare Function URLDownloadToFile Lib "urlmon" Alias "URLDownloadToFileA" (ByVal pCaller As Integer, ByVal szURL As String, ByVal szFileName As String, ByVal dwReserved As Integer, ByVal lpfnCB As Integer) As Integer
    Private Function GetFileSize(ByVal MyFilePath As String) As Long
        Dim MyFile As New IO.FileInfo(MyFilePath)
        Dim FileSize As Long = MyFile.Length
        Return FileSize
    End Function
    Dim DownloadAttempts As Integer = 0
    Dim ManualDownloadMsg As String = "Please try again later or download the latest version from www.fixkb.com/drivetidy"
    Dim UpdateSuccess As Integer = 0
    Dim UpdateFailed As Integer = 0
    Dim UpdateError As Integer = 0
    Dim ErrNo, ErrInfo As String
    Dim OriginalHeight, OriginalWidth As Integer

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OriginalHeight = Me.Height
        OriginalWidth = Me.Width
        AppLoad()
    End Sub

    Public Sub AppLoad()
        IO.File.Delete(Environ("temp") & "\DriveTidy.exe")
        For Each p As Process In Process.GetProcesses
            If p.MainWindowTitle = "DriveTidy" Then
                p.Kill()
            ElseIf p.MainWindowTitle = "About DriveTidy" Then
                p.Kill()
            End If
        Next
        bgUpdate.RunWorkerAsync()
    End Sub

    Public Sub Update_DriveTidy()
        On Error GoTo ErrorHandler
        Environment.SetEnvironmentVariable("desktop", My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders").GetValue("Desktop"))
        If UpdateError = 0 Then
            If DownloadAttempts < 3 Then
                Dim objShell As Object = CreateObject("WScript.Shell")
                Dim DownloadURL As String = "https://github.com/downloads/Carlmundo/DriveTidy/DriveTidy.exe"
                Dim SaveLocation As String = Environ("temp") & "\DriveTidy.exe"
                Dim UpdateProcess As Integer = URLDownloadToFile(0, DownloadURL, SaveLocation, 0, 0)
                DownloadAttempts += 1
                If Not IO.File.Exists(Environ("temp") & "\DriveTidy.exe") Then
                    Update_DriveTidy()
                Else
                    If GetFileSize(Environ("temp") & "\DriveTidy.exe") > 204800 Then
                        IO.File.Copy(Environ("temp") & "\DriveTidy.exe", Environ("desktop") & "\DriveTidy.exe", True)
                        IO.File.Delete(Environ("temp") & "\DriveTidy.exe")
                        UpdateSuccess = 1
                    Else
                        Update_DriveTidy()
                    End If
                End If
            Else
                UpdateFailed = 1
            End If
        End If
        Exit Sub
ErrorHandler:
        UpdateError = 1
        ErrNo = "Error " & Err.Number
        ErrInfo = Err.Description
    End Sub

    Private Sub bgUpdate_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgUpdate.DoWork
        Update_DriveTidy()
    End Sub

    Private Sub tmCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmCheck.Tick
        If UpdateSuccess = 1 Then
            tmCheck.Enabled = False
            lblStatus.Text = "Update Complete."
            imgUpdating.Visible = False
            imgSuccess.Visible = True
            lblSuccess.Visible = True
            cbLaunch.Visible = True
            cmdClose.Visible = True
        ElseIf UpdateFailed = 1 Then
            tmCheck.Enabled = False
            lblStatus.Text = "Update Failed!"
            imgUpdating.Visible = False
            imgFailed.Visible = True
            lblFailed.Visible = True
            lblManualDL.Visible = True
            lnkWebsite.Visible = True
            cmdRetry.Visible = True
            cmdClose.Visible = True
        ElseIf UpdateError = 1 Then
            tmCheck.Enabled = False
            imgUpdating.Visible = False
            imgFailed.Visible = True
            lblStatus.Text = ErrNo
            lblManualDL.Visible = True
            lnkWebsite.Visible = True
            cbErrorDetails.Visible = True
            txtError.Text = ErrInfo
            cmdRetry.Visible = True
            cmdClose.Visible = True
        End If
    End Sub

    Private Sub cbErrorDetails_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbErrorDetails.CheckedChanged
        If cbErrorDetails.CheckState = CheckState.Checked Then
            txtError.Visible = True
        Else
            txtError.Visible = False
            Me.Width = OriginalWidth
            Me.Height = OriginalHeight
        End If
    End Sub

    Private Sub lnkWebsite_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkWebsite.LinkClicked
        Process.Start("http://www.fixkb.com/drivetidy")
    End Sub

    Private Sub cmdRetry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRetry.Click
        DownloadAttempts = 0
        UpdateSuccess = 0
        UpdateFailed = 0
        UpdateError = 0
        ErrNo = ""
        ErrInfo = ""
        imgFailed.Visible = False
        cbErrorDetails.Visible = False
        lblFailed.Visible = False
        lblManualDL.Visible = False
        lnkWebsite.Visible = False
        txtError.Visible = False
        cmdRetry.Visible = False
        cmdClose.Visible = False
        lblStatus.Text = "Updating..."
        imgUpdating.Visible = True
        tmCheck.Enabled = True
        Me.Width = OriginalWidth
        Me.Height = OriginalHeight
        AppLoad()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        If cbLaunch.CheckState = CheckState.Checked Then
            On Error Resume Next
            Process.Start(Environ("userprofile") & "\Desktop\DriveTidy.exe")
        End If
        Me.Close()
    End Sub
End Class
