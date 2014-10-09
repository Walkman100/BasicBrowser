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
        Me.MenuStripFileNewWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileCloseWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripFileOpen = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStripView = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripViewKeepOnTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripViewOpacityLbl = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripViewOpacityCbx = New System.Windows.Forms.ToolStripComboBox()
        Me.MenuStripViewSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripViewSource = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripToolsSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripToolsProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpContents = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpIndex = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripRemove = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusStripProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStripStatusText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripNavigation = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBack = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripForward = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripReload = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripStop = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripNewTab = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripCloseTab = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripURL = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripGo = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStripNavigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Location = New System.Drawing.Point(0, 55)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(642, 301)
        Me.TabControl.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.AllowItemReorder = True
        Me.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripFile, Me.MenuStripEdit, Me.MenuStripView, Me.MenuStripTools, Me.MenuStripHelp, Me.ToolStripAdd, Me.ToolStripRemove})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(642, 27)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MenuStripFile
        '
        Me.MenuStripFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripFileNew, Me.MenuStripFileCloseTab, Me.MenuStripFileNewWindow, Me.MenuStripFileCloseWindow, Me.MenuStripFileSeparator1, Me.MenuStripFileOpen, Me.MenuStripFileSave, Me.MenuStripFileSeparator2, Me.MenuStripFilePrint, Me.MenuStripFilePrintPreview, Me.MenuStripFileSeparator3, Me.MenuStripFileExit})
        Me.MenuStripFile.Name = "MenuStripFile"
        Me.MenuStripFile.Size = New System.Drawing.Size(38, 23)
        Me.MenuStripFile.Text = "&File"
        '
        'MenuStripFileNew
        '
        Me.MenuStripFileNew.Image = Global.BasicBrowser.My.Resources.Resources._1387146817_tab_new
        Me.MenuStripFileNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileNew.Name = "MenuStripFileNew"
        Me.MenuStripFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.MenuStripFileNew.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFileNew.Text = "&New Tab"
        '
        'MenuStripFileCloseTab
        '
        Me.MenuStripFileCloseTab.Image = Global.BasicBrowser.My.Resources.Resources._1391271889_emblem_unreadable
        Me.MenuStripFileCloseTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileCloseTab.Name = "MenuStripFileCloseTab"
        Me.MenuStripFileCloseTab.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.MenuStripFileCloseTab.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFileCloseTab.Text = "&Close Tab"
        '
        'MenuStripFileNewWindow
        '
        Me.MenuStripFileNewWindow.Image = Global.BasicBrowser.My.Resources.Resources._1387139872_window_new
        Me.MenuStripFileNewWindow.Name = "MenuStripFileNewWindow"
        Me.MenuStripFileNewWindow.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.MenuStripFileNewWindow.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFileNewWindow.Text = "New &Window"
        '
        'MenuStripFileCloseWindow
        '
        Me.MenuStripFileCloseWindow.Image = Global.BasicBrowser.My.Resources.Resources.Exit2
        Me.MenuStripFileCloseWindow.Name = "MenuStripFileCloseWindow"
        Me.MenuStripFileCloseWindow.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.MenuStripFileCloseWindow.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFileCloseWindow.Text = "Close W&indow"
        '
        'MenuStripFileSeparator1
        '
        Me.MenuStripFileSeparator1.Name = "MenuStripFileSeparator1"
        Me.MenuStripFileSeparator1.Size = New System.Drawing.Size(237, 6)
        '
        'MenuStripFileOpen
        '
        Me.MenuStripFileOpen.Image = CType(resources.GetObject("MenuStripFileOpen.Image"), System.Drawing.Image)
        Me.MenuStripFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileOpen.Name = "MenuStripFileOpen"
        Me.MenuStripFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.MenuStripFileOpen.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFileOpen.Text = "&Open"
        '
        'MenuStripFileSave
        '
        Me.MenuStripFileSave.Image = CType(resources.GetObject("MenuStripFileSave.Image"), System.Drawing.Image)
        Me.MenuStripFileSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileSave.Name = "MenuStripFileSave"
        Me.MenuStripFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.MenuStripFileSave.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFileSave.Text = "&Save As..."
        '
        'MenuStripFileSeparator2
        '
        Me.MenuStripFileSeparator2.Name = "MenuStripFileSeparator2"
        Me.MenuStripFileSeparator2.Size = New System.Drawing.Size(237, 6)
        '
        'MenuStripFilePrint
        '
        Me.MenuStripFilePrint.Image = CType(resources.GetObject("MenuStripFilePrint.Image"), System.Drawing.Image)
        Me.MenuStripFilePrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFilePrint.Name = "MenuStripFilePrint"
        Me.MenuStripFilePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.MenuStripFilePrint.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFilePrint.Text = "&Print..."
        '
        'MenuStripFilePrintPreview
        '
        Me.MenuStripFilePrintPreview.Image = CType(resources.GetObject("MenuStripFilePrintPreview.Image"), System.Drawing.Image)
        Me.MenuStripFilePrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFilePrintPreview.Name = "MenuStripFilePrintPreview"
        Me.MenuStripFilePrintPreview.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.MenuStripFilePrintPreview.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFilePrintPreview.Text = "Print Pre&view..."
        '
        'MenuStripFileSeparator3
        '
        Me.MenuStripFileSeparator3.Name = "MenuStripFileSeparator3"
        Me.MenuStripFileSeparator3.Size = New System.Drawing.Size(237, 6)
        '
        'MenuStripFileExit
        '
        Me.MenuStripFileExit.Image = Global.BasicBrowser.My.Resources.Resources._16x16_quit
        Me.MenuStripFileExit.Name = "MenuStripFileExit"
        Me.MenuStripFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.MenuStripFileExit.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFileExit.Text = "E&xit"
        '
        'MenuStripEdit
        '
        Me.MenuStripEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripEditUndo, Me.MenuStripEditRedo, Me.MenuStripEditSeparator1, Me.MenuStripEditCut, Me.MenuStripEditCopy, Me.MenuStripEditPaste, Me.MenuStripEditSeparator2, Me.MenuStripEditSelectAll})
        Me.MenuStripEdit.Name = "MenuStripEdit"
        Me.MenuStripEdit.Size = New System.Drawing.Size(40, 23)
        Me.MenuStripEdit.Text = "&Edit"
        '
        'MenuStripEditUndo
        '
        Me.MenuStripEditUndo.Name = "MenuStripEditUndo"
        Me.MenuStripEditUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.MenuStripEditUndo.Size = New System.Drawing.Size(150, 22)
        Me.MenuStripEditUndo.Text = "&Undo"
        '
        'MenuStripEditRedo
        '
        Me.MenuStripEditRedo.Name = "MenuStripEditRedo"
        Me.MenuStripEditRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.MenuStripEditRedo.Size = New System.Drawing.Size(150, 22)
        Me.MenuStripEditRedo.Text = "&Redo"
        '
        'MenuStripEditSeparator1
        '
        Me.MenuStripEditSeparator1.Name = "MenuStripEditSeparator1"
        Me.MenuStripEditSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        'MenuStripEditCut
        '
        Me.MenuStripEditCut.Image = CType(resources.GetObject("MenuStripEditCut.Image"), System.Drawing.Image)
        Me.MenuStripEditCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripEditCut.Name = "MenuStripEditCut"
        Me.MenuStripEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.MenuStripEditCut.Size = New System.Drawing.Size(150, 22)
        Me.MenuStripEditCut.Text = "Cu&t"
        '
        'MenuStripEditCopy
        '
        Me.MenuStripEditCopy.Image = CType(resources.GetObject("MenuStripEditCopy.Image"), System.Drawing.Image)
        Me.MenuStripEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripEditCopy.Name = "MenuStripEditCopy"
        Me.MenuStripEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.MenuStripEditCopy.Size = New System.Drawing.Size(150, 22)
        Me.MenuStripEditCopy.Text = "&Copy"
        '
        'MenuStripEditPaste
        '
        Me.MenuStripEditPaste.Image = CType(resources.GetObject("MenuStripEditPaste.Image"), System.Drawing.Image)
        Me.MenuStripEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripEditPaste.Name = "MenuStripEditPaste"
        Me.MenuStripEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.MenuStripEditPaste.Size = New System.Drawing.Size(150, 22)
        Me.MenuStripEditPaste.Text = "&Paste"
        '
        'MenuStripEditSeparator2
        '
        Me.MenuStripEditSeparator2.Name = "MenuStripEditSeparator2"
        Me.MenuStripEditSeparator2.Size = New System.Drawing.Size(147, 6)
        '
        'MenuStripEditSelectAll
        '
        Me.MenuStripEditSelectAll.Name = "MenuStripEditSelectAll"
        Me.MenuStripEditSelectAll.Size = New System.Drawing.Size(150, 22)
        Me.MenuStripEditSelectAll.Text = "Select &All"
        '
        'MenuStripView
        '
        Me.MenuStripView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripViewKeepOnTop, Me.MenuStripViewOpacityLbl, Me.MenuStripViewSeparator, Me.MenuStripViewSource})
        Me.MenuStripView.Name = "MenuStripView"
        Me.MenuStripView.Size = New System.Drawing.Size(46, 23)
        Me.MenuStripView.Text = "&View"
        '
        'MenuStripViewKeepOnTop
        '
        Me.MenuStripViewKeepOnTop.AutoToolTip = True
        Me.MenuStripViewKeepOnTop.CheckOnClick = True
        Me.MenuStripViewKeepOnTop.Name = "MenuStripViewKeepOnTop"
        Me.MenuStripViewKeepOnTop.Size = New System.Drawing.Size(189, 22)
        Me.MenuStripViewKeepOnTop.Text = "Keep window on top"
        '
        'MenuStripViewOpacityLbl
        '
        Me.MenuStripViewOpacityLbl.AutoToolTip = True
        Me.MenuStripViewOpacityLbl.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripViewOpacityCbx})
        Me.MenuStripViewOpacityLbl.Name = "MenuStripViewOpacityLbl"
        Me.MenuStripViewOpacityLbl.Size = New System.Drawing.Size(189, 22)
        Me.MenuStripViewOpacityLbl.Text = "Set Opacity >>"
        '
        'MenuStripViewOpacityCbx
        '
        Me.MenuStripViewOpacityCbx.Items.AddRange(New Object() {"10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"})
        Me.MenuStripViewOpacityCbx.MaxDropDownItems = 20
        Me.MenuStripViewOpacityCbx.Name = "MenuStripViewOpacityCbx"
        Me.MenuStripViewOpacityCbx.Size = New System.Drawing.Size(121, 21)
        Me.MenuStripViewOpacityCbx.Text = "100%"
        '
        'MenuStripViewSeparator
        '
        Me.MenuStripViewSeparator.Name = "MenuStripViewSeparator"
        Me.MenuStripViewSeparator.Size = New System.Drawing.Size(186, 6)
        '
        'MenuStripViewSource
        '
        Me.MenuStripViewSource.Name = "MenuStripViewSource"
        Me.MenuStripViewSource.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.MenuStripViewSource.Size = New System.Drawing.Size(189, 22)
        Me.MenuStripViewSource.Text = "Source..."
        '
        'MenuStripTools
        '
        Me.MenuStripTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripToolsSetup, Me.MenuStripToolsProperties})
        Me.MenuStripTools.Name = "MenuStripTools"
        Me.MenuStripTools.Size = New System.Drawing.Size(49, 23)
        Me.MenuStripTools.Text = "&Tools"
        '
        'MenuStripToolsSetup
        '
        Me.MenuStripToolsSetup.Name = "MenuStripToolsSetup"
        Me.MenuStripToolsSetup.Size = New System.Drawing.Size(214, 22)
        Me.MenuStripToolsSetup.Text = "Page &Setup..."
        '
        'MenuStripToolsProperties
        '
        Me.MenuStripToolsProperties.Name = "MenuStripToolsProperties"
        Me.MenuStripToolsProperties.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.MenuStripToolsProperties.Size = New System.Drawing.Size(214, 22)
        Me.MenuStripToolsProperties.Text = "Page P&roperties..."
        '
        'MenuStripHelp
        '
        Me.MenuStripHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripHelpContents, Me.MenuStripHelpIndex, Me.MenuStripHelpSearch, Me.MenuStripHelpSeparator, Me.MenuStripHelpAbout})
        Me.MenuStripHelp.Name = "MenuStripHelp"
        Me.MenuStripHelp.Size = New System.Drawing.Size(44, 23)
        Me.MenuStripHelp.Text = "&Help"
        '
        'MenuStripHelpContents
        '
        Me.MenuStripHelpContents.Name = "MenuStripHelpContents"
        Me.MenuStripHelpContents.Size = New System.Drawing.Size(125, 22)
        Me.MenuStripHelpContents.Text = "&Contents"
        '
        'MenuStripHelpIndex
        '
        Me.MenuStripHelpIndex.Name = "MenuStripHelpIndex"
        Me.MenuStripHelpIndex.Size = New System.Drawing.Size(125, 22)
        Me.MenuStripHelpIndex.Text = "&Index"
        '
        'MenuStripHelpSearch
        '
        Me.MenuStripHelpSearch.Name = "MenuStripHelpSearch"
        Me.MenuStripHelpSearch.Size = New System.Drawing.Size(125, 22)
        Me.MenuStripHelpSearch.Text = "&Search"
        '
        'MenuStripHelpSeparator
        '
        Me.MenuStripHelpSeparator.Name = "MenuStripHelpSeparator"
        Me.MenuStripHelpSeparator.Size = New System.Drawing.Size(122, 6)
        '
        'MenuStripHelpAbout
        '
        Me.MenuStripHelpAbout.Name = "MenuStripHelpAbout"
        Me.MenuStripHelpAbout.Size = New System.Drawing.Size(125, 22)
        Me.MenuStripHelpAbout.Text = "&About..."
        '
        'ToolStripAdd
        '
        Me.ToolStripAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripAdd.Image = Global.BasicBrowser.My.Resources.Resources._16x16_bookmark_add
        Me.ToolStripAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripAdd.Name = "ToolStripAdd"
        Me.ToolStripAdd.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripAdd.Text = "Add Favourite"
        '
        'ToolStripRemove
        '
        Me.ToolStripRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripRemove.Image = Global.BasicBrowser.My.Resources.Resources._16x16_bookmark_remove
        Me.ToolStripRemove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripRemove.Name = "ToolStripRemove"
        Me.ToolStripRemove.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripRemove.Text = "Remove Favourite"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusStripProgressBar, Me.StatusStripStatusText})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 359)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(642, 22)
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
        Me.StatusStripStatusText.Size = New System.Drawing.Size(43, 17)
        Me.StatusStripStatusText.Text = "Status"
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
        'ToolStripNavigation
        '
        Me.ToolStripNavigation.AllowItemReorder = True
        Me.ToolStripNavigation.CanOverflow = False
        Me.ToolStripNavigation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBack, Me.ToolStripForward, Me.ToolStripReload, Me.ToolStripStop, Me.ToolStripHome, Me.ToolStripSeparator1, Me.ToolStripNewTab, Me.ToolStripCloseTab, Me.ToolStripSeparator2, Me.ToolStripURL, Me.ToolStripGo})
        Me.ToolStripNavigation.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStripNavigation.Location = New System.Drawing.Point(0, 27)
        Me.ToolStripNavigation.Name = "ToolStripNavigation"
        Me.ToolStripNavigation.Size = New System.Drawing.Size(642, 25)
        Me.ToolStripNavigation.Stretch = True
        Me.ToolStripNavigation.TabIndex = 4
        Me.ToolStripNavigation.Text = "ToolStripNavigation"
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
        'ToolStripURL
        '
        Me.ToolStripURL.Name = "ToolStripURL"
        Me.ToolStripURL.Size = New System.Drawing.Size(415, 25)
        Me.ToolStripURL.ToolTipText = "Enter URL to navigate to"
        '
        'ToolStripGo
        '
        Me.ToolStripGo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripGo.Image = Global.BasicBrowser.My.Resources.Resources.go_right_d
        Me.ToolStripGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripGo.Name = "ToolStripGo"
        Me.ToolStripGo.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripGo.Text = "Go >>"
        Me.ToolStripGo.ToolTipText = "Go >"
        '
        'BasicBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 381)
        Me.Controls.Add(Me.ToolStripNavigation)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "BasicBrowser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BasicBrowser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStripNavigation.ResumeLayout(False)
        Me.ToolStripNavigation.PerformLayout()
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
    Friend WithEvents MenuStripToolsSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripToolsProperties As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents ToolStripNavigation As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripNewTab As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCloseTab As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents StatusStripStatusText As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripGo As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStripViewKeepOnTop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripViewOpacityLbl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripViewOpacityCbx As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents MenuStripView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripViewSource As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripViewSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripRemove As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStripFileNewWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFileCloseWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripURL As System.Windows.Forms.ToolStripComboBox

End Class
