Public Class BasicBrowser
   Private Sub BasicBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.DoubleClick
        ToolStripNewTab_Click(Nothing, Nothing)
    End Sub

    ' menu strip options

    Private Sub MenuStripFileExit_Click(sender As Object, e As EventArgs) Handles MenuStripFileExit.Click
        Application.Exit()
    End Sub

    ' tool strip options

    Private Sub ToolStripBack_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripBack.ButtonClick
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    Private Sub ToolStripForward_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripForward.ButtonClick
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub

    Private Sub ToolStripReload_Click(sender As Object, e As EventArgs) Handles ToolStripReload.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub

    Private Sub ToolStripStop_Click(sender As Object, e As EventArgs) Handles ToolStripStop.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Stop()
    End Sub

    Private Sub ToolStripHome_Click(sender As Object, e As EventArgs) Handles ToolStripHome.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
    End Sub

    Private Sub ToolStripNewTab_Click(sender As Object, e As EventArgs) Handles ToolStripNewTab.Click
        Dim TabPage As New TabPage()
        Dim WebBrowser As New WebBrowser
        AddHandler WebBrowser.Navigating, AddressOf Navigating
        AddHandler WebBrowser.Navigated, AddressOf Navigated
        AddHandler WebBrowser.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf DocumentCompleted)
        
        TabPage.Text = "Loading Tab " & (TabControl.TabPages.Count + 1)
        TabControl.TabPages.Add(TabPage)

        WebBrowser.GoHome()
        WebBrowser.Parent = TabPage
        WebBrowser.Visible = True
        WebBrowser.Dock = DockStyle.Fill
        TabControl.SelectTab(TabControl.TabCount - 1)
    End Sub

    Private Sub ToolStripCloseTab_Click(sender As Object, e As EventArgs) Handles ToolStripCloseTab.Click
        If TabControl.SelectedIndex <> 0 Then
            TabControl.SelectTab(TabControl.SelectedIndex - 1)
        End If
        If TabControl.TabCount = 1 Then
            TabControl.TabPages.RemoveAt(TabControl.SelectedIndex)
        Else
            TabControl.TabPages.RemoveAt(TabControl.SelectedIndex + 1)
        End If
    End Sub

    ' browser stuff

    Sub Navigating()

    End Sub

    Sub Navigated()
        Me.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle & " - BasicBrowser"
        TabControl.SelectedTab.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
    End Sub

    Sub DocumentCompleted()
        Me.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle & " - BasicBrowser"
        TabControl.SelectedTab.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
    End Sub
End Class