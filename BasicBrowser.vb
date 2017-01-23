Public Class BasicBrowser
    ' Made by ░▒▓█│【Walkman】│█▓▒░
    
    'use CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser) to refer to the webbrowser on the active tab
    Dim configFilePath As String = Environment.GetEnvironmentVariable("AppData") & "\WalkmanOSS\BasicBrowser.xml"
    
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
        
        If Not IO.Directory.Exists(Environment.GetEnvironmentVariable("AppData") & "\WalkmanOSS") Then
            IO.Directory.CreateDirectory(Environment.GetEnvironmentVariable("AppData") & "\WalkmanOSS")
        End If
        
        If IO.File.Exists(Application.StartupPath & "\BasicBrowser.xml") Then
            configFilePath = Application.StartupPath & "\BasicBrowser.xml"
            ReadConfig(configFilePath)
        ElseIf IO.File.Exists("BasicBrowser.xml") Then
            configFilePath = (New IO.FileInfo("BasicBrowser.xml")).FullName
            ReadConfig(configFilePath)
        ElseIf IO.File.Exists(configFilePath) Then
            ReadConfig(configFilePath)
        End If
        
        timerDelayedTab.Start
    End Sub
    
    Private Sub timerDelayedTab_Tick() Handles timerDelayedTab.Tick
        timerDelayedTab.Stop
        NewTab(openWithURI)
    End Sub
    
    Sub NewTab(Optional url As String = Nothing)
        Dim TabPage As New TabPage()
        Dim WebBrowser As New WebBrowser
        'AddHandler WebBrowser.Navigating, New WebBrowserNavigatingEventHandler(AddressOf Navigate)
        AddHandler WebBrowser.Navigated, AddressOf PerformStuff
        AddHandler WebBrowser.DocumentCompleted, AddressOf PerformStuff
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
        PerformStuff
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
        PerformStuff()
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
        WriteConfig(configFilePath)
        Me.Close()
    End Sub
    
    Private Sub MenuStripFileOpen_Click() Handles MenuStripFileOpen.Click
        Dim OpenFileDialog As New OpenFileDialog()
        OpenFileDialog.FileName = ""
        OpenFileDialog.Filter = "Webpages|*.html|All Files|*.*"
        OpenFileDialog.Title = "Open File"
        If (OpenFileDialog.ShowDialog() = DialogResult.OK) Then
            MenuStripToolsAutoReload.Checked = False
            If TabControl.TabCount = 0 Then
                NewTab("about:Loading...")
            End If
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentText = IO.File.ReadAllText(OpenFileDialog.FileName)
        End If
    End Sub
    
    Private Sub MenuStripFileLink_Click() Handles MenuStripFileOpenLink.Click
        Dim OpenFileDialog As New OpenFileDialog()
        OpenFileDialog.FileName = ""
        OpenFileDialog.Filter = "Webpages|*.html|All Files|*.*"
        OpenFileDialog.Title = "Open File"
        If (OpenFileDialog.ShowDialog() = DialogResult.OK) Then
            If TabControl.TabCount = 0 Then
                NewTab(OpenFileDialog.FileName)
            Else
                CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(OpenFileDialog.FileName)
            End If
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
        Dim sourceCode As New TextBox()
        sourceCode.Dock = DockStyle.Fill
        sourceForm.Controls.Add(sourceCode)
        sourceCode.Multiline = True
        sourceCode.ScrollBars = ScrollBars.Both
        Try
            sourceForm.Text = "Source Code for " & CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
            sourceCode.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentText
        Catch ex As NullReferenceException
            sourceCode.Text = "Could not get source!" & vbNewLine & vbNewLine & ex.ToString
        End Try
    End Sub
    
    'Tools
    Private Sub MenuStripToolsSetup_Click() Handles MenuStripToolsSetup.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPageSetupDialog()
    End Sub
    
    Private Sub MenuStripToolsProperties_Click() Handles MenuStripToolsProperties.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub
    
    Private Sub MenuStripToolsInternetProperties_Click() Handles MenuStripToolsInternetProperties.Click
        Diagnostics.Process.Start("inetcpl.cpl")
    End Sub
    
    Private Sub MenuStripToolsInternetProxy_Click() Handles MenuStripToolsInternetProxy.Click
        Diagnostics.Process.Start("inetcpl.cpl", ",4")
    End Sub
    
    Private Sub MenuStripToolsInternetAddons_Click() Handles MenuStripToolsInternetAddons.Click
        Diagnostics.Process.Start("inetcpl.cpl", ",5")
    End Sub
    
    Private Sub MenuStripToolsNetworkDiagnostics_Click() Handles MenuStripToolsNetworkDiagnostics.Click
        Diagnostics.Process.Start("rundll32.exe", "ndfapi,NdfRunDllDiagnoseIncident")
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
        lblAboutText.TextAlign = Drawing.ContentAlignment.MiddleCenter
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
    
    Private Sub ToolStripUp_Click() Handles ToolStripUp.Click
        Dim tmpURL As String = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
        tmpURL = tmpURL.Remove(tmpURL.Length - 1)
        tmpURL = tmpURL.Remove(tmpURL.LastIndexOf("/"))
        If tmpURL.EndsWith(":") Then tmpURL &= "/"
        If tmpURL <> "http:/" Then CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(tmpURL)
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
        If TabControl.TabCount = 0 Then
            NewTab("about:Loading...")
        End If
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
        WriteConfig(configFilePath)
    End Sub
    
    Private Sub ToolStripRemove_Click() Handles ToolStripRemove.Click
        ToolStripURL.Items.RemoveAt(ToolStripURL.SelectedIndex)
        WriteConfig(configFilePath)
    End Sub
    
    Private Sub BasicBrowser_SizeChanged() Handles MyBase.SizeChanged, MyBase.Resize
        ToolStripURL.Size = New Drawing.Size(Me.Width - 266, 22)
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
        If TypeOf Me.TabControl.SelectedTab Is System.Windows.Forms.TabPage AndAlso TypeOf TabControl.SelectedTab.Controls.Item(0) Is WebBrowser Then
            ' Update window title
            If CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle = "" Then
                Me.Text = "BasicBrowser"
            Else
                Me.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle & " - BasicBrowser"
            End If
            ToolStripBack.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack
            ToolStripForward.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward
            ToolStripUp.Enabled = True
            ToolStripReload.Enabled = True
            ToolStripStop.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).IsBusy
            ToolStripCloseTab.Enabled = True
            ToolStripAdd.Enabled = True
            ToolStripRemove.Enabled = True
            MenuStripFileCloseTab.Enabled = True
            MenuStripFileSave.Enabled = True
            MenuStripFilePrint.Enabled = True
            MenuStripFilePrintPreview.Enabled = True
            MenuStripViewSource.Enabled = True
            MenuStripToolsSetup.Enabled = True
            MenuStripToolsProperties.Enabled = True
            ' Update all tab names
            For i = 1 To TabControl.TabCount
                TabControl.TabPages.Item(i - 1).Text = CType(TabControl.TabPages.Item(i - 1).Controls.Item(0), WebBrowser).DocumentTitle
                If TabControl.TabPages.Item(i-1).Text.Length > 60 Then
                    TabControl.TabPages.Item(i-1).Text = TabControl.TabPages.Item(i-1).Text.Remove(57) & "..."
                End If
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
            ' Update URL bar
            If ToolStripURL.Focused = False Then
                If CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url <> Nothing Then
                    ToolStripURL.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
                End If
            End If
            
        Else
            Me.Text = "BasicBrowser"
            StatusStripStatusText.Text = "No tabs open!"
            
            ToolStripBack.Enabled = False
            ToolStripForward.Enabled = False
            ToolStripUp.Enabled = False
            ToolStripReload.Enabled = False
            ToolStripStop.Enabled = False
            ToolStripCloseTab.Enabled = False
            ToolStripAdd.Enabled = False
            ToolStripRemove.Enabled = False
            MenuStripFileCloseTab.Enabled = False
            MenuStripFileSave.Enabled = False
            MenuStripFilePrint.Enabled = False
            MenuStripFilePrintPreview.Enabled = False
            MenuStripViewSource.Enabled = False
            MenuStripToolsSetup.Enabled = False
            MenuStripToolsProperties.Enabled = False
        End If
    End Sub
    
    Private Sub ReadConfig(path As String)
        Dim reader As Xml.XmlReader = Xml.XmlReader.Create(path)
        Try
            reader.Read()
        Catch ex As Xml.XmlException
            reader.Close
            Exit Sub
        End Try
        
        If reader.IsStartElement() AndAlso reader.Name = "BasicBrowser" Then
            If reader.Read AndAlso reader.IsStartElement() AndAlso reader.Name = "Favourites" Then
                While reader.read
                    If reader.IsStartElement AndAlso reader.Name = "Item" AndAlso reader.Read Then
                        ToolStripURL.Items.Add(reader.Value)
                    End If
                End While
            End If
        End If
        
        reader.Close
        
        If ToolStripURL.Items.Count = 0 Then
            ToolStripURL.Items.Add("http://www.google.com")
            ToolStripURL.Items.Add("http://github.com")
        End If
    End Sub
    
    Private Sub WriteConfig(path As String)
        Dim XMLwSettings As New Xml.XmlWriterSettings()
        XMLwSettings.Indent = True
        Dim writer As Xml.XmlWriter = Xml.XmlWriter.Create(path, XMLwSettings)
        
        writer.WriteStartDocument()
        writer.WriteStartElement("BasicBrowser")
        
        writer.WriteStartElement("Favourites")
        For Each item As String In ToolStripURL.Items
            If item <> "" Then writer.WriteElementString("Item", item)
        Next
        writer.WriteEndElement()
        
        writer.WriteEndElement()
        writer.WriteEndDocument()
        
        writer.Close
    End Sub
End Class
