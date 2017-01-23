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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuStripFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileCloseTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileNewWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileCloseWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileOpenLink = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFilePrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripView = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripViewKeepOnTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripViewOpacityLbl = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripViewOpacityCbx = New System.Windows.Forms.ToolStripComboBox()
        Me.MenuStripViewSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripViewSource = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripToolsSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripToolsProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripToolsSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripToolsInternetProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripToolsInternetProxy = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripToolsInternetAddons = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripToolsNetworkDiagnostics = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripToolsSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripToolsAutoReload = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpContents = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpIndex = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripRemove = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripAdd = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusStripProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStripStatusText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripNavigation = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBack = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripForward = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripUp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripReload = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripStop = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripNewTab = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripCloseTab = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripURL = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripGo = New System.Windows.Forms.ToolStripButton()
        Me.timerDelayedTab = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout
        Me.StatusStrip.SuspendLayout
        Me.ToolStripNavigation.SuspendLayout
        Me.SuspendLayout
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TabControl.Location = New System.Drawing.Point(0, 55)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(642, 301)
        Me.TabControl.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.AllowItemReorder = true
        Me.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripFile, Me.MenuStripView, Me.MenuStripTools, Me.MenuStripHelp, Me.ToolStripRemove, Me.ToolStripAdd})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(642, 27)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MenuStripFile
        '
        Me.MenuStripFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripFileNew, Me.MenuStripFileCloseTab, Me.MenuStripFileNewWindow, Me.MenuStripFileCloseWindow, Me.MenuStripFileSeparator1, Me.MenuStripFileOpen, Me.MenuStripFileOpenLink, Me.MenuStripFileSave, Me.MenuStripFileSeparator2, Me.MenuStripFilePrint, Me.MenuStripFilePrintPreview, Me.MenuStripFileSeparator3, Me.MenuStripFileExit})
        Me.MenuStripFile.Name = "MenuStripFile"
        Me.MenuStripFile.Size = New System.Drawing.Size(38, 23)
        Me.MenuStripFile.Text = "&File"
        '
        'MenuStripFileNew
        '
        Me.MenuStripFileNew.Image = Global.BasicBrowser.My.Resources.Resources.tab_new
        Me.MenuStripFileNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileNew.Name = "MenuStripFileNew"
        Me.MenuStripFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T),System.Windows.Forms.Keys)
        Me.MenuStripFileNew.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFileNew.Text = "&New Tab"
        '
        'MenuStripFileCloseTab
        '
        Me.MenuStripFileCloseTab.Enabled = false
        Me.MenuStripFileCloseTab.Image = Global.BasicBrowser.My.Resources.Resources.emblem_unreadable
        Me.MenuStripFileCloseTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileCloseTab.Name = "MenuStripFileCloseTab"
        Me.MenuStripFileCloseTab.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W),System.Windows.Forms.Keys)
        Me.MenuStripFileCloseTab.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFileCloseTab.Text = "&Close Tab"
        '
        'MenuStripFileNewWindow
        '
        Me.MenuStripFileNewWindow.Image = Global.BasicBrowser.My.Resources.Resources.window_new
        Me.MenuStripFileNewWindow.Name = "MenuStripFileNewWindow"
        Me.MenuStripFileNewWindow.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N),System.Windows.Forms.Keys)
        Me.MenuStripFileNewWindow.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFileNewWindow.Text = "New &Window"
        '
        'MenuStripFileCloseWindow
        '
        Me.MenuStripFileCloseWindow.Image = Global.BasicBrowser.My.Resources.Resources._exit
        Me.MenuStripFileCloseWindow.Name = "MenuStripFileCloseWindow"
        Me.MenuStripFileCloseWindow.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4),System.Windows.Forms.Keys)
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
        Me.MenuStripFileOpen.Image = Global.BasicBrowser.My.Resources.Resources.file_open
        Me.MenuStripFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileOpen.Name = "MenuStripFileOpen"
        Me.MenuStripFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O),System.Windows.Forms.Keys)
        Me.MenuStripFileOpen.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFileOpen.Text = "&Open as content"
        '
        'MenuStripFileOpenLink
        '
        Me.MenuStripFileOpenLink.Image = Global.BasicBrowser.My.Resources.Resources.external_link
        Me.MenuStripFileOpenLink.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileOpenLink.Name = "MenuStripFileOpenLink"
        Me.MenuStripFileOpenLink.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift)  _
                        Or System.Windows.Forms.Keys.O),System.Windows.Forms.Keys)
        Me.MenuStripFileOpenLink.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFileOpenLink.Text = "&Open as link"
        '
        'MenuStripFileSave
        '
        Me.MenuStripFileSave.Enabled = false
        Me.MenuStripFileSave.Image = Global.BasicBrowser.My.Resources.Resources.file_save
        Me.MenuStripFileSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileSave.Name = "MenuStripFileSave"
        Me.MenuStripFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S),System.Windows.Forms.Keys)
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
        Me.MenuStripFilePrint.Enabled = false
        Me.MenuStripFilePrint.Image = Global.BasicBrowser.My.Resources.Resources.file_print
        Me.MenuStripFilePrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFilePrint.Name = "MenuStripFilePrint"
        Me.MenuStripFilePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P),System.Windows.Forms.Keys)
        Me.MenuStripFilePrint.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFilePrint.Text = "&Print..."
        '
        'MenuStripFilePrintPreview
        '
        Me.MenuStripFilePrintPreview.Enabled = false
        Me.MenuStripFilePrintPreview.Image = Global.BasicBrowser.My.Resources.Resources.file_print_preview
        Me.MenuStripFilePrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFilePrintPreview.Name = "MenuStripFilePrintPreview"
        Me.MenuStripFilePrintPreview.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift)  _
                        Or System.Windows.Forms.Keys.P),System.Windows.Forms.Keys)
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
        Me.MenuStripFileExit.Image = Global.BasicBrowser.My.Resources.Resources.system_log_out
        Me.MenuStripFileExit.Name = "MenuStripFileExit"
        Me.MenuStripFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q),System.Windows.Forms.Keys)
        Me.MenuStripFileExit.Size = New System.Drawing.Size(240, 22)
        Me.MenuStripFileExit.Text = "E&xit"
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
        Me.MenuStripViewKeepOnTop.AutoToolTip = true
        Me.MenuStripViewKeepOnTop.CheckOnClick = true
        Me.MenuStripViewKeepOnTop.Name = "MenuStripViewKeepOnTop"
        Me.MenuStripViewKeepOnTop.Size = New System.Drawing.Size(189, 22)
        Me.MenuStripViewKeepOnTop.Text = "Keep window on top"
        '
        'MenuStripViewOpacityLbl
        '
        Me.MenuStripViewOpacityLbl.AutoToolTip = true
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
        Me.MenuStripViewSource.Enabled = false
        Me.MenuStripViewSource.Image = Global.BasicBrowser.My.Resources.Resources.sourceCodeBitmap
        Me.MenuStripViewSource.Name = "MenuStripViewSource"
        Me.MenuStripViewSource.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U),System.Windows.Forms.Keys)
        Me.MenuStripViewSource.Size = New System.Drawing.Size(189, 22)
        Me.MenuStripViewSource.Text = "Source..."
        '
        'MenuStripTools
        '
        Me.MenuStripTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripToolsSetup, Me.MenuStripToolsProperties, Me.MenuStripToolsSeparator, Me.MenuStripToolsInternetProperties, Me.MenuStripToolsNetworkDiagnostics, Me.MenuStripToolsSeparator2, Me.MenuStripToolsAutoReload})
        Me.MenuStripTools.Name = "MenuStripTools"
        Me.MenuStripTools.Size = New System.Drawing.Size(49, 23)
        Me.MenuStripTools.Text = "&Tools"
        '
        'MenuStripToolsSetup
        '
        Me.MenuStripToolsSetup.AutoToolTip = true
        Me.MenuStripToolsSetup.Enabled = false
        Me.MenuStripToolsSetup.Image = Global.BasicBrowser.My.Resources.Resources.document_properties
        Me.MenuStripToolsSetup.Name = "MenuStripToolsSetup"
        Me.MenuStripToolsSetup.Size = New System.Drawing.Size(221, 22)
        Me.MenuStripToolsSetup.Text = "Page &Setup..."
        '
        'MenuStripToolsProperties
        '
        Me.MenuStripToolsProperties.AutoToolTip = true
        Me.MenuStripToolsProperties.Enabled = false
        Me.MenuStripToolsProperties.Image = Global.BasicBrowser.My.Resources.Resources.options2
        Me.MenuStripToolsProperties.Name = "MenuStripToolsProperties"
        Me.MenuStripToolsProperties.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P),System.Windows.Forms.Keys)
        Me.MenuStripToolsProperties.Size = New System.Drawing.Size(221, 22)
        Me.MenuStripToolsProperties.Text = "Page P&roperties..."
        '
        'MenuStripToolsSeparator
        '
        Me.MenuStripToolsSeparator.Name = "MenuStripToolsSeparator"
        Me.MenuStripToolsSeparator.Size = New System.Drawing.Size(218, 6)
        '
        'MenuStripToolsInternetProperties
        '
        Me.MenuStripToolsInternetProperties.AutoToolTip = true
        Me.MenuStripToolsInternetProperties.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripToolsInternetProxy, Me.MenuStripToolsInternetAddons})
        Me.MenuStripToolsInternetProperties.Image = Global.BasicBrowser.My.Resources.Resources.cpl_internet_properties
        Me.MenuStripToolsInternetProperties.Name = "MenuStripToolsInternetProperties"
        Me.MenuStripToolsInternetProperties.Size = New System.Drawing.Size(221, 22)
        Me.MenuStripToolsInternetProperties.Text = "Internet Properties..."
        '
        'MenuStripToolsInternetProxy
        '
        Me.MenuStripToolsInternetProxy.AutoToolTip = true
        Me.MenuStripToolsInternetProxy.Image = Global.BasicBrowser.My.Resources.Resources.cpl_connections
        Me.MenuStripToolsInternetProxy.Name = "MenuStripToolsInternetProxy"
        Me.MenuStripToolsInternetProxy.Size = New System.Drawing.Size(360, 22)
        Me.MenuStripToolsInternetProxy.Text = "Proxy settings... (Click LAN settings button)"
        '
        'MenuStripToolsInternetAddons
        '
        Me.MenuStripToolsInternetAddons.AutoToolTip = true
        Me.MenuStripToolsInternetAddons.Image = Global.BasicBrowser.My.Resources.Resources.cpl_manage_addons
        Me.MenuStripToolsInternetAddons.Name = "MenuStripToolsInternetAddons"
        Me.MenuStripToolsInternetAddons.Size = New System.Drawing.Size(360, 22)
        Me.MenuStripToolsInternetAddons.Text = "Manage add-ons... (Click Manage add-ons button)"
        '
        'MenuStripToolsNetworkDiagnostics
        '
        Me.MenuStripToolsNetworkDiagnostics.AutoToolTip = true
        Me.MenuStripToolsNetworkDiagnostics.Image = Global.BasicBrowser.My.Resources.Resources.cpl_network_diagnostics
        Me.MenuStripToolsNetworkDiagnostics.Name = "MenuStripToolsNetworkDiagnostics"
        Me.MenuStripToolsNetworkDiagnostics.Size = New System.Drawing.Size(221, 22)
        Me.MenuStripToolsNetworkDiagnostics.Text = "Network Diagnostics..."
        '
        'MenuStripToolsSeparator2
        '
        Me.MenuStripToolsSeparator2.Name = "MenuStripToolsSeparator2"
        Me.MenuStripToolsSeparator2.Size = New System.Drawing.Size(218, 6)
        '
        'MenuStripToolsAutoReload
        '
        Me.MenuStripToolsAutoReload.Checked = true
        Me.MenuStripToolsAutoReload.CheckOnClick = true
        Me.MenuStripToolsAutoReload.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuStripToolsAutoReload.Name = "MenuStripToolsAutoReload"
        Me.MenuStripToolsAutoReload.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift)  _
                        Or System.Windows.Forms.Keys.R),System.Windows.Forms.Keys)
        Me.MenuStripToolsAutoReload.Size = New System.Drawing.Size(221, 22)
        Me.MenuStripToolsAutoReload.Text = "Auto-reload"
        Me.MenuStripToolsAutoReload.ToolTipText = "Auto-reload pages that failed to load properly. Right-click to edit what's requir"& _ 
        "ed to start a reload."
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
        Me.MenuStripHelpContents.Visible = false
        '
        'MenuStripHelpIndex
        '
        Me.MenuStripHelpIndex.Name = "MenuStripHelpIndex"
        Me.MenuStripHelpIndex.Size = New System.Drawing.Size(125, 22)
        Me.MenuStripHelpIndex.Text = "&Index"
        Me.MenuStripHelpIndex.Visible = false
        '
        'MenuStripHelpSearch
        '
        Me.MenuStripHelpSearch.Name = "MenuStripHelpSearch"
        Me.MenuStripHelpSearch.Size = New System.Drawing.Size(125, 22)
        Me.MenuStripHelpSearch.Text = "&Search"
        Me.MenuStripHelpSearch.Visible = false
        '
        'MenuStripHelpSeparator
        '
        Me.MenuStripHelpSeparator.Name = "MenuStripHelpSeparator"
        Me.MenuStripHelpSeparator.Size = New System.Drawing.Size(122, 6)
        Me.MenuStripHelpSeparator.Visible = false
        '
        'MenuStripHelpAbout
        '
        Me.MenuStripHelpAbout.Image = Global.BasicBrowser.My.Resources.Resources.info1
        Me.MenuStripHelpAbout.Name = "MenuStripHelpAbout"
        Me.MenuStripHelpAbout.Size = New System.Drawing.Size(125, 22)
        Me.MenuStripHelpAbout.Text = "&About..."
        '
        'ToolStripRemove
        '
        Me.ToolStripRemove.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripRemove.Enabled = false
        Me.ToolStripRemove.Image = Global.BasicBrowser.My.Resources.Resources._16x16_bookmark_remove
        Me.ToolStripRemove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripRemove.Name = "ToolStripRemove"
        Me.ToolStripRemove.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripRemove.Text = "Remove Favourite"
        '
        'ToolStripAdd
        '
        Me.ToolStripAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripAdd.Enabled = false
        Me.ToolStripAdd.Image = Global.BasicBrowser.My.Resources.Resources._16x16_bookmark_add
        Me.ToolStripAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripAdd.Name = "ToolStripAdd"
        Me.ToolStripAdd.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripAdd.Text = "Add Favourite"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusStripProgressBar, Me.StatusStripStatusText})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 359)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(642, 22)
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip"
        '
        'StatusStripProgressBar
        '
        Me.StatusStripProgressBar.Name = "StatusStripProgressBar"
        Me.StatusStripProgressBar.Size = New System.Drawing.Size(100, 16)
        '
        'StatusStripStatusText
        '
        Me.StatusStripStatusText.Name = "StatusStripStatusText"
        Me.StatusStripStatusText.Size = New System.Drawing.Size(63, 17)
        Me.StatusStripStatusText.Text = "Loading..."
        Me.StatusStripStatusText.ToolTipText = "Status"
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
        Me.ToolStripNavigation.AllowItemReorder = true
        Me.ToolStripNavigation.CanOverflow = false
        Me.ToolStripNavigation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBack, Me.ToolStripForward, Me.ToolStripUp, Me.ToolStripReload, Me.ToolStripStop, Me.ToolStripHome, Me.ToolStripSeparator1, Me.ToolStripNewTab, Me.ToolStripCloseTab, Me.ToolStripSeparator2, Me.ToolStripURL, Me.ToolStripGo})
        Me.ToolStripNavigation.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStripNavigation.Location = New System.Drawing.Point(0, 27)
        Me.ToolStripNavigation.Name = "ToolStripNavigation"
        Me.ToolStripNavigation.Size = New System.Drawing.Size(642, 25)
        Me.ToolStripNavigation.Stretch = true
        Me.ToolStripNavigation.TabIndex = 4
        Me.ToolStripNavigation.Text = "ToolStripNavigation"
        '
        'ToolStripBack
        '
        Me.ToolStripBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBack.Enabled = false
        Me.ToolStripBack.Image = Global.BasicBrowser.My.Resources.Resources.go_previous
        Me.ToolStripBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBack.Name = "ToolStripBack"
        Me.ToolStripBack.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripBack.Text = "&Back"
        '
        'ToolStripForward
        '
        Me.ToolStripForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripForward.Enabled = false
        Me.ToolStripForward.Image = Global.BasicBrowser.My.Resources.Resources.go_next
        Me.ToolStripForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripForward.Name = "ToolStripForward"
        Me.ToolStripForward.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripForward.Text = "&Forward"
        '
        'ToolStripUp
        '
        Me.ToolStripUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripUp.Enabled = false
        Me.ToolStripUp.Image = Global.BasicBrowser.My.Resources.Resources._16x16_up
        Me.ToolStripUp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripUp.Name = "ToolStripUp"
        Me.ToolStripUp.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripUp.Text = "&Up"
        '
        'ToolStripReload
        '
        Me.ToolStripReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripReload.Enabled = false
        Me.ToolStripReload.Image = Global.BasicBrowser.My.Resources.Resources.view_refresh
        Me.ToolStripReload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripReload.Name = "ToolStripReload"
        Me.ToolStripReload.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripReload.Text = "&Reload"
        '
        'ToolStripStop
        '
        Me.ToolStripStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripStop.Enabled = false
        Me.ToolStripStop.Image = Global.BasicBrowser.My.Resources.Resources.process_stop
        Me.ToolStripStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripStop.Name = "ToolStripStop"
        Me.ToolStripStop.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripStop.Text = "&Stop"
        '
        'ToolStripHome
        '
        Me.ToolStripHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripHome.Image = Global.BasicBrowser.My.Resources.Resources.go_home
        Me.ToolStripHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripHome.Name = "ToolStripHome"
        Me.ToolStripHome.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripHome.Text = "&Home"
        '
        'ToolStripNewTab
        '
        Me.ToolStripNewTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripNewTab.Image = Global.BasicBrowser.My.Resources.Resources.tab_new
        Me.ToolStripNewTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripNewTab.Name = "ToolStripNewTab"
        Me.ToolStripNewTab.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripNewTab.Text = "New Tab"
        '
        'ToolStripCloseTab
        '
        Me.ToolStripCloseTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripCloseTab.Enabled = false
        Me.ToolStripCloseTab.Image = Global.BasicBrowser.My.Resources.Resources.emblem_unreadable
        Me.ToolStripCloseTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCloseTab.Name = "ToolStripCloseTab"
        Me.ToolStripCloseTab.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripCloseTab.Text = "Close Tab"
        '
        'ToolStripURL
        '
        Me.ToolStripURL.Name = "ToolStripURL"
        Me.ToolStripURL.Size = New System.Drawing.Size(392, 25)
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
        'timerDelayedTab
        '
        Me.timerDelayedTab.Interval = 500
        '
        'BasicBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 381)
        Me.Controls.Add(Me.ToolStripNavigation)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip)
        Me.HelpButton = true
        Me.Icon = Global.BasicBrowser.My.Resources.Resources.internet2
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "BasicBrowser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BasicBrowser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(false)
        Me.MenuStrip.PerformLayout
        Me.StatusStrip.ResumeLayout(false)
        Me.StatusStrip.PerformLayout
        Me.ToolStripNavigation.ResumeLayout(false)
        Me.ToolStripNavigation.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Private WithEvents ToolStripUp As System.Windows.Forms.ToolStripButton
    Private WithEvents MenuStripFileOpenLink As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents timerDelayedTab As System.Windows.Forms.Timer
    Private WithEvents TabControl As System.Windows.Forms.TabControl
    Private MenuStrip As System.Windows.Forms.MenuStrip
    Private MenuStripFile As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuStripFileNew As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuStripFileCloseTab As System.Windows.Forms.ToolStripMenuItem
    Private MenuStripFileSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents MenuStripFileSave As System.Windows.Forms.ToolStripMenuItem
    Private MenuStripFileSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents MenuStripFilePrint As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuStripFilePrintPreview As System.Windows.Forms.ToolStripMenuItem
    Private MenuStripFileSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents MenuStripFileExit As System.Windows.Forms.ToolStripMenuItem
    Private MenuStripTools As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuStripToolsSetup As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuStripToolsProperties As System.Windows.Forms.ToolStripMenuItem
    Private MenuStripHelp As System.Windows.Forms.ToolStripMenuItem
    Private MenuStripHelpContents As System.Windows.Forms.ToolStripMenuItem
    Private MenuStripHelpIndex As System.Windows.Forms.ToolStripMenuItem
    Private MenuStripHelpSearch As System.Windows.Forms.ToolStripMenuItem
    Private MenuStripHelpSeparator As System.Windows.Forms.ToolStripSeparator
    Private WithEvents MenuStripHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Private StatusStrip As System.Windows.Forms.StatusStrip
    Private ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents ToolStripBack As System.Windows.Forms.ToolStripSplitButton
    Private WithEvents ToolStripForward As System.Windows.Forms.ToolStripSplitButton
    Private WithEvents ToolStripReload As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripStop As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripHome As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripNavigation As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripNewTab As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripCloseTab As System.Windows.Forms.ToolStripButton
    Private StatusStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Private StatusStripStatusText As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents ToolStripGo As System.Windows.Forms.ToolStripButton
    Private WithEvents MenuStripViewKeepOnTop As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuStripViewOpacityLbl As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuStripViewOpacityCbx As System.Windows.Forms.ToolStripComboBox
    Private MenuStripView As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuStripFileOpen As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuStripViewSource As System.Windows.Forms.ToolStripMenuItem
    Private MenuStripViewSeparator As System.Windows.Forms.ToolStripSeparator
    Private WithEvents ToolStripAdd As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripRemove As System.Windows.Forms.ToolStripButton
    Private WithEvents MenuStripFileNewWindow As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuStripFileCloseWindow As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripURL As System.Windows.Forms.ToolStripComboBox
    Private MenuStripToolsSeparator As System.Windows.Forms.ToolStripSeparator
    Private WithEvents MenuStripToolsInternetProperties As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuStripToolsInternetAddons As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuStripToolsNetworkDiagnostics As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuStripToolsInternetProxy As System.Windows.Forms.ToolStripMenuItem
    Private MenuStripToolsSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents MenuStripToolsAutoReload As System.Windows.Forms.ToolStripMenuItem

End Class
