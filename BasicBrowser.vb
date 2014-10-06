Public Class BasicBrowser
    Private Sub BasicBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.DoubleClick
        Dim NewTabPage As New TabPage()
        Dim WebBrowser As New WebBrowser

        NewTabPage.Text = "TabPage Test" & (TabControl.TabPages.Count + 1)
        TabControl.TabPages.Add(NewTabPage)

        WebBrowser.GoHome()
        WebBrowser.Parent = NewTabPage
        WebBrowser.Visible = True
        WebBrowser.Dock = DockStyle.Fill
    End Sub

    ' menu strip options

    Private Sub MenuStripFileExit_Click(sender As Object, e As EventArgs) Handles MenuStripFileExit.Click
        Application.Exit()
    End Sub

    ' tool strip options

    Private Sub ToolStripBack_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripBack.ButtonClick


    End Sub
End Class
