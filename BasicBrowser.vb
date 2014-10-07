Public Class BasicBrowser
    Private Sub BasicBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewTab(Nothing, Nothing)
    End Sub

    ' menu strip options

    Private Sub NewTab(sender As Object, e As EventArgs) Handles ToolStripNewTab.Click, MenuStripFileNew.Click
        Dim TabPage As New TabPage()
        Dim WebBrowser As New WebBrowser
        AddHandler WebBrowser.Navigating, New WebBrowserNavigatingEventHandler(AddressOf Navigating)
        AddHandler WebBrowser.Navigated, New WebBrowserNavigatedEventHandler(AddressOf Navigated)
        AddHandler WebBrowser.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf DocumentCompleted)

        AddHandler WebBrowser.CanGoBackChanged, AddressOf CanGoBackChanged
        AddHandler WebBrowser.CanGoForwardChanged, AddressOf CanGoForwardChanged

        TabPage.Text = "Loading Tab " & (TabControl.TabPages.Count + 1)
        TabControl.TabPages.Add(TabPage)

        WebBrowser.GoHome()
        WebBrowser.Parent = TabPage
        WebBrowser.Visible = True
        WebBrowser.Dock = DockStyle.Fill
        TabControl.SelectTab(TabControl.TabCount - 1)

       PerformStuff()
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
            MenuStripFileCloseTab.Enabled = False
            ToolStripCloseTab.Enabled = False
        Else
            PerformStuff()
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
    End Sub

    Private Sub ExitBasicBrowser(sender As Object, e As EventArgs) Handles MenuStripFileExit.Click
        For i = 1 To TabControl.TabCount
            TabControl.TabPages.RemoveAt(0)
        Next
        Application.Exit()
    End Sub

    Private Sub MenuStripToolsCustomize_Click(sender As Object, e As EventArgs) Handles MenuStripToolsCustomize.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPageSetupDialog()
    End Sub

    Private Sub MenuStripToolsOptions_Click(sender As Object, e As EventArgs) Handles MenuStripToolsOptions.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub

    ' tool strip options

    Private Sub ToolStripBack_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripBack.ButtonClick
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
        ToolStripStop.Enabled = True
        PerformStuff()
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

    ' browser stuff

    Sub Navigating()
        ToolStripStop.Enabled = True
        PerformStuff()
    End Sub

    Sub Navigated()
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

    Private Sub TabControl_Click(sender As Object, e As EventArgs) Handles TabControl.Click, TabControl.KeyUp
        ToolStripStop.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).IsBusy
        PerformStuff()
    End Sub

    Sub PerformStuff()
        ToolStripBack.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).CanGoBack
        ToolStripForward.Enabled = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).CanGoForward
        Me.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle & " - BasicBrowser"
        TabControl.SelectedTab.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        StatusStripStatusText.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).StatusText
    End Sub
End Class