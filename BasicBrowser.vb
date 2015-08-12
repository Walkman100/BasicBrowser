Public Class BasicBrowser
    ' Made by ░▒▓█│【Walkman】│█▓▒░
    
    'use CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser) to refer to the webbrowser on the active tab
    
    Friend openWithURI As String
    Dim ReloadTitles() As String = {"Navigation Canceled", "This page can't be displayed", "", "", ""}
    
    Private Sub BasicBrowser_Load() Handles MyBase.Load
        For Each s As String In My.Application.CommandLineArgs
            If openWithURI = "" Then
                openWithURI = s
            Else
                openWithURI = openWithURI & s
            End If
        Next
        
        timerDelayedTab.Start
        For i = 1 To My.Settings.Favourites.Count
            ToolStripURL.Items.Add(My.Settings.Favourites.Item(i - 1))
        Next
    End Sub
    
    Private Sub timerDelayedTab_Tick() Handles timerDelayedTab.Tick
        timerDelayedTab.Stop
        NewTab(openWithURI)
    End Sub
    
    Sub NewTab(Optional url As String = Nothing)
        Dim TabPage As New TabPage()
        Dim WebBrowser As New WebBrowser
        'AddHandler WebBrowser.Navigating, New WebBrowserNavigatingEventHandler(AddressOf Navigate)
        AddHandler WebBrowser.Navigated, New WebBrowserNavigatedEventHandler(AddressOf PerformStuff)
        AddHandler WebBrowser.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PerformStuff)
        AddHandler WebBrowser.ProgressChanged, AddressOf ProgressChanged
        AddHandler WebBrowser.StatusTextChanged, AddressOf StatusTextChanged
        AddHandler WebBrowser.DocumentTitleChanged, AddressOf PerformStuff
        AddHandler WebBrowser.CanGoBackChanged, AddressOf PerformStuff
        AddHandler WebBrowser.CanGoForwardChanged, AddressOf PerformStuff
        TabPage.Text = "Loading..."
        TabControl.TabPages.Add(TabPage)
        TabControl.SelectTab(TabControl.TabCount - 1)
        WebBrowser.Parent = TabPage
        WebBrowser.Dock = DockStyle.Fill
        WebBrowser.Visible = True
        WebBrowser.ScriptErrorsSuppressed = True
        ToolStripReload.Enabled = True
        ToolStripHome.Enabled = True
        ToolStripCloseTab.Enabled = True
        ToolStripGo.Enabled = True
        ToolStripURL.Enabled = True
        ToolStripAdd.Enabled = True
        ToolStripRemove.Enabled = True
        MenuStripFileCloseTab.Enabled = True
        MenuStripFileOpen.Enabled = True
        MenuStripFileSave.Enabled = True
        MenuStripFilePrint.Enabled = True
        MenuStripFilePrintPreview.Enabled = True
        MenuStripViewSource.Enabled = True
        MenuStripToolsSetup.Enabled = True
        MenuStripToolsProperties.Enabled = True
        If IsNothing(url) Then
            WebBrowser.GoHome()
        Else
            WebBrowser.Navigate(url)
        End If
    End Sub
    
    ' MenuStrip options
    
    'File
    Private Sub MenuStripFileNew_Click() Handles MenuStripFileNew.Click, ToolStripNewTab.Click
        NewTab
    End Sub
    
    Private Sub MenuStripFileNew_MouseUp(sender As Object, e As MouseEventArgs) Handles MenuStripFileNew.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            openWithURI = InputBox("Open New Tab and navigate to:", "Enter URL", Clipboard.GetText())
            If openWithURI <> "" Then
                NewTab(openWithURI)
            End If
        End If
    End Sub
    
    Private Sub CloseTab() Handles MenuStripFileCloseTab.Click, ToolStripCloseTab.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Dispose ' To make sure it doesn't take up memory
        Dim TabToClose = TabControl.SelectedIndex
        If TabControl.TabCount > 1 Then
            '     If you have selected the first tab, select the second tab
            If TabControl.SelectedIndex = 0 Then
                TabControl.SelectTab(1)
                ' If you have selected the last tab, select the second last tab
            ElseIf TabControl.TabCount = TabControl.SelectedIndex + 1 Then
                TabControl.SelectTab(TabControl.SelectedIndex - 1)
            Else 'Else select the next tab
                TabControl.SelectTab(TabControl.SelectedIndex + 1)
            End If
        End If
        TabControl.TabPages.RemoveAt(TabToClose)
        
        If TabControl.TabCount = 0 Then
            ToolStripBack.Enabled = False
            ToolStripForward.Enabled = False
            ToolStripReload.Enabled = False
            ToolStripStop.Enabled = False
            ToolStripHome.Enabled = False
            ToolStripCloseTab.Enabled = False
            ToolStripAdd.Enabled = False
            ToolStripRemove.Enabled = False
            MenuStripFileCloseTab.Enabled = False
            MenuStripFileOpen.Enabled = False
            MenuStripFileSave.Enabled = False
            MenuStripFilePrint.Enabled = False
            MenuStripFilePrintPreview.Enabled = False
            MenuStripViewSource.Enabled = False
            MenuStripToolsSetup.Enabled = False
            MenuStripToolsProperties.Enabled = False
        Else
            PerformStuff()
        End If
    End Sub
    
    Private Sub MenuStripFileNewWindow_Click() Handles MenuStripFileNewWindow.Click
        Dim NewWindow As BasicBrowser = New BasicBrowser
        NewWindow.Show()
    End Sub
    
    Private Sub MenuStripFileCloseWindow_Click() Handles MenuStripFileCloseWindow.Click
        For i = 1 To TabControl.TabCount
            CType(TabControl.TabPages.Item(0).Controls.Item(0), WebBrowser).Dispose
            TabControl.TabPages.RemoveAt(0)
        Next
        Me.Close()
    End Sub
    
    Private Sub MenuStripFileOpen_Click() Handles MenuStripFileOpen.Click
        Dim OpenFileDialog As New OpenFileDialog()
        OpenFileDialog.FileName = ""
        OpenFileDialog.Filter = "Webpages|*.html|All Files|*.*"
        OpenFileDialog.Title = "Open File"
        If (OpenFileDialog.ShowDialog() = DialogResult.OK) Then
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentText = IO.File.ReadAllText(OpenFileDialog.FileName)
        End If
    End Sub
    
    Private Sub MenuStripFileSave_Click() Handles MenuStripFileSave.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowSaveAsDialog()
    End Sub
    
    Private Sub MenuStripFilePrint_Click() Handles MenuStripFilePrint.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintDialog()
    End Sub
    
    Private Sub MenuStripFilePrintPreview_Click() Handles MenuStripFilePrintPreview.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
        Me.WindowState = FormWindowState.Minimized
    End Sub
    
    Private Sub ExitBasicBrowser() Handles MenuStripFileExit.Click
        MenuStripFileCloseWindow_Click()
        Application.Exit()
    End Sub
    
    'View
    Private Sub MenuStripViewKeepOnTop_CheckedChanged() Handles MenuStripViewKeepOnTop.CheckedChanged
        Me.TopMost = MenuStripViewKeepOnTop.Checked
    End Sub
    
    Private Sub MenuStripViewOpacityLbl_Click() Handles MenuStripViewOpacityLbl.Click
        MenuStripViewOpacityCbx.Focus()
    End Sub
    
    Private Sub MenuStripViewOpacityCbx_TextChanged() Handles MenuStripViewOpacityCbx.TextChanged
        Try
            Me.Opacity = MenuStripViewOpacityCbx.Text.Remove(MenuStripViewOpacityCbx.Text.LastIndexOf("%")) / 100
        Catch ex As Exception
            StatusStripStatusText.Text = "Error[SetOpacity]: " & ex.Message & ", " & MenuStripViewOpacityCbx.Text
        End Try
    End Sub
    
    Private Sub MenuStripViewSource_Click() Handles MenuStripViewSource.Click
        Dim sourceForm As New Form()
        sourceForm.Width = 450
        sourceForm.Height = 350
        sourceForm.StartPosition = FormStartPosition.CenterParent
        sourceForm.WindowState = Me.WindowState
        sourceForm.Show()
        sourceForm.Icon = My.Resources.Resources.sourceCode
        sourceForm.Text = "Source Code for " & CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        Dim sourceCode As New TextBox()
        sourceCode.Dock = DockStyle.Fill
        sourceForm.Controls.Add(sourceCode)
        sourceCode.Multiline = True
        sourceCode.ScrollBars = ScrollBars.Both
        sourceCode.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentText
    End Sub
    
    'Tools
    Private Sub MenuStripToolsSetup_Click() Handles MenuStripToolsSetup.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPageSetupDialog()
    End Sub
    
    Private Sub MenuStripToolsProperties_Click() Handles MenuStripToolsProperties.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub
    
    Private Sub MenuStripToolsInternetProperties_Click() Handles MenuStripToolsInternetProperties.Click
        Process.Start("inetcpl.cpl")
    End Sub
    
    Private Sub MenuStripToolsInternetProxy_Click() Handles MenuStripToolsInternetProxy.Click
        Process.Start("inetcpl.cpl", ",4")
    End Sub
    
    Private Sub MenuStripToolsInternetAddons_Click() Handles MenuStripToolsInternetAddons.Click
        Process.Start("inetcpl.cpl", ",5")
    End Sub
    
    Private Sub MenuStripToolsNetworkDiagnostics_Click() Handles MenuStripToolsNetworkDiagnostics.Click
        Process.Start("rundll32.exe", "ndfapi,NdfRunDllDiagnoseIncident")
        'Can also do ("msdt.exe", "-skip TRUE -path " & Environment.GetEnvironmentVariable("WinDir") & "\diagnostics\system\networking -ep NetworkDiagnosticsPNI")
    End Sub
    
    Private Sub MenuStripToolsAutoReload_MouseUp(sender As Object, e As MouseEventArgs) Handles MenuStripToolsAutoReload.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            For i = 1 To ReloadTitles.Length
                ReloadTitles.SetValue(InputBox("Page title no. " & i & ":", "Auto-Reload required titles", ReloadTitles.GetValue(i - 1)), i - 1)
                If DialogResult = Windows.Forms.DialogResult.Cancel Then
                    ' this doesn't seem to pick up that the cancel button was pressed
                    Exit Sub
                End If
            Next
        End If
    End Sub
    
    'About
    Private Sub MenuStripHelpAbout_Click() Handles MenuStripHelpAbout.Click
        Dim AboutForm As New Form()
        AboutForm.Width = 450
        AboutForm.Height = 350
        AboutForm.StartPosition = FormStartPosition.CenterParent
        AboutForm.Show()
        AboutForm.Icon = My.Resources.Resources.sourceCode
        AboutForm.Text = "About BasicBrowser"
        Dim lblAboutText As New Label()
        lblAboutText.Dock = DockStyle.Fill
        AboutForm.Controls.Add(lblAboutText)
        lblAboutText.TextAlign = ContentAlignment.MiddleCenter
        lblAboutText.Text = _
            "Made by ░▒▓█│【Walkman】│█▓▒░ (Walkman100)" & vbNewLine & vbNewLine & _
            "Source code available at: https://github.com/Walkman100/BasicBrowser" & vbNewLine & vbNewLine & _
            "Go to https://github.com/Walkman100/BasicBrowser/issues/new to report bugs or suggest features" & vbNewLine & vbNewLine & _
            "Hold ALT to reorganise all the buttons/menus at the top" & vbNewLine & vbNewLine & _
            "Current Version: " & My.Application.Info.Version.ToString
    End Sub
    
    Private Sub MenuStripHelpAbout_MouseUp(sender As Object, e As MouseEventArgs) Handles MenuStripHelpAbout.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            NewTab("https://github.com/Walkman100/BasicBrowser/releases/latest")
        End If
    End Sub
    
    ' ToolStrip buttons
    
    Private Sub ToolStripBack_ButtonClick() Handles ToolStripBack.ButtonClick
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
        PerformStuff()
    End Sub
    
    Private Sub ToolStripBack_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStripBack.DropDownItemClicked
        ToolStripBack.DropDownItems.Clear()
        'For i = 1 To CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).History.Items
        '   ToolStripBack.DropDownItems.Add(CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).History.Item(i))
        'Next
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(e.ClickedItem.Text)
    End Sub
    
    Private Sub ToolStripForward_ButtonClick() Handles ToolStripForward.ButtonClick
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
        PerformStuff()
    End Sub
    
    Private Sub ToolStripReload_Click() Handles ToolStripReload.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
        PerformStuff()
    End Sub
    
    Private Sub ToolStripStop_Click() Handles ToolStripStop.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Stop()
        PerformStuff()
    End Sub
    
    Private Sub ToolStripHome_Click() Handles ToolStripHome.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
        PerformStuff()
    End Sub
    
    Private Sub ToolStripURL_GotFocus() Handles ToolStripURL.GotFocus
        ToolStripURL.SelectAll()
    End Sub
    
    Private Sub ToolStripURL_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripURL.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripGo_Click()
        End If
    End Sub
    
    Private Sub ToolStripURL_SelectedIndexChanged() Handles ToolStripURL.SelectedIndexChanged
        If TabControl.TabCount = 0 Then
            NewTab(ToolStripURL.SelectedItem.ToString)
        Else
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ToolStripURL.SelectedItem.ToString)
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Focus()
        End If
        ToolStripURL.Invalidate()
    End Sub
    
    Private Sub ToolStripGo_Click() Handles ToolStripGo.Click
        If ToolStripURL.Text <> "" Then
            If TabControl.TabCount = 0 Then
                NewTab(ToolStripURL.Text)
            Else
                CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ToolStripURL.Text)
            End If
        Else
            ToolStripURL.Focus()
        End If
    End Sub
    
    Private Sub ToolStripAdd_Click() Handles ToolStripAdd.Click
        ToolStripURL.Items.Add(CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
        My.Settings.Favourites.Add(CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
        My.Settings.Save()
    End Sub
    
    Private Sub ToolStripRemove_Click() Handles ToolStripRemove.Click
        ToolStripURL.Items.RemoveAt(ToolStripURL.SelectedIndex)
        My.Settings.Favourites.Remove(ToolStripURL.SelectedItem)
        My.Settings.Save()
    End Sub
    
    Private Sub BasicBrowser_SizeChanged() Handles MyBase.SizeChanged, MyBase.Resize
        ToolStripURL.Size = New Size(Me.Width - 243, ToolStripURL.Height)
    End Sub
    
    ' browser stuff
    
    Private Sub ProgressChanged(sender As Object, e As Windows.Forms.WebBrowserProgressChangedEventArgs)
        StatusStripProgressBar.Value = (e.CurrentProgress / e.MaximumProgress) * 100
        If ToolStripURL.Focused = False Then
            ToolStripURL.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        End If
    End Sub
    
    Private Sub StatusTextChanged()
        StatusStripStatusText.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).StatusText
    End Sub
    
    Private Sub PerformStuff() Handles TabControl.Click, TabControl.KeyUp
        ' Update window title
        If CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle <> "" Then
            Me.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle & " - BasicBrowser"
        End If
        
        ' Update all tab names
        For i = 1 To TabControl.TabCount
            TabControl.TabPages.Item(i - 1).Text = CType(TabControl.TabPages.Item(i - 1).Controls.Item(0), WebBrowser).DocumentTitle
        Next
        
        ' Reload tab if bad name
        If MenuStripToolsAutoReload.Checked = True Then
            For i = 1 To TabControl.TabCount
                If ReloadTitles.Contains(CType(TabControl.TabPages.Item(i - 1).Controls.Item(0), WebBrowser).DocumentTitle) Then
                    StatusStripStatusText.Text = "Refreshing now..."
                    ' It seems that you have to run the edit loop before it will get here
                    CType(TabControl.TabPages.Item(i - 1).Controls.Item(0), WebBrowser).Refresh()
                End If
            Next
        End If
        
        ' Update buttons
        Try
            ToolStripStop.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).IsBusy
        Catch ex As Exception
            StatusStripStatusText.Text = "Error[CheckBusy]: " & ex.Message
            ToolStripStop.Enabled = False
        End Try
        Try
            ToolStripBack.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack
        Catch ex As Exception
            StatusStripStatusText.Text = "Error[CheckBack]: " & ex.Message
            ToolStripBack.Enabled = False
        End Try
        Try
            ToolStripForward.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward
        Catch ex As Exception
            StatusStripStatusText.Text = "Error[CheckForward]: " & ex.Message
            ToolStripForward.Enabled = False
        End Try
        
        ' Update URL bar
        If ToolStripURL.Focused = False Then
            Try
                ToolStripURL.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
            Catch ex As Exception
                StatusStripStatusText.Text = "Error[GetURL]: " & ex.Message
                ToolStripURL.Text = ""
            End Try
        End If
    End Sub
End Class
