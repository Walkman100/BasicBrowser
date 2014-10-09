Public Class BasicBrowser

    'use CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser) to refer to the webbrowser on the active tab

    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BasicBrowser)) ' Copied from the designer, so i can get resources at RunTime
    Public openWithURI As String
    Private Sub BasicBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each s As String In My.Application.CommandLineArgs
            If openWithURI <> "" Then
                openWithURI = s
            Else
                openWithURI = openWithURI & s
            End If
        Next

        NewTab(Nothing, Nothing)
        For i = 1 To My.Settings.Favourites.Count
            ToolStripCbxFav.Items.Add(My.Settings.Favourites.Item(i))
        Next
    End Sub

    ' MenuStrip options

    'File
    Sub NewTab(sender As Object, e As EventArgs) Handles ToolStripNewTab.Click, MenuStripFileNew.Click
        Dim TabPage As New TabPage()
        Dim WebBrowser As New WebBrowser
        AddHandler WebBrowser.Navigating, New WebBrowserNavigatingEventHandler(AddressOf Navigate)
        AddHandler WebBrowser.Navigated, New WebBrowserNavigatedEventHandler(AddressOf Navigate)
        AddHandler WebBrowser.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf DocumentCompleted)
        AddHandler WebBrowser.ProgressChanged, AddressOf ProgressChanged
        AddHandler WebBrowser.StatusTextChanged, AddressOf StatusTextChanged
        AddHandler WebBrowser.CanGoBackChanged, AddressOf CanGoBackChanged
        AddHandler WebBrowser.CanGoForwardChanged, AddressOf CanGoForwardChanged
        TabPage.Text = "Loading..."
        TabControl.TabPages.Add(TabPage)
        TabControl.SelectTab(TabControl.TabCount - 1)
        WebBrowser.Parent = TabPage
        WebBrowser.Dock = DockStyle.Fill
        WebBrowser.Visible = True
        ToolStripReload.Enabled = True
        ToolStripHome.Enabled = True
        ToolStripCloseTab.Enabled = True
        ToolStripGo.Enabled = True
        ToolStripURL.Enabled = True
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
        If TabControl.SelectedIndex <> TabControl.TabCount - 1 Then
            TabControl.SelectTab(TabControl.SelectedIndex + 1)
        End If
        If TabControl.SelectedIndex = 0 Or TabControl.SelectedIndex = TabControl.TabCount - 1 Then
            TabControl.TabPages.RemoveAt(TabControl.SelectedIndex)
        Else
            TabControl.TabPages.RemoveAt(TabControl.SelectedIndex - 1)
        End If
        If TabControl.TabCount = 0 Then
            ToolStripBack.Enabled = False
            ToolStripForward.Enabled = False
            ToolStripReload.Enabled = False
            ToolStripStop.Enabled = False
            ToolStripHome.Enabled = False
            ToolStripCloseTab.Enabled = False
            ToolStripGo.Enabled = False
            ToolStripURL.Enabled = False
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
        For i = 1 To TabControl.TabCount
            TabControl.TabPages.RemoveAt(0)
        Next
        Application.Exit()
    End Sub

    'Edit
    'WIP

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

    ' ToolStrip options

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

    Private Sub ToolStripURL_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripURL.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripGo_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub ToolStripURL_Click(sender As Object, e As EventArgs) Handles ToolStripURL.GotFocus
        ToolStripURL.SelectAll()
    End Sub

    Private Sub ToolStripGo_Click(sender As Object, e As EventArgs) Handles ToolStripGo.Click
        If ToolStripURL.Text <> "" Then
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ToolStripURL.Text)
        Else
            ToolStripURL.Focus()
        End If
    End Sub

    Private Sub TabControl_Click(sender As Object, e As EventArgs) Handles TabControl.Click, TabControl.KeyUp
        ToolStripStop.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).IsBusy
        PerformStuff()
    End Sub

    Private Sub BasicBrowser_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged, MyBase.Resize
        ToolStripURL.Size = New Size(Me.Width - 243, 25)
        ToolStripCbxFav.Size = New Size(Me.Width - 308, 23)
    End Sub

    'Favourites bar
    Private Sub ToolStripAdd_Click(sender As Object, e As EventArgs) Handles ToolStripAdd.Click
        ToolStripCbxFav.Items.Add(CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
        My.Settings.Favourites.Add(CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString)
        My.Settings.Save()
    End Sub

    Private Sub ToolStripRemove_Click(sender As Object, e As EventArgs) Handles ToolStripRemove.Click
        ToolStripCbxFav.Items.RemoveAt(ToolStripCbxFav.SelectedIndex)
        My.Settings.Favourites.Remove(ToolStripCbxFav.SelectedItem)
        My.Settings.Save()
    End Sub

    Private Sub ToolStripCbxFav_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripCbxFav.SelectedIndexChanged
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ToolStripCbxFav.SelectedItem.ToString)
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

    Sub CanGoBackChanged()
        ToolStripBack.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack
    End Sub

    Sub CanGoForwardChanged()
        ToolStripForward.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward
    End Sub

    Sub ProgressChanged(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserProgressChangedEventArgs)
        StatusStripProgressBar.Value = (e.CurrentProgress / e.MaximumProgress) * 100
        ToolStripURL.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
    End Sub

    Sub StatusTextChanged()
        StatusStripStatusText.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).StatusText
    End Sub

    Sub PerformStuff()
        ToolStripBack.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack
        ToolStripForward.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward
        If CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle <> "" Then
            Me.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle & " - BasicBrowser"
            TabControl.SelectedTab.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        End If
        ToolStripURL.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
    End Sub
End Class