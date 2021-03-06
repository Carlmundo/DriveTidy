﻿Public Class CleanerWindow

    Public Function CheckProcess(ByVal ProcessName As String) As Integer
        Try
            Return Process.GetProcessesByName(ProcessName).GetUpperBound(0) + 1
        Catch
            Return 0
        End Try
    End Function
    Dim FileChk As String
    Dim FileContent As String
    Dim Tot As Decimal
    Dim Free As Decimal
    Dim ValueFreeSpaceBefore
    Dim ValueFreeSpaceAfter
    Dim ValueSpaceFreed

    Public Sub KillProcess(ByRef strProcessToKill As String)
        Dim Proc() As Process = Process.GetProcesses
        For i As Integer = 0 To Proc.GetUpperBound(0)
            If Proc(i).ProcessName = strProcessToKill Then
                Proc(i).Kill()
            End If
        Next
    End Sub

    Private Sub cmdLog_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLog.Click  'Opens the log file
        Shell(Environ("windir") & "\system32\notepad.exe " & Chr(34) & Environ("appdata") & "\DriveTidy\log.txt" & Chr(34), AppWinStyle.NormalFocus)
    End Sub

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Dim intmessage As Object
        intmessage = MsgBox("Are you sure you want to cancel the cleanup?", MsgBoxStyle.YesNo, "Cancel?")
        If intmessage = MsgBoxResult.Yes Then
            KillProcess("cmd")
            KillProcess("rundll32")
            CleanStatus.Text = "Cancelled"
            CleanSubStatus.Text = "See log for details."
            End_Scan()
        End If
    End Sub
    Private Sub CleanerWindow_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cmdCancel.Visible = True Then
            CloseForm()
            eventArgs.Cancel = True
        Else
            ClearAppData()
        End If
    End Sub

    Private Sub CleanerWindow_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        tmSpace.Enabled = True
        tmStatus.Enabled = True

        Tot = My.Computer.FileSystem.GetDriveInfo(System.Environment.ExpandEnvironmentVariables("%SystemDrive%")).TotalSize
        Free = My.Computer.FileSystem.GetDriveInfo(System.Environment.ExpandEnvironmentVariables("%SystemDrive%")).TotalFreeSpace.ToString

        ValueFreeSpaceBefore = Free
        ValueSpaceFreed = 0

        If Tot < 1099511627776 Then '1099511627776 = 1TB
            TotalSpace.Text = Format(Tot / 1073741824, "##0.##") & " GB"
        ElseIf Tot >= 1099511627776 Then
            TotalSpace.Text = Format(Tot / 1099511627776, "###,##0.##") & " TB"
        End If

        If Free < 1073741824 Then
            FreeSpaceBefore.Text = Format(Free / 1048576, "##0") & " MB"
        ElseIf Free >= 1073741824 Then
            FreeSpaceBefore.Text = Format(Free / 1073741824, "##0.##") & " GB"
        ElseIf Free >= 1099511627776 Then
            FreeSpaceBefore.Text = Format(Free / 1099511627776, "###,##0.##") & " TB"
        End If
    End Sub

    Private Sub CloseForm()
        If cmdCancel.Visible = True Then
            cmdCancel_Click(cmdCancel, New System.EventArgs())
        ElseIf cmdCancel.Visible = False Then
            ClearAppData()
            Start.Load_Main()
            Me.Close()
            CleanDefs.Close()
            CleanDefs2.Close()
        End If
    End Sub

    Private Sub End_Scan()
        'Stops the timers so that it doesn't keep checking the values and free space
        tmStatus.Enabled = False
        tmSpace.Enabled = False
        ProgressBar0.Value = 13
        cmdCancel.TabStop = False
        cmdCancel.Enabled = False
        cmdCancel.Visible = False
        cmdLog.Visible = True
        cmdClose.Visible = True
        Me.CancelButton = cmdClose

        If FreeSpaceAfter.Text = "..." Then
            LiveSpace()
        End If
    End Sub

    Private Sub tmStatus_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmStatus.Tick
        'Timer to check the values written to the check file
        On Error Resume Next
        'Creates a blank file and constantly checks it's value. The batch script will write values to the file after certain lines.
        'Each value represents a certain amount of bars in the progress bar.
        FileContent = "0"
        FileChk = Environ("appdata") & "\DriveTidy\cleanchk.txt"
        FileOpen(2, FileChk, OpenMode.Input)
        Input(2, FileContent)
        If FileContent = "0" Then
            CleanStatus.Text = "Cleaning..."
        ElseIf FileContent = "Q1" Then
            CleanSubStatus.Text = "Emptying Recycle Bin"
            ProgressBar0.Value = 1
        ElseIf FileContent = "Q2" Then
            CleanSubStatus.Text = "Temporary Files"
            ProgressBar0.Value = 2
        ElseIf FileContent = "Q3" Then
            CleanSubStatus.Text = "Recent Accessed File Data"
        ElseIf FileContent = "Q4" Then
            CleanSubStatus.Text = "Windows Update Cache"
            ProgressBar0.Value = 4
        ElseIf FileContent = "Q5" Then
            CleanSubStatus.Text = "Error Reports"
        ElseIf FileContent = "Q6" Then
            CleanSubStatus.Text = "Temporary Internet Files"
            ProgressBar0.Value = 6
        ElseIf FileContent = "Q7" Then
            CleanSubStatus.Text = "Browser Caches"
            ProgressBar0.Value = 7
        ElseIf FileContent = "Q8" Then
            ProgressBar0.Value = 8
        ElseIf FileContent = "Q9" Then
            CleanSubStatus.Text = "Flash Player"
            ProgressBar0.Value = 9
        ElseIf FileContent = "Q10" Then
            CleanSubStatus.Text = "Java"
            ProgressBar0.Value = 10
        ElseIf FileContent = "Q11" Then
            CleanSubStatus.Text = "Messenger"
            ProgressBar0.Value = 11
        ElseIf FileContent = "Q12" Then
            CleanSubStatus.Text = "Remaining Caches"
            ProgressBar0.Value = 11
        ElseIf FileContent = "Q13" Then
            ProgressBar0.Value = 13
        ElseIf FileContent = "VSP1" Then
            CleanSubStatus.Text = "Vista SP1 Cleanup"
        ElseIf FileContent = "VSP2" Then
            CleanSubStatus.Text = "Vista SP2 Cleanup"
        ElseIf FileContent = "7SP1" Then
            CleanSubStatus.Text = "Windows 7 SP1 Cleanup"
        ElseIf FileContent = "F1" Then
            CleanSubStatus.Text = ".tmp files"
            ProgressBar0.Value = 2
        ElseIf FileContent = "F2" Then
            CleanSubStatus.Text = ".log files"
            ProgressBar0.Value = 4
        ElseIf FileContent = "F3" Then
            CleanSubStatus.Text = ".chk files"
            ProgressBar0.Value = 6
        ElseIf FileContent = "F4" Then
            CleanSubStatus.Text = ".dmp files"
            ProgressBar0.Value = 8
        ElseIf FileContent = "F5" Then
            CleanSubStatus.Text = "._mp files"
            ProgressBar0.Value = 10
        ElseIf FileContent = "F6" Then
            CleanSubStatus.Text = ".err files"
            ProgressBar0.Value = 11
        ElseIf FileContent = "FIN" Then
            CleanStatus.Text = "Complete"
            CleanSubStatus.Text = "See log for details."
            End_Scan()
            On Error Resume Next
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\cleaner.bat")
            My.Computer.FileSystem.DeleteFile(Environ("appdata") & "\DriveTidy\start.bat")
        End If

        'Added process detection to ensure the SubStatus displays the correct info
        Dim Proc() As Process = Process.GetProcesses

        'Will come into effect once the substatus changes
        If Not CleanSubStatus.Text = Nothing Then
            If CheckProcess("cmd") = 0 Then
                Dim FileLog As String = My.Computer.FileSystem.ReadAllText(Environ("appdata") & "\DriveTidy\log.txt")
                If Not FileLog.Contains("[Cleanup Complete.]") Then
                    CleanStatus.Text = "Complete"
                    CleanSubStatus.Text = "Additional cleanup may be needed."
                    End_Scan()
                End If
            End If
        End If
        FileClose(2)
    End Sub
    Private Sub tmSpace_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmSpace.Tick
        LiveSpace()
    End Sub

    Public Sub LiveSpace()
        'Timer to constantly check the amount of free space on the drive
        Free = My.Computer.FileSystem.GetDriveInfo(System.Environment.ExpandEnvironmentVariables("%SystemDrive%")).TotalFreeSpace
        ValueFreeSpaceAfter = Free

        'When scanning, this is a real time value of the  current Free Space

        If Free < 1073741824 Then
            FreeSpaceAfter.Text = Format(Free / 1048576, "##0") & " MB"
        ElseIf Free >= 1073741824 Then
            FreeSpaceAfter.Text = Format(Free / 1073741824, "##0.##") & " GB"
        ElseIf Free >= 1099511627776 Then
            FreeSpaceAfter.Text = Format(Free / 1099511627776, "###,##0.##") & " TB"
        End If

        ValueSpaceFreed = (ValueFreeSpaceAfter - ValueFreeSpaceBefore)

        If ValueSpaceFreed <= 0 Then
            SpaceFreedUp.Text = "0 MB"
        ElseIf ValueSpaceFreed < 1073741824 Then
            SpaceFreedUp.Text = Format(ValueSpaceFreed / 1048576, "##0") & " MB"
        ElseIf Free >= 1073741824 Then
            SpaceFreedUp.Text = Format(ValueSpaceFreed / 1073741824, "##0.##") & " GB"
        ElseIf Free >= 1099511627776 Then
            SpaceFreedUp.Text = Format(ValueSpaceFreed / 1099511627776, "###,##0.##") & " TB"
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        CloseForm()
    End Sub

    Public Sub ClearAppData()
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
    End Sub
End Class