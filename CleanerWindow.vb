Public Class CleanerWindow

    Dim File As String
    Dim FileContent As String
    Dim Tot As Decimal
    Dim Free As Decimal
    Dim FSV As Integer
    'Allows opening of log file
    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer

    Public Sub KillProcess(ByRef strProcessToKill As String)
        Dim Proc() As Process = Process.GetProcesses
        For i As Integer = 0 To Proc.GetUpperBound(0)
            If Proc(i).ProcessName = strProcessToKill Then
                Proc(i).Kill()
            End If
        Next
    End Sub

    Private Sub cmdLog_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLog.Click 'Opens the log file
        ShellExecute(0, vbNullString, "notepad", Environ("appdata") & "\DriveTidy\log.txt", vbNullString, AppWinStyle.NormalFocus)
    End Sub

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Dim intmessage As Object
        intmessage = MsgBox("Are you sure you want to cancel the cleanup?", MsgBoxStyle.YesNo, "Cancel?")
        If intmessage = MsgBoxResult.Yes Then
            killProcess("cmd")
            KillProcess("rundll32")
            CleanStatus.Text = "Cleanup Cancelled"
            CleanSubStatus.Text = "See log for details."
            End_Scan()
        End If
    End Sub
    Private Sub CleanerWindow_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cmdCancel.Visible = True Then
            CloseForm()
            eventArgs.Cancel = True
        Else
            'Kills any cmd and rundll32 processes left open
            KillProcess("cmd")
            KillProcess("rundll32")
            'Deletes files made by the cleanup
            On Error Resume Next
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\cleaner.bat")
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\start.bat")
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\log.txt")
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\cleanchk.txt")
            My.Computer.FileSystem.DeleteDirectory(Environ("appdata") & "\DriveTidy\", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub

    Private Sub Check_Cleaner_Complete()
        On Error Resume Next
        'Creates a blank file and constantly checks it's value. The batch script will write values to the file after certain lines.
        'Each value represents a certain amount of bars in the progress bar.
        FileContent = "0"
        File = Environ("appdata") & "\DriveTidy\cleanchk.txt"
        FileOpen(2, File, OpenMode.Input)
        Input(2, FileContent)
        If FileContent = "0" Then
            CleanStatus.Text = "Cleaning..."
        ElseIf FileContent = "Q1" Then
            CleanSubStatus.Text = "Emptying Recycle Bin..."
            ProgressBar1.Value = 1
        ElseIf FileContent = "Q2" Then
            CleanSubStatus.Text = "Clearing temporary files..."
            ProgressBar1.Value = 2
        ElseIf FileContent = "Q3" Then
            ProgressBar1.Value = 3
        ElseIf FileContent = "Q4" Then
            CleanSubStatus.Text = "Clearing recent accessed file data..."
            ProgressBar1.Value = 4
        ElseIf FileContent = "Q5" Then
            CleanSubStatus.Text = "Clearing temporary internet files and caches..."
            ProgressBar1.Value = 5
        ElseIf FileContent = "Q6" Then
            ProgressBar1.Value = 6
        ElseIf FileContent = "Q7" Then
            ProgressBar1.Value = 7
        ElseIf FileContent = "Q8" Then
            CleanSubStatus.Text = "Clearing update cache..."
            ProgressBar1.Value = 8
        ElseIf FileContent = "Q9" Then
            CleanSubStatus.Text = "Clearing java cache..."
            ProgressBar1.Value = 9
        ElseIf FileContent = "Q10" Then
            CleanSubStatus.Text = "Clearing flash player cache..."
            ProgressBar1.Value = 10
        ElseIf FileContent = "Q11" Then
            CleanSubStatus.Text = "Clearing messenger caches..."
            ProgressBar1.Value = 11
        ElseIf FileContent = "Q12" Then
            CleanSubStatus.Text = "Clearing remaining caches..."
            ProgressBar1.Value = 11
        ElseIf FileContent = "Q13" Then
            ProgressBar1.Value = 13
        ElseIf FileContent = "VSP1" Then
            CleanSubStatus.Text = "Performing Vista SP1 Cleanup..."
        ElseIf FileContent = "VSP2" Then
            CleanSubStatus.Text = "Performing Vista SP2 Cleanup..."
        ElseIf FileContent = "F1" Then
            CleanSubStatus.Text = "Clearing .tmp files..."
            ProgressBar1.Value = 2
        ElseIf FileContent = "F2" Then
            CleanSubStatus.Text = "Clearing .log files..."
            ProgressBar1.Value = 4
        ElseIf FileContent = "F3" Then
            CleanSubStatus.Text = "Clearing .chk files..."
            ProgressBar1.Value = 6
        ElseIf FileContent = "F4" Then
            CleanSubStatus.Text = "Clearing .dmp files..."
            ProgressBar1.Value = 8
        ElseIf FileContent = "F5" Then
            CleanSubStatus.Text = "Clearing ._mp files..."
            ProgressBar1.Value = 10
        ElseIf FileContent = "F6" Then
            CleanSubStatus.Text = "Clearing .err files..."
            ProgressBar1.Value = 11
        ElseIf FileContent = "FIN" Then
            End_Scan()
            CleanStatus.Text = "Cleanup Complete"
            CleanSubStatus.Text = "See log for details."
            On Error Resume Next
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\cleaner.bat")
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\start.bat")
        End If
        FileClose(2)
    End Sub

    Private Sub Free_Space_Updater()
        Free = My.Computer.FileSystem.GetDriveInfo(System.Environment.ExpandEnvironmentVariables("%SystemDrive%")).TotalFreeSpace
        FSV = FreeSpaceValue.Text
        FreeSpaceAfter.Text = Format(Free / 1048576, "###,###,###,##0") & " MB" & " / " & Format(Free / 1073741824, "###,###,##0.##") & " GB" 'When scanning, this is a real time value of the  current Free Space
        FreeSpaceAfterMB.Text = Free / 1048576 'Same as above, but just the  unformatted MB value
        FreeSpaceAfterGB.Text = Free / 1073741824 'Same as above, but just the  unformatted GB value
        SpaceFreedUp.Text = Format(FSV, "###,###,###,##0") & " MB" 'Calculation of the difference between the free space before and after to show how much is gained
        FreeSpaceValue.Text = (FreeSpaceAfterMB.Text - FreeSpaceBeforeMB.Text) ' Same as above but the unformatted MB value
        If FSV <= 0 Then 'If during the scan, windows is writing files the Space Freed Up will show a negative number as there is less space. This makes it so the counter won't go below 0
            SpaceFreedUp.Text = "0 MB"
        End If
    End Sub

    Private Sub CleanerWindow_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.Icon = Main.Icon
        'Make form the same position as Main
        Me.Top = Main.Top
        Me.Left = Main.Left
        'Timers used to constantly check how much free space there is

        Tot = My.Computer.FileSystem.GetDriveInfo(System.Environment.ExpandEnvironmentVariables("%SystemDrive%")).TotalSize
        Free = My.Computer.FileSystem.GetDriveInfo(System.Environment.ExpandEnvironmentVariables("%SystemDrive%")).TotalFreeSpace.ToString
        FreeSpaceBeforeMB.Text = Free / 1048576
        FreeSpaceBeforeGB.Text = Free / 1073741824
        TotalSpace.Text = Format(Tot / 1048576, "###,###,###,##0") & " MB" & " / " & Format(Tot / 1073741824, "###,###,##0.##") & " GB"
        FreeSpaceBefore.Text = Format(Free / 1048576, "###,###,###,##0") & " MB" & " / " & Format(Free / 1073741824, "###,###,##0.##") & " GB" 'Show Free Space value before the scan
    End Sub

    Private Sub CloseForm()
        If cmdCancel.Visible = True Then
            cmdCancel_Click(cmdCancel, New System.EventArgs())
        ElseIf cmdCancel.Visible = False Then
            'Kills any cmd and rundll32 processes left open
            killProcess("cmd")
            killProcess("rundll32")
            'Deletes files made by the cleanup
            On Error Resume Next
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\cleaner.bat")
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\start.bat")
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\log.txt")
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\cleanchk.txt")
            My.Computer.FileSystem.DeleteDirectory(Environ("appdata") & "\DriveTidy\", FileIO.DeleteDirectoryOption.DeleteAllContents)
            'The main form will now copy the position of the About form upon exit
            Main.Show()
            Main.Top = Me.Top
            Main.Left = Me.Left
            Me.Close()
        End If
    End Sub

    Private Sub End_Scan()
        'Stops the timers so that it doesn't keep checking the values and free space
        Timer1.Enabled = False
        Timer2.Enabled = False
        ProgressBar1.Value = 13
        cmdCancel.TabStop = False
        cmdCancel.Visible = False
        cmdLog.Visible = True
        cmdClose.Visible = True
        Me.CancelButton = cmdClose
    End Sub

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        Check_Cleaner_Complete() 'Timer to check the values written to the check file
    End Sub
    Private Sub Timer2_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer2.Tick
        Free_Space_Updater() 'Timer to constantly check the amount of free space on the drive
    End Sub

    Private Sub cmdClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        CloseForm()
    End Sub
End Class