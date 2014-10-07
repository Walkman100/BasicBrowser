<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicBrowser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BasicBrowser))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuStripFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileCloseTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFilePrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripEditUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripEditRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripEditSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripEditSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripEditSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripToolsCustomize = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripToolsOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpContents = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpIndex = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusStripProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStripStatusText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBack = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripForward = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripReload = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripStop = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripNewTab = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripCloseTab = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Location = New System.Drawing.Point(0, 52)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(435, 304)
        Me.TabControl.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripFile, Me.MenuStripEdit, Me.MenuStripTools, Me.MenuStripHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip.Size = New System.Drawing.Size(435, 24)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MenuStripFile
        '
        Me.MenuStripFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripFileNew, Me.MenuStripFileCloseTab, Me.MenuStripFileSeparator1, Me.MenuStripFileSave, Me.MenuStripFileSeparator2, Me.MenuStripFilePrint, Me.MenuStripFilePrintPreview, Me.MenuStripFileSeparator3, Me.MenuStripFileExit})
        Me.MenuStripFile.Name = "MenuStripFile"
        Me.MenuStripFile.Size = New System.Drawing.Size(38, 20)
        Me.MenuStripFile.Text = "&File"
        '
        'MenuStripFileNew
        '
        Me.MenuStripFileNew.Image = Global.BasicBrowser.My.Resources.Resources._1387146817_tab_new
        Me.MenuStripFileNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileNew.Name = "MenuStripFileNew"
        Me.MenuStripFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.MenuStripFileNew.Size = New System.Drawing.Size(179, 22)
        Me.MenuStripFileNew.Text = "&New Tab"
        '
        'MenuStripFileCloseTab
        '
        Me.MenuStripFileCloseTab.Image = Global.BasicBrowser.My.Resources.Resources._1391271889_emblem_unreadable
        Me.MenuStripFileCloseTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileCloseTab.Name = "MenuStripFileCloseTab"
        Me.MenuStripFileCloseTab.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.MenuStripFileCloseTab.Size = New System.Drawing.Size(179, 22)
        Me.MenuStripFileCloseTab.Text = "&Close Tab"
        '
        'MenuStripFileSeparator1
        '
        Me.MenuStripFileSeparator1.Name = "MenuStripFileSeparator1"
        Me.MenuStripFileSeparator1.Size = New System.Drawing.Size(176, 6)
        '
        'MenuStripFileSave
        '
        Me.MenuStripFileSave.Image = CType(resources.GetObject("MenuStripFileSave.Image"), System.Drawing.Image)
        Me.MenuStripFileSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileSave.Name = "MenuStripFileSave"
        Me.MenuStripFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.MenuStripFileSave.Size = New System.Drawing.Size(179, 22)
        Me.MenuStripFileSave.Text = "&Save As..."
        '
        'MenuStripFileSeparator2
        '
        Me.MenuStripFileSeparator2.Name = "MenuStripFileSeparator2"
        Me.MenuStripFileSeparator2.Size = New System.Drawing.Size(176, 6)
        '
        'MenuStripFilePrint
        '
        Me.MenuStripFilePrint.Image = CType(resources.GetObject("MenuStripFilePrint.Image"), System.Drawing.Image)
        Me.MenuStripFilePrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFilePrint.Name = "MenuStripFilePrint"
        Me.MenuStripFilePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.MenuStripFilePrint.Size = New System.Drawing.Size(179, 22)
        Me.MenuStripFilePrint.Text = "&Print..."
        '
        'MenuStripFilePrintPreview
        '
        Me.MenuStripFilePrintPreview.Image = CType(resources.GetObject("MenuStripFilePrintPreview.Image"), System.Drawing.Image)
        Me.MenuStripFilePrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFilePrintPreview.Name = "MenuStripFilePrintPreview"
        Me.MenuStripFilePrintPreview.Size = New System.Drawing.Size(179, 22)
        Me.MenuStripFilePrintPreview.Text = "Print Pre&view..."
        '
        'MenuStripFileSeparator3
        '
        Me.MenuStripFileSeparator3.Name = "MenuStripFileSeparator3"
        Me.MenuStripFileSeparator3.Size = New System.Drawing.Size(176, 6)
        '
        'MenuStripFileExit
        '
        Me.MenuStripFileExit.Name = "MenuStripFileExit"
        Me.MenuStripFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.MenuStripFileExit.Size = New System.Drawing.Size(179, 22)
        Me.MenuStripFileExit.Text = "E&xit"
        '
        'MenuStripEdit
        '
        Me.MenuStripEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripEditUndo, Me.MenuStripEditRedo, Me.MenuStripEditSeparator1, Me.MenuStripEditCut, Me.MenuStripEditCopy, Me.MenuStripEditPaste, Me.MenuStripEditSeparator2, Me.MenuStripEditSelectAll})
        Me.MenuStripEdit.Name = "MenuStripEdit"
        Me.MenuStripEdit.Size = New System.Drawing.Size(40, 20)
        Me.MenuStripEdit.Text = "&Edit"
        '
        'MenuStripEditUndo
        '
        Me.MenuStripEditUndo.Name = "MenuStripEditUndo"
        Me.MenuStripEditUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.MenuStripEditUndo.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripEditUndo.Text = "&Undo"
        '
        'MenuStripEditRedo
        '
        Me.MenuStripEditRedo.Name = "MenuStripEditRedo"
        Me.MenuStripEditRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.MenuStripEditRedo.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripEditRedo.Text = "&Redo"
        '
        'MenuStripEditSeparator1
        '
        Me.MenuStripEditSeparator1.Name = "MenuStripEditSeparator1"
        Me.MenuStripEditSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'MenuStripEditCut
        '
        Me.MenuStripEditCut.Image = CType(resources.GetObject("MenuStripEditCut.Image"), System.Drawing.Image)
        Me.MenuStripEditCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripEditCut.Name = "MenuStripEditCut"
        Me.MenuStripEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.MenuStripEditCut.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripEditCut.Text = "Cu&t"
        '
        'MenuStripEditCopy
        '
        Me.MenuStripEditCopy.Image = CType(resources.GetObject("MenuStripEditCopy.Image"), System.Drawing.Image)
        Me.MenuStripEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripEditCopy.Name = "MenuStripEditCopy"
        Me.MenuStripEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.MenuStripEditCopy.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripEditCopy.Text = "&Copy"
        '
        'MenuStripEditPaste
        '
        Me.MenuStripEditPaste.Image = CType(resources.GetObject("MenuStripEditPaste.Image"), System.Drawing.Image)
        Me.MenuStripEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripEditPaste.Name = "MenuStripEditPaste"
        Me.MenuStripEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.MenuStripEditPaste.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripEditPaste.Text = "&Paste"
        '
        'MenuStripEditSeparator2
        '
        Me.MenuStripEditSeparator2.Name = "MenuStripEditSeparator2"
        Me.MenuStripEditSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'MenuStripEditSelectAll
        '
        Me.MenuStripEditSelectAll.Name = "MenuStripEditSelectAll"
        Me.MenuStripEditSelectAll.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripEditSelectAll.Text = "Select &All"
        '
        'MenuStripTools
        '
        Me.MenuStripTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripToolsCustomize, Me.MenuStripToolsOptions})
        Me.MenuStripTools.Name = "MenuStripTools"
        Me.MenuStripTools.Size = New System.Drawing.Size(49, 20)
        Me.MenuStripTools.Text = "&Tools"
        '
        'MenuStripToolsCustomize
        '
        Me.MenuStripToolsCustomize.Name = "MenuStripToolsCustomize"
        Me.MenuStripToolsCustomize.Size = New System.Drawing.Size(221, 22)
        Me.MenuStripToolsCustomize.Text = "Page &Setup..."
        '
        'MenuStripToolsOptions
        '
        Me.MenuStripToolsOptions.Name = "MenuStripToolsOptions"
        Me.MenuStripToolsOptions.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.MenuStripToolsOptions.Size = New System.Drawing.Size(221, 22)
        Me.MenuStripToolsOptions.Text = "Page P&roperties..."
        '
        'MenuStripHelp
        '
        Me.MenuStripHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripHelpContents, Me.MenuStripHelpIndex, Me.MenuStripHelpSearch, Me.MenuStripHelpSeparator, Me.MenuStripHelpAbout})
        Me.MenuStripHelp.Name = "MenuStripHelp"
        Me.MenuStripHelp.Size = New System.Drawing.Size(44, 20)
        Me.MenuStripHelp.Text = "&Help"
        '
        'MenuStripHelpContents
        '
        Me.MenuStripHelpContents.Name = "MenuStripHelpContents"
        Me.MenuStripHelpContents.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripHelpContents.Text = "&Contents"
        '
        'MenuStripHelpIndex
        '
        Me.MenuStripHelpIndex.Name = "MenuStripHelpIndex"
        Me.MenuStripHelpIndex.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripHelpIndex.Text = "&Index"
        '
        'MenuStripHelpSearch
        '
        Me.MenuStripHelpSearch.Name = "MenuStripHelpSearch"
        Me.MenuStripHelpSearch.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripHelpSearch.Text = "&Search"
        '
        'MenuStripHelpSeparator
        '
        Me.MenuStripHelpSeparator.Name = "MenuStripHelpSeparator"
        Me.MenuStripHelpSeparator.Size = New System.Drawing.Size(149, 6)
        '
        'MenuStripHelpAbout
        '
        Me.MenuStripHelpAbout.Name = "MenuStripHelpAbout"
        Me.MenuStripHelpAbout.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripHelpAbout.Text = "&About..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusStripProgressBar, Me.StatusStripStatusText})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 359)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(435, 22)
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'StatusStripProgressBar
        '
        Me.StatusStripProgressBar.Name = "StatusStripProgressBar"
        Me.StatusStripProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.StatusStripProgressBar.Value = 1
        '
        'StatusStripStatusText
        '
        Me.StatusStripStatusText.Name = "StatusStripStatusText"
        Me.StatusStripStatusText.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip
        '
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBack, Me.ToolStripForward, Me.ToolStripReload, Me.ToolStripStop, Me.ToolStripHome, Me.ToolStripSeparator1, Me.ToolStripNewTab, Me.ToolStripCloseTab, Me.ToolStripSeparator2})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(435, 25)
        Me.ToolStrip.TabIndex = 4
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripBack
        '
        Me.ToolStripBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBack.Image = Global.BasicBrowser.My.Resources.Resources._1391274420_go_previous
        Me.ToolStripBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBack.Name = "ToolStripBack"
        Me.ToolStripBack.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripBack.Text = "&Back"
        '
        'ToolStripForward
        '
        Me.ToolStripForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripForward.Image = Global.BasicBrowser.My.Resources.Resources._1391274345_go_next
        Me.ToolStripForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripForward.Name = "ToolStripForward"
        Me.ToolStripForward.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripForward.Text = "&Forward"
        '
        'ToolStripReload
        '
        Me.ToolStripReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripReload.Image = Global.BasicBrowser.My.Resources.Resources._1391271803_view_refresh
        Me.ToolStripReload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripReload.Name = "ToolStripReload"
        Me.ToolStripReload.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripReload.Text = "&Reload"
        '
        'ToolStripStop
        '
        Me.ToolStripStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripStop.Image = Global.BasicBrowser.My.Resources.Resources._1387140136_process_stop
        Me.ToolStripStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripStop.Name = "ToolStripStop"
        Me.ToolStripStop.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripStop.Text = "&Stop"
        '
        'ToolStripHome
        '
        Me.ToolStripHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripHome.Image = Global.BasicBrowser.My.Resources.Resources._1371833355_go_home
        Me.ToolStripHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripHome.Name = "ToolStripHome"
        Me.ToolStripHome.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripHome.Text = "&Home"
        '
        'ToolStripNewTab
        '
        Me.ToolStripNewTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripNewTab.Image = Global.BasicBrowser.My.Resources.Resources._1387146817_tab_new
        Me.ToolStripNewTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripNewTab.Name = "ToolStripNewTab"
        Me.ToolStripNewTab.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripNewTab.Text = "New Tab"
        '
        'ToolStripCloseTab
        '
        Me.ToolStripCloseTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripCloseTab.Image = Global.BasicBrowser.My.Resources.Resources._1391271889_emblem_unreadable
        Me.ToolStripCloseTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCloseTab.Name = "ToolStripCloseTab"
        Me.ToolStripCloseTab.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripCloseTab.Text = "Close Tab"
        '
        'BasicBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 381)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "BasicBrowser"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BasicBrowser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStripFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFileNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFileCloseTab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFileSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFileSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripFilePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFilePrintPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFileSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEditUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEditRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEditSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripEditCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEditCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEditPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripEditSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripEditSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripToolsCustomize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripToolsOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripHelpContents As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripHelpIndex As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripHelpSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripHelpSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripBack As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripForward As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripReload As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripHome As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripNewTab As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCloseTab As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents StatusStripStatusText As System.Windows.Forms.ToolStripStatusLabel

End Class
