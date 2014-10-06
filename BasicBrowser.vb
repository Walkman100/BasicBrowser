Public Class BasicBrowser
    Dim FirstTabPage As New TabPage()
    Dim WebBrowser1 As New WebBrowser

    Private Sub BasicBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.DoubleClick
        AddHandler WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf Browser1NavComplete)
        FirstTabPage.Text = "TabPage Test" & (TabControl.TabPages.Count + 1)
        TabControl.TabPages.Add(FirstTabPage)

        WebBrowser1.GoHome()
        WebBrowser1.Parent = FirstTabPage
        WebBrowser1.Visible = True
        WebBrowser1.Dock = DockStyle.Fill
    End Sub

    ' menu strip options

    Private Sub MenuStripFileExit_Click(sender As Object, e As EventArgs) Handles MenuStripFileExit.Click
        Application.Exit()
    End Sub

    ' tool strip options

    Private Sub ToolStripBack_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripBack.ButtonClick
        WebBrowser1.GoBack()
    End Sub

    Private Sub ToolStripForward_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripForward.ButtonClick
        WebBrowser1.GoForward()
    End Sub

    Private Sub ToolStripReload_Click(sender As Object, e As EventArgs) Handles ToolStripReload.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub ToolStripStop_Click(sender As Object, e As EventArgs) Handles ToolStripStop.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub ToolStripHome_Click(sender As Object, e As EventArgs) Handles ToolStripHome.Click
        WebBrowser1.GoHome()
    End Sub

    Private Sub ToolStripNewTab_Click(sender As Object, e As EventArgs) Handles ToolStripNewTab.Click
        Dim NewTabPage As New TabPage()
        Dim WebBrowser As New WebBrowser

        NewTabPage.Text = "TabPage Test" & (TabControl.TabPages.Count + 1)
        TabControl.TabPages.Add(NewTabPage)

        WebBrowser.GoHome()
        WebBrowser.Parent = NewTabPage
        WebBrowser.Visible = True
        WebBrowser.Dock = DockStyle.Fill
    End Sub

    ' browser stuff

    Sub Browser1NavComplete()
        FirstTabPage.Text = WebBrowser1.DocumentTitle
    End Sub
End Class