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
        Me.ToolStripBrowserActions = New System.Windows.Forms.ToolStrip()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
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
        'ToolStripBrowserActions
        '
        Me.ToolStripBrowserActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripBrowserActions.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripBrowserActions.Name = "ToolStripBrowserActions"
        Me.ToolStripBrowserActions.Size = New System.Drawing.Size(435, 25)
        Me.ToolStripBrowserActions.TabIndex = 4
        Me.ToolStripBrowserActions.Text = "ToolStrip1"
        '
        'BasicBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 381)
        Me.Controls.Add(Me.ToolStripBrowserActions)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "BasicBrowser"
        Me.Text = "BasicBrowser"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
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
    Friend WithEvents ToolStripBrowserActions As System.Windows.Forms.ToolStrip

End Class
