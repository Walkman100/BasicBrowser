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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuStripFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStripFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripOpen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripCut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripCopy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripPaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripHelp = New System.Windows.Forms.ToolStripButton()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Location = New System.Drawing.Point(0, 52)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(435, 304)
        Me.TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(427, 278)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(421, 272)
        Me.WebBrowser1.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripFile, Me.MenuStripEdit, Me.MenuStripTools, Me.MenuStripHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(435, 24)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MenuStripFile
        '
        Me.MenuStripFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripFileNew, Me.MenuStripFileOpen, Me.MenuStripFileSeparator1, Me.MenuStripFileSave, Me.MenuStripFileSaveAs, Me.MenuStripFileSeparator2, Me.MenuStripFilePrint, Me.MenuStripFilePrintPreview, Me.MenuStripFileSeparator3, Me.MenuStripFileExit})
        Me.MenuStripFile.Name = "MenuStripFile"
        Me.MenuStripFile.Size = New System.Drawing.Size(38, 20)
        Me.MenuStripFile.Text = "&File"
        '
        'MenuStripFileNew
        '
        Me.MenuStripFileNew.Image = CType(resources.GetObject("MenuStripFileNew.Image"), System.Drawing.Image)
        Me.MenuStripFileNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileNew.Name = "MenuStripFileNew"
        Me.MenuStripFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.MenuStripFileNew.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripFileNew.Text = "&New"
        '
        'MenuStripFileOpen
        '
        Me.MenuStripFileOpen.Image = CType(resources.GetObject("MenuStripFileOpen.Image"), System.Drawing.Image)
        Me.MenuStripFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileOpen.Name = "MenuStripFileOpen"
        Me.MenuStripFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.MenuStripFileOpen.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripFileOpen.Text = "&Open"
        '
        'MenuStripFileSeparator1
        '
        Me.MenuStripFileSeparator1.Name = "MenuStripFileSeparator1"
        Me.MenuStripFileSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'MenuStripFileSave
        '
        Me.MenuStripFileSave.Image = CType(resources.GetObject("MenuStripFileSave.Image"), System.Drawing.Image)
        Me.MenuStripFileSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFileSave.Name = "MenuStripFileSave"
        Me.MenuStripFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.MenuStripFileSave.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripFileSave.Text = "&Save"
        '
        'MenuStripFileSaveAs
        '
        Me.MenuStripFileSaveAs.Name = "MenuStripFileSaveAs"
        Me.MenuStripFileSaveAs.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripFileSaveAs.Text = "Save &As"
        '
        'MenuStripFileSeparator2
        '
        Me.MenuStripFileSeparator2.Name = "MenuStripFileSeparator2"
        Me.MenuStripFileSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'MenuStripFilePrint
        '
        Me.MenuStripFilePrint.Image = CType(resources.GetObject("MenuStripFilePrint.Image"), System.Drawing.Image)
        Me.MenuStripFilePrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFilePrint.Name = "MenuStripFilePrint"
        Me.MenuStripFilePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.MenuStripFilePrint.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripFilePrint.Text = "&Print"
        '
        'MenuStripFilePrintPreview
        '
        Me.MenuStripFilePrintPreview.Image = CType(resources.GetObject("MenuStripFilePrintPreview.Image"), System.Drawing.Image)
        Me.MenuStripFilePrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MenuStripFilePrintPreview.Name = "MenuStripFilePrintPreview"
        Me.MenuStripFilePrintPreview.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripFilePrintPreview.Text = "Print Pre&view"
        '
        'MenuStripFileSeparator3
        '
        Me.MenuStripFileSeparator3.Name = "MenuStripFileSeparator3"
        Me.MenuStripFileSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'MenuStripFileExit
        '
        Me.MenuStripFileExit.Name = "MenuStripFileExit"
        Me.MenuStripFileExit.Size = New System.Drawing.Size(152, 22)
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
        Me.MenuStripToolsCustomize.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripToolsCustomize.Text = "&Customize"
        '
        'MenuStripToolsOptions
        '
        Me.MenuStripToolsOptions.Name = "MenuStripToolsOptions"
        Me.MenuStripToolsOptions.Size = New System.Drawing.Size(152, 22)
        Me.MenuStripToolsOptions.Text = "&Options"
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
        Me.StatusStrip.Location = New System.Drawing.Point(0, 359)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(435, 22)
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStrip
        '
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripNew, Me.ToolStripOpen, Me.ToolStripSave, Me.ToolStripPrint, Me.ToolStripSeparator1, Me.ToolStripCut, Me.ToolStripCopy, Me.ToolStripPaste, Me.ToolStripSeparator2, Me.ToolStripHelp})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(435, 25)
        Me.ToolStrip.TabIndex = 4
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripNew
        '
        Me.ToolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripNew.Image = CType(resources.GetObject("ToolStripNew.Image"), System.Drawing.Image)
        Me.ToolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripNew.Name = "ToolStripNew"
        Me.ToolStripNew.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripNew.Text = "&New"
        '
        'ToolStripOpen
        '
        Me.ToolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripOpen.Image = CType(resources.GetObject("ToolStripOpen.Image"), System.Drawing.Image)
        Me.ToolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripOpen.Name = "ToolStripOpen"
        Me.ToolStripOpen.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripOpen.Text = "&Open"
        '
        'ToolStripSave
        '
        Me.ToolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSave.Image = CType(resources.GetObject("ToolStripSave.Image"), System.Drawing.Image)
        Me.ToolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSave.Name = "ToolStripSave"
        Me.ToolStripSave.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripSave.Text = "&Save"
        '
        'ToolStripPrint
        '
        Me.ToolStripPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripPrint.Image = CType(resources.GetObject("ToolStripPrint.Image"), System.Drawing.Image)
        Me.ToolStripPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripPrint.Name = "ToolStripPrint"
        Me.ToolStripPrint.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripPrint.Text = "&Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripCut
        '
        Me.ToolStripCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripCut.Image = CType(resources.GetObject("ToolStripCut.Image"), System.Drawing.Image)
        Me.ToolStripCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCut.Name = "ToolStripCut"
        Me.ToolStripCut.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripCut.Text = "C&ut"
        '
        'ToolStripCopy
        '
        Me.ToolStripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripCopy.Image = CType(resources.GetObject("ToolStripCopy.Image"), System.Drawing.Image)
        Me.ToolStripCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCopy.Name = "ToolStripCopy"
        Me.ToolStripCopy.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripCopy.Text = "&Copy"
        '
        'ToolStripPaste
        '
        Me.ToolStripPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripPaste.Image = CType(resources.GetObject("ToolStripPaste.Image"), System.Drawing.Image)
        Me.ToolStripPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripPaste.Name = "ToolStripPaste"
        Me.ToolStripPaste.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripPaste.Text = "&Paste"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripHelp
        '
        Me.ToolStripHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripHelp.Image = CType(resources.GetObject("ToolStripHelp.Image"), System.Drawing.Image)
        Me.ToolStripHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripHelp.Name = "ToolStripHelp"
        Me.ToolStripHelp.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripHelp.Text = "He&lp"
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
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStripFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFileNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFileSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStripFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripFileSaveAs As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripHelp As System.Windows.Forms.ToolStripButton

End Class
