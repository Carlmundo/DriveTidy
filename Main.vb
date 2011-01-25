﻿Public Class Main

    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
    Dim item As Object
    Dim cbCount As Integer
    Dim cbCheckedCount As Integer

    Dim d1 As New System.Collections.Generic.Dictionary(Of CheckBox, TextBox)
    Dim d2 As New System.Collections.Generic.Dictionary(Of CheckBox, TextBox)
    Dim d3 As New System.Collections.Generic.Dictionary(Of CheckBox, TextBox)

    Dim Ready As Integer

    Dim MsgConfirmKill As Object
    Dim MsgApp, MsgProcess, MsgString

    Public Sub QuickSelect()
        'Unchecks all checkboxes
        For Each Me.item In flwOptions.Controls
            If TypeOf item Is CheckBox Then
                item.Checked = False
            End If
        Next
        'Check specific Checkboxes
        cbRecycle.Checked = True
        cbTemp.Checked = True
        cbRecent.Checked = True
        cbWindowsUpdate.Checked = True
        cbErrorReports.Checked = True

        cbTIF.Checked = True
        cbFirefox.Checked = True
        cbChrome.Checked = True
        cbOpera.Checked = True
        cbSafari.Checked = True
        cbFlash.Checked = True
        cbJava.Checked = True
        cbMessenger.Checked = True

        cbAdobeCameraRAW.Checked = True
        cbAdobeReader.Checked = True
        cbAppleInstaller.Checked = True
        cbAVG.Checked = True
        cbGIMP.Checked = True
        cbGoogleEarth.Checked = True
        cbGoogleUpdater.Checked = True
        cbHPDigitalImaging.Checked = True
        cbIMVU.Checked = True
        cbiTunes.Checked = True
        cbKaspersky.Checked = True
        cbNokiaOvi.Checked = True
        cbQuicktime.Checked = True
        cbRealPlayer.Checked = True
        cbRDP.Checked = True
        cbSilverlight.Checked = True
        cbSpotify.Checked = True
        cbSymantec.Checked = True
        cbTrackmania.Checked = True
        cbUnity.Checked = True
    End Sub

    Private Sub CleanerErrors()
        CleanerWindow.cmdCancel.Visible = False
        'Error 75 can happen if the Start Cleanup button is clicked too soon
        If Err.Number = 75 Then
            Me.Show()
            CleanerWindow.Close()
        Else
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error " & Err.Number)
            Me.Show()
            CleanerWindow.Close()
        End If
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Display settings to show the form correctly for all DPI settings
        'cbTIF is the longest Checkbox so the Form width adjusts around it
        If cbTIF.Width + 40 <= 340 Then
            Me.Width = cbTIF.Width + 40
        Else
            Me.Width = cbTIF.Width + 60
        End If
        'Makes FlowOptions end at this particular point 
        flwOptions.Height = cbTIF.Location.Y + (cbTIF.Height * 2)
        'Put cmdAbout in line with DriveTidy text
        Dim AboutLocation As New System.Drawing.Point(cmdAbout.Location.X, lblProductName.Location.Y)
        cmdAbout.Location = AboutLocation

        'OS Detection
        Dim OS_WindowsXP As Boolean
        Dim OS_WindowsVista As Boolean
        Dim OS_Windows7 As Boolean

        'Detect OSVersion and assign True to correct Boolean
        If Environment.OSVersion.Platform = PlatformID.Win32NT And _
        Environment.OSVersion.Version.Major = 5 And _
        Environment.OSVersion.Version.Minor = 1 Then
            OS_WindowsXP = True
            Environment.SetEnvironmentVariable("osd", "Windows XP")
        ElseIf Environment.OSVersion.Platform = PlatformID.Win32NT And _
            Environment.OSVersion.Version.Major = 6 And _
            Environment.OSVersion.Version.Minor = 0 Then
            OS_WindowsVista = True
            Environment.SetEnvironmentVariable("osd", "Windows Vista")
        ElseIf Environment.OSVersion.Platform = PlatformID.Win32NT And _
        Environment.OSVersion.Version.Major = 6 And _
        Environment.OSVersion.Version.Minor = 1 Then
            OS_Windows7 = True
            Environment.SetEnvironmentVariable("osd", "Windows 7")
        Else
            Environment.SetEnvironmentVariable("osd", "Unsupported OS.")
            MsgBox("Warning! Your version of Windows may be unsupported.")

        End If

        'Environment Variables for Windows Vista / 7
        'Paths include "/" to ensure wanted files aren't deleted. 
        'Command List is also adjusted accordingly. 
        'E.g. %userprofile%temp.tmp and not %userprofile%\temp.tmp
        If OS_WindowsVista Or OS_Windows7 = True Then
            Environment.SetEnvironmentVariable("localappdata", Environ("userprofile") + "\AppData\Local\")
            Environment.SetEnvironmentVariable("locallowappdata", Environ("userprofile") + "\AppData\LocalLow\")
            Environment.SetEnvironmentVariable("recycle", Environ("systemdrive") + "\$Recycle.Bin")
            Environment.SetEnvironmentVariable("recent", Environ("appdata") + "\Microsoft\Windows\Recent\")
            Environment.SetEnvironmentVariable("cookies", Environ("appdata") + "\Microsoft\Windows\Cookies\")
            Environment.SetEnvironmentVariable("history", Environ("localappdata") + "\Microsoft\Windows\History\")
            Environment.SetEnvironmentVariable("tif", Environ("localappdata") + "\Microsoft\Windows\Temporary Internet Files\")
            Environment.SetEnvironmentVariable("allusersappdata", Environ("allusersprofile"))
        Else 'Use the Environment Variables for Windows XP, An unsupported OS will use these settings
            Environment.SetEnvironmentVariable("localappdata", Environ("userprofile") + "\Local Settings\Application Data\")
            Environment.SetEnvironmentVariable("locallowappdata", "")
            Environment.SetEnvironmentVariable("recycle", Environ("systemdrive") + "\recycler\")
            Environment.SetEnvironmentVariable("recent", Environ("userprofile") + "\Recent\")
            Environment.SetEnvironmentVariable("cookies", Environ("userprofile") + "\Cookies\")
            Environment.SetEnvironmentVariable("history", Environ("userprofile") + "\Local Settings\History\")
            Environment.SetEnvironmentVariable("tif", Environ("userprofile") + "\Local Settings\Temporary Internet Files\")
            Environment.SetEnvironmentVariable("allusersappdata", Environ("allusersprofile") + "\Application Data\")
        End If
        'Version
        Environment.SetEnvironmentVariable("version", My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision)
        'Version as a value (1 decimal place)
        Environment.SetEnvironmentVariable("version_value", My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & My.Application.Info.Version.Build & My.Application.Info.Version.Revision)

        'KVP Lists
        'List of Current Options here get added to the Dictionary so they can be referenced
        'CleanDefs (without File Extensions)
        d1.Add(cbRecycle, CleanDefs.txtRecycle)
        d1.Add(cbTemp, CleanDefs.txtTemp)
        d1.Add(cbRecent, CleanDefs.txtRecent)
        d1.Add(cbWindowsUpdate, CleanDefs.txtWindowsUpdate)
        d1.Add(cbErrorReports, CleanDefs.txtErrorReports)
        d1.Add(cbTIF, CleanDefs.txtTIF)
        d1.Add(cbFirefox, CleanDefs.txtFirefox)
        d1.Add(cbChrome, CleanDefs.txtChrome)
        d1.Add(cbOpera, CleanDefs.txtOpera)
        d1.Add(cbSafari, CleanDefs.txtSafari)
        d1.Add(cbFlash, CleanDefs.txtFlash)
        d1.Add(cbJava, CleanDefs.txtJava)
        d1.Add(cbMessenger, CleanDefs.txtMessenger)

        'CleanDefs2
        d2.Add(cbVistaSP1, CleanDefs2.txtVistaSP1)
        d2.Add(cbVistaSP2, CleanDefs2.txtVistaSP2)
        d2.Add(cbHibernate, CleanDefs2.txtHibernate)
        d2.Add(cbSampleMusic, CleanDefs2.txtSampleMusic)
        d2.Add(cbSamplePictures, CleanDefs2.txtSamplePictures)
        d2.Add(cbSampleVideos, CleanDefs2.txtSampleVideos)
        d2.Add(cbAdobeCameraRAW, CleanDefs2.txtAdobeCameraRAW)
        d2.Add(cbAdobeReader, CleanDefs2.txtAdobeReader)
        d2.Add(cbAppleInstaller, CleanDefs2.txtAppleInstaller)
        d2.Add(cbAVG, CleanDefs2.txtAVG)
        d2.Add(cbGIMP, CleanDefs2.txtGIMP)
        d2.Add(cbGoogleEarth, CleanDefs2.txtGoogleEarth)
        d2.Add(cbGoogleUpdater, CleanDefs2.txtGoogleUpdater)
        d2.Add(cbHPDigitalImaging, CleanDefs2.txtHPDigitalImaging)
        d2.Add(cbIMVU, CleanDefs2.txtIMVU)
        d2.Add(cbiTunes, CleanDefs2.txtiTunes)
        d2.Add(cbKaspersky, CleanDefs2.txtKaspersky)
        d2.Add(cbNokiaOvi, CleanDefs2.txtNokiaOvi)
        d2.Add(cbQuicktime, CleanDefs2.txtQuicktime)
        d2.Add(cbRealPlayer, CleanDefs2.txtRealPlayer)
        d2.Add(cbRDP, CleanDefs2.txtRDP)
        d2.Add(cbSilverlight, CleanDefs2.txtSilverlight)
        d2.Add(cbSpotify, CleanDefs2.txtSpotify)
        d2.Add(cbSymantec, CleanDefs2.txtSymantec)
        d2.Add(cbTrackmania, CleanDefs2.txtTrackmania)
        d2.Add(cbUnity, CleanDefs2.txtUnity)

        'File Extensions
        d3.Add(cbTMP, CleanDefs.txtTMP)
        d3.Add(cbLOG, CleanDefs.txtLOG)
        d3.Add(cbCHK, CleanDefs.txtCHK)
        d3.Add(cbDMP, CleanDefs.txtDMP)
        d3.Add(cb_MP, CleanDefs.txt_MP)
        d3.Add(cbERR, CleanDefs.txtERR)

        lblNote.Text = "BETA " & My.Application.Info.Version.Revision

        'If certain files dont exist then delete their button
        Detect.Definitions()
        Checkbox_Count()
        tmSelectAll.Enabled = True
    End Sub

    Private Sub Main_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Ensure all forms are closed
        CleanDefs.Close()
        CleanDefs2.Close()
        'CleanerWindow is not closed as Main closes and CleanerWindow opens when "Start Cleanup" is clicked
        Detect.Close()
        About.Close()
    End Sub

    Public Sub Checkbox_Count()
        'Reset values
        cbCount = 0
        cbCheckedCount = 0
        'Make cbCount = Number of visible checkboxes
        For Each Me.item In flwOptions.Controls
            If TypeOf item Is CheckBox Then
                If item.Visible = True Then
                    cbCount = cbCount + 1
                End If
                'Make cbCheckedCount = Number of checked boxes
                If item.Checked = True Then
                    cbCheckedCount = cbCheckedCount + 1
                End If
            End If
        Next
    End Sub

    Public Sub Uncheck_Invisible()
        'Makes sure there that all invisible checkboxes are unchecked to help cbCheckedCount
        For Each Me.item In flwOptions.Controls
            If TypeOf item Is CheckBox Then
                If item.Visible = False Then
                    item.Checked = False
                End If
            End If
        Next
    End Sub

    Public Sub KillMsg()
        Dim Proc() As Process = Process.GetProcesses
        For i As Integer = 0 To Proc.GetUpperBound(0)
            If Proc(i).ProcessName = MsgProcess Then
                MsgConfirmKill = MsgBox(MsgApp & MsgString, MsgBoxStyle.YesNo)
                If MsgConfirmKill = MsgBoxResult.Yes Then
                    KillProcess(MsgProcess)
                    Ready = 1
                ElseIf MsgConfirmKill = MsgBoxResult.No Then
                    Ready = 2
                End If
                MsgProcess = "" 'Added to stop the message repeating
            End If
        Next
    End Sub

    Public Sub KillProcess(ByRef strProcessToKill As String)
        Dim Proc() As Process = Process.GetProcesses
        For i As Integer = 0 To Proc.GetUpperBound(0)
            If Proc(i).ProcessName = strProcessToKill Then
                Proc(i).Kill()
            End If
        Next
    End Sub

    Private Sub tmSelectAll_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmSelectAll.Tick
        'Text will display Select None if all are checked.
        Checkbox_Count()
        If cbCheckedCount < cbCount Then
            cmdSelectAll.Text = "Select All"
        ElseIf cbCheckedCount = cbCount Then
            cmdSelectAll.Text = "Select None"
        End If
    End Sub

    Private Sub cmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        About.Show()
        Me.Hide()
        'Disable the Select All timer as the form isn't open
        tmSelectAll.Enabled = False
    End Sub

    Private Sub cmdQuick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuick.Click
        QuickSelect()
        Uncheck_Invisible()
    End Sub

    Private Sub cmdAdvanced_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdvanced.Click
        QuickSelect()
        cbTMP.Checked = True
        cbLOG.Checked = True
        cbCHK.Checked = True
        cbDMP.Checked = True
        Uncheck_Invisible()
        'Scroll to bottom of FlowOptions to demonstrate the extra options selected by Advanced
        flwOptions.VerticalScroll.Value = flwOptions.VerticalScroll.Maximum
        flwOptions.ScrollControlIntoView(flwOptions)
    End Sub

    Private Sub cmdSelectAll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles cmdSelectAll.LinkClicked
        'If all of the checkboxes are checked they will all be unchecked, otherwise they will all be checked. 
        Checkbox_Count()
        If cbCheckedCount < cbCount Then
            For Each Me.item In flwOptions.Controls
                If TypeOf item Is CheckBox Then
                    item.Checked = True
                    Checkbox_Count()
                End If
            Next
        ElseIf cbCheckedCount = cbCount Then
            For Each Me.item In flwOptions.Controls
                If TypeOf item Is CheckBox Then
                    item.Checked = False
                    Checkbox_Count()
                End If
            Next
        End If
        Uncheck_Invisible()
    End Sub

    Private Sub FlowLayout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles flwOptions.Click
        flwOptions.Focus() 'Allows the mouse wheel to work after the panel is clicked
    End Sub

    Private Sub FlowLayout_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles flwOptions.MouseEnter
        flwOptions.Focus() 'Allows the mouse wheel to work after the panel has had the mouse move over it
    End Sub

    Private Sub cmdClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClean.Click
        Dim ieVersion As New Version(My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Internet Explorer").GetValue("Version"))
        'If the program fails to write a file then an error will generate and restart the program
        'On Error GoTo ErrorHandler
        'Checking to see if at least one option is checked

        'Ready Value Legend.
        '0 = Not Ready, No Options Selected
        '1 = Ready
        '2 = Not Ready, Aborted By User

        Checkbox_Count()
        If cbCheckedCount = 0 Then
            Ready = 0
        Else
            'Process Detection - checks to see if programs are running and need to be closed
            Ready = 1 'Value starts at 1 and will be changed to 2 if the No option is selected for any running processes
            MsgString = " is running and needs to be closed." & vbCrLf & "To save what you are doing close the program manually." & vbCrLf & "Are you sure you want to continue?"
            If cbTIF.Checked = True Then
                If Ready = 1 Then
                    MsgApp = "Internet Explorer"
                    MsgProcess = "iexplore"
                    KillMsg()
                End If
            End If
            If cbFirefox.Checked = True Then
                If Ready = 1 Then
                    MsgApp = "Mozilla Firefox"
                    MsgProcess = "firefox"
                    KillMsg()
                End If
            End If
            If cbChrome.Checked = True Then
                If Ready = 1 Then
                    MsgApp = "Google Chrome"
                    MsgProcess = "chrome"
                    KillMsg()
                End If
            End If
            If cbOpera.Checked = True Then
                If Ready = 1 Then
                    MsgApp = "Opera"
                    MsgProcess = "opera"
                    KillMsg()
                End If
            End If
            If cbSafari.Checked = True Then
                If Ready = 1 Then
                    MsgApp = "Safari"
                    MsgProcess = "safari"
                    KillMsg()
                End If
            End If
            'If a new value other than 2 has not been assigned then it will be changed to 1 to proceed.
            'Used incase the user is not prompted by Process Detection
            If Not Ready = 2 Then
                Ready = 1
            End If
        End If

        If Ready = 0 Then
            MsgBox("Select at least one option.")
        ElseIf Ready = 1 Then
            'Disabling commands for unchecked items
            For Each kvp As System.Collections.Generic.KeyValuePair(Of CheckBox, TextBox) In d1
                If Not kvp.Key.Checked Then
                    kvp.Value.Text = ""
                End If
            Next
            For Each kvp As System.Collections.Generic.KeyValuePair(Of CheckBox, TextBox) In d2
                If Not kvp.Key.Checked Then
                    kvp.Value.Text = ""
                End If
            Next
            For Each kvp As System.Collections.Generic.KeyValuePair(Of CheckBox, TextBox) In d3
                If Not kvp.Key.Checked Then
                    kvp.Value.Text = ""
                End If
            Next

            'Disable Attribute changers from Command List
            If cbRecycle.Checked = False Then
                CleanDefs.txtAttribRecycle.Text = ""
            End If

            If cbMessenger.Checked = False Then
                CleanDefs.txtAttribSQM.Text = ""
            End If

            'Checks IE Version to see whether to use old defs, stops Inetcpl.cpl errors
            If cbTIF.Checked = True Then
                If ieVersion.Major <= 6 Then
                    CleanDefs.txtTIF.Text = CleanDefs.txtTIF_IE6.Text
                End If
            End If

            'Write check file
            My.Computer.FileSystem.CreateDirectory(Environ("appdata") & "\DriveTidy")
            FileOpen(1, Environ("appdata") & "\DriveTidy\cleanchk.txt", OpenMode.Output)
            PrintLine(1, "0")
            FileClose(1)
            'Create Batch Commands
            FileOpen(2, Environ("appdata") & "\DriveTidy\cleaner.bat", OpenMode.Output)
            PrintLine(2, CleanDefs.txtHeader.Text)
            'Add Common Options
            For Each keyvaluepair In d1
                PrintLine(2, keyvaluepair.Value.Text)
            Next
            'Marks beginning of "Other remaining caches" message
            PrintLine(2, CleanDefs2.txtQ12.Text)
            'Add Other Caches
            For Each keyvaluepair In d2
                PrintLine(2, keyvaluepair.Value.Text)
            Next
            'End of remaning caches
            PrintLine(2, CleanDefs2.txtQ13.Text)
            'Add File Extensions
            For Each keyvaluepair In d3
                PrintLine(2, keyvaluepair.Value.Text)
            Next
            'Send Finish Instruction
            PrintLine(2, CleanDefs.txtFinish.Text)
            FileClose(2)

            FileOpen(3, Environ("appdata") & "\DriveTidy\start.bat", OpenMode.Output)
            PrintLine(3, CleanDefs.txtStart1.Text)
            PrintLine(3, CleanDefs.txtAttribRecycle.Text)
            PrintLine(3, CleanDefs.txtAttribSQM.Text)
            PrintLine(3, CleanDefs.txtStart2.Text)
            FileClose(3)
            ShellExecute(0, vbNullString, Environ("appdata") & "\DriveTidy\start.bat", vbNullString, vbNullString, AppWinStyle.NormalFocus)
            'Show Cleaner Window
            CleanerWindow.Show()
            Me.Close()
            CleanDefs.Close()
            CleanDefs2.Close()
            Exit Sub
ErrorHandler:
            CleanerErrors()

            'F numbers start the bar again.
            'If a file extension is selected then it does the
            'Advanced method with F numbers, no file extension = Q numbers
        End If
    End Sub
End Class