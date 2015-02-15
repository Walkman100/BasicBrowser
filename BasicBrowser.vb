Public Class BasicBrowser
    ' Made by ░▒▓█│【Walkman】│█▓▒░

    'use CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser) to refer to the webbrowser on the active tab

    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BasicBrowser)) ' Copied from the designer, so i can get resources at RunTime

    Public openWithURI As String
    Dim TabToClose As Integer
    Dim ReloadTitles() As String = {"Navigation Canceled", "This page can't be displayed", Nothing, Nothing, Nothing}

    Private Sub BasicBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each s As String In My.Application.CommandLineArgs
            If openWithURI = "" Then
                openWithURI = s
            Else
                openWithURI = openWithURI & s
            End If
        Next

        NewTab(Nothing, Nothing)
        For i = 1 To My.Settings.Favourites.Count
            ToolStripURL.Items.Add(My.Settings.Favourites.Item(i - 1))
        Next
    End Sub

    ' MenuStrip options

    'File
    Sub NewTab(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles ToolStripNewTab.Click, MenuStripFileNew.Click
        Dim TabPage As New TabPage()
        Dim WebBrowser As New WebBrowser
        'AddHandler WebBrowser.Navigating, New WebBrowserNavigatingEventHandler(AddressOf Navigate)
        AddHandler WebBrowser.Navigated, New WebBrowserNavigatedEventHandler(AddressOf Navigate)
        AddHandler WebBrowser.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf DocumentCompleted)
        AddHandler WebBrowser.ProgressChanged, AddressOf ProgressChanged
        AddHandler WebBrowser.StatusTextChanged, AddressOf StatusTextChanged
        AddHandler WebBrowser.DocumentTitleChanged, AddressOf DocumentTitleChanged
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
        If openWithURI = "" Then
            WebBrowser.GoHome()
        Else
            WebBrowser.Navigate(openWithURI)
            openWithURI = ""
        End If
    End Sub

    Private Sub CloseTab(sender As Object, e As EventArgs) Handles ToolStripCloseTab.Click, MenuStripFileCloseTab.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Dispose ' To make sure it doesn't take up memory
        TabToClose = TabControl.SelectedIndex
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

    Private Sub MenuStripFileNewWindow_Click(sender As Object, e As EventArgs) Handles MenuStripFileNewWindow.Click
        Dim NewWindow As BasicBrowser = New BasicBrowser
        NewWindow.Show()
    End Sub

    Private Sub MenuStripFileCloseWindow_Click(sender As Object, e As EventArgs) Handles MenuStripFileCloseWindow.Click
        For i = 1 To TabControl.TabCount
            CType(TabControl.TabPages.Item(0).Controls.Item(0), WebBrowser).Navigate("about:blank")
            TabControl.TabPages.RemoveAt(0)
        Next
        Me.Close()
    End Sub

    Private Sub MenuStripFileOpen_Click(sender As Object, e As EventArgs) Handles MenuStripFileOpen.Click
        Dim OpenFileDialog As New OpenFileDialog()
        OpenFileDialog.FileName = ""
        OpenFileDialog.Filter = "Webpages|*.html|All Files|*.*"
        OpenFileDialog.Title = "Open Webpage"
        If (OpenFileDialog.ShowDialog() = DialogResult.OK) Then
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentText = System.IO.File.ReadAllText(OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub MenuStripFileSave_Click(sender As Object, e As EventArgs) Handles MenuStripFileSave.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowSaveAsDialog()
    End Sub

    Private Sub MenuStripFilePrint_Click(sender As Object, e As EventArgs) Handles MenuStripFilePrint.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintDialog()
    End Sub

    Private Sub MenuStripFilePrintPreview_Click(sender As Object, e As EventArgs) Handles MenuStripFilePrintPreview.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ExitBasicBrowser(sender As Object, e As EventArgs) Handles MenuStripFileExit.Click
        MenuStripFileCloseWindow_Click(Nothing, Nothing)
        Application.Exit()
    End Sub
    
    Private Sub MenuStripFileNew_MouseUp(sender As Object, e As MouseEventArgs) Handles MenuStripFileNew.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            openWithURI = InputBox("Open New Tab and navigate to:", "Enter URL", Clipboard.GetText())
            NewTab()
        End If
    End Sub

    'View
    Private Sub MenuStripViewKeepOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles MenuStripViewKeepOnTop.CheckedChanged
        Me.TopMost = MenuStripViewKeepOnTop.Checked
    End Sub

    Private Sub MenuStripViewOpacityLbl_Click(sender As Object, e As EventArgs) Handles MenuStripViewOpacityLbl.Click
        MenuStripViewOpacityCbx.Focus()
    End Sub

    Private Sub MenuStripViewOpacityCbx_TextChanged(sender As Object, e As EventArgs) Handles MenuStripViewOpacityCbx.TextChanged
        Me.Opacity = MenuStripViewOpacityCbx.Text.Remove(MenuStripViewOpacityCbx.Text.LastIndexOf("%")) / 100
    End Sub

    Private Sub MenuStripViewSource_Click(sender As Object, e As EventArgs) Handles MenuStripViewSource.Click
        Dim sourceForm As New Form()
        sourceForm.Width = 450
        sourceForm.Height = 350
        sourceForm.StartPosition = FormStartPosition.CenterParent
        sourceForm.WindowState = Me.WindowState
        sourceForm.Icon = CType(resources.GetObject("SourceCodeIcon"), System.Drawing.Icon)
        sourceForm.ShowIcon = True
        sourceForm.ShowInTaskbar = True
        sourceForm.Text = "Source Code for " & CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        Dim sourceCode As New TextBox()
        sourceCode.Multiline = True
        sourceCode.ScrollBars = ScrollBars.Both
        sourceForm.Controls.Add(sourceCode)
        sourceCode.Dock = DockStyle.Fill
        sourceCode.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentText
        sourceForm.Show()
    End Sub

    'Tools
    Private Sub MenuStripToolsSetup_Click(sender As Object, e As EventArgs) Handles MenuStripToolsSetup.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPageSetupDialog()
    End Sub

    Private Sub MenuStripToolsProperties_Click(sender As Object, e As EventArgs) Handles MenuStripToolsProperties.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub

    Private Sub MenuStripToolsInternetProperties_Click(sender As Object, e As EventArgs) Handles MenuStripToolsInternetProperties.Click
        Process.Start("inetcpl.cpl")
    End Sub

    Private Sub MenuStripToolsInternetProxy_Click(sender As Object, e As EventArgs) Handles MenuStripToolsInternetProxy.Click
        Process.Start("inetcpl.cpl", ",4")
    End Sub

    Private Sub MenuStripToolsNetworkDiagnostics_Click(sender As Object, e As EventArgs) Handles MenuStripToolsNetworkDiagnostics.Click
        Process.Start("rundll32.exe", "ndfapi,NdfRunDllDiagnoseIncident")
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
    Private Sub MenuStripHelpAbout_Click(sender As Object, e As EventArgs) Handles MenuStripHelpAbout.Click
        Dim AboutForm As New Form()
        AboutForm.Width = 450
        AboutForm.Height = 350
        AboutForm.StartPosition = FormStartPosition.CenterParent
        AboutForm.Icon = CType(resources.GetObject("SourceCodeIcon"), System.Drawing.Icon)
        AboutForm.ShowIcon = True
        AboutForm.ShowInTaskbar = True
        AboutForm.Text = "About BasicBrowser"
        Dim lblAboutText As New Label()
        'lblAboutText.Font = True
        lblAboutText.TextAlign = ContentAlignment.MiddleCenter
        AboutForm.Controls.Add(lblAboutText)
        lblAboutText.Dock = DockStyle.Fill
        lblAboutText.Text = _
            "Made by ░▒▓█│【Walkman】│█▓▒░ (Walkman100)" & vbNewLine & vbNewLine & _
            "Source code available at: https://github.com/Walkman100/BasicBrowser" & vbNewLine & vbNewLine & _
            "Go to https://github.com/Walkman100/BasicBrowser/issues/new to report bugs or suggest features" & vbNewLine & vbNewLine & _
            "Hold ALT to reorganise all the buttons/menus at the top" & vbNewLine & vbNewLine & _
            "Current Version: " & My.Application.Info.Version.ToString
        AboutForm.Show()
    End Sub

    ' ToolStrip buttons

    Private Sub ToolStripBack_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripBack.ButtonClick
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
        ToolStripStop.Enabled = True
        PerformStuff()
    End Sub

    Private Sub ToolStripBack_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStripBack.DropDownItemClicked
        ToolStripBack.DropDownItems.Clear()
        'For i = 1 To CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).History.Items
        '   ToolStripBack.DropDownItems.Add(CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).History.Item(i))
        'Next
    End Sub

    Private Sub ToolStripForward_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripForward.ButtonClick
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
        ToolStripStop.Enabled = True
        PerformStuff()
    End Sub

    Private Sub ToolStripReload_Click(sender As Object, e As EventArgs) Handles ToolStripReload.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
        ToolStripStop.Enabled = True
        PerformStuff()
    End Sub

    Private Sub ToolStripStop_Click(sender As Object, e As EventArgs) Handles ToolStripStop.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Stop()
        ToolStripStop.Enabled = False
        PerformStuff()
    End Sub

    Private Sub ToolStripHome_Click(sender As Object, e As EventArgs) Handles ToolStripHome.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
        ToolStripStop.Enabled = True
        PerformStuff()
    End Sub

    Private Sub ToolStripURL_Click(sender As Object, e As EventArgs) Handles ToolStripURL.GotFocus
        ToolStripURL.SelectAll()
    End Sub

    Private Sub ToolStripURL_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripURL.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripGo_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub ToolStripURL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripURL.SelectedIndexChanged
        If TabControl.TabCount = 0 Then
            openWithURI = ToolStripURL.SelectedItem.ToString
            NewTab()
        Else
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ToolStripURL.SelectedItem.ToString)
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Focus()
        End If
        ToolStripURL.Invalidate()
    End Sub

    Private Sub ToolStripGo_Click(sender As Object, e As EventArgs) Handles ToolStripGo.Click
        If ToolStripURL.Text <> "" Then
            If TabControl.TabCount = 0 Then
                openWithURI = ToolStripURL.Text
                NewTab()
            Else
                CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ToolStripURL.Text)
            End If
        Else
            ToolStripURL.Focus()
        End If
    End Sub

    Private Sub ToolStripAdd_Click(sender As Object, e As EventArgs) Handles ToolStripAdd.Click
        ToolStripURL.Items.Add(CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
        My.Settings.Favourites.Add(CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
        My.Settings.Save()
    End Sub

    Private Sub ToolStripRemove_Click(sender As Object, e As EventArgs) Handles ToolStripRemove.Click
        ToolStripURL.Items.RemoveAt(ToolStripURL.SelectedIndex)
        My.Settings.Favourites.Remove(ToolStripURL.SelectedItem)
        My.Settings.Save()
    End Sub

    Private Sub TabControl_Click(sender As Object, e As EventArgs) Handles TabControl.Click, TabControl.KeyUp
        Try
            ToolStripStop.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).IsBusy
        Catch ex As Exception
            StatusStripStatusText.Text = "Error[CheckBusy]: " & ex.Message
        End Try
        PerformStuff()
    End Sub

    Private Sub BasicBrowser_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged, MyBase.Resize
        ToolStripURL.Size = New Size(Me.Width - 243, ToolStripURL.Height)
    End Sub

    ' browser stuff

    Sub Navigate()
        ToolStripStop.Enabled = True
        PerformStuff()
    End Sub

    Sub DocumentCompleted()
        ToolStripStop.Enabled = False
        PerformStuff()
    End Sub

    Sub ProgressChanged(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserProgressChangedEventArgs)
        StatusStripProgressBar.Value = (e.CurrentProgress / e.MaximumProgress) * 100
        If ToolStripURL.Focused = False Then
            ToolStripURL.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        End If
    End Sub

    Sub StatusTextChanged()
        StatusStripStatusText.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).StatusText
    End Sub

    Sub DocumentTitleChanged()
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
    End Sub

    Sub PerformStuff()
        Try
            ToolStripBack.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack
        Catch ex As Exception
            StatusStripStatusText.Text = "Error[CheckBack]: " & ex.Message
        End Try
        Try
            ToolStripForward.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward
        Catch ex As Exception
            StatusStripStatusText.Text = "Error[CheckForward]: " & ex.Message
        End Try
        If ToolStripURL.Focused = False Then
            Try
                ToolStripURL.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
            Catch ex As Exception
                StatusStripStatusText.Text = "Error[GetURL]: " & ex.Message
            End Try
        End If
    End Sub
End Class
