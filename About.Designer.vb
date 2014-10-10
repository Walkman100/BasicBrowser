<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.llblSourceCode = New System.Windows.Forms.LinkLabel()
        Me.llblDocumentation = New System.Windows.Forms.LinkLabel()
        Me.llblProjectsite = New System.Windows.Forms.LinkLabel()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblRelease = New System.Windows.Forms.Label()
        Me.pnlAbout = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.pnlFooter.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.White
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooter.Controls.Add(Me.llblSourceCode)
        Me.pnlFooter.Controls.Add(Me.llblDocumentation)
        Me.pnlFooter.Controls.Add(Me.llblProjectsite)
        Me.pnlFooter.Location = New System.Drawing.Point(-2, 314)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(665, 95)
        Me.pnlFooter.TabIndex = 0
        '
        'llblSourceCode
        '
        Me.llblSourceCode.AutoSize = True
        Me.llblSourceCode.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblSourceCode.Location = New System.Drawing.Point(543, 28)
        Me.llblSourceCode.Name = "llblSourceCode"
        Me.llblSourceCode.Size = New System.Drawing.Size(104, 22)
        Me.llblSourceCode.TabIndex = 2
        Me.llblSourceCode.TabStop = True
        Me.llblSourceCode.Text = "Source code"
        '
        'llblDocumentation
        '
        Me.llblDocumentation.AutoSize = True
        Me.llblDocumentation.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblDocumentation.Location = New System.Drawing.Point(260, 28)
        Me.llblDocumentation.Name = "llblDocumentation"
        Me.llblDocumentation.Size = New System.Drawing.Size(129, 22)
        Me.llblDocumentation.TabIndex = 1
        Me.llblDocumentation.TabStop = True
        Me.llblDocumentation.Text = "Documentation"
        '
        'llblProjectsite
        '
        Me.llblProjectsite.AutoSize = True
        Me.llblProjectsite.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblProjectsite.Location = New System.Drawing.Point(13, 28)
        Me.llblProjectsite.Name = "llblProjectsite"
        Me.llblProjectsite.Size = New System.Drawing.Size(95, 22)
        Me.llblProjectsite.TabIndex = 0
        Me.llblProjectsite.TabStop = True
        Me.llblProjectsite.Text = "Project site"
        '
        'imgLogo
        '
        Me.imgLogo.Location = New System.Drawing.Point(-123, -114)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(490, 620)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLogo.TabIndex = 1
        Me.imgLogo.TabStop = False
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Open Sans", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(235, 9)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(440, 87)
        Me.lblProductName.TabIndex = 2
        Me.lblProductName.Text = "BasicBrowser"
        '
        'lblVersion
        '
        Me.lblVersion.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(470, 84)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(176, 28)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRelease
        '
        Me.lblRelease.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRelease.Location = New System.Drawing.Point(342, 84)
        Me.lblRelease.Name = "lblRelease"
        Me.lblRelease.Size = New System.Drawing.Size(133, 28)
        Me.lblRelease.TabIndex = 4
        Me.lblRelease.Text = "release"
        Me.lblRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlAbout
        '
        Me.pnlAbout.BackColor = System.Drawing.Color.White
        Me.pnlAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAbout.Controls.Add(Me.RichTextBox1)
        Me.pnlAbout.Location = New System.Drawing.Point(342, 123)
        Me.pnlAbout.Name = "pnlAbout"
        Me.pnlAbout.Size = New System.Drawing.Size(279, 170)
        Me.pnlAbout.TabIndex = 5
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(277, 168)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 389)
        Me.Controls.Add(Me.pnlAbout)
        Me.Controls.Add(Me.lblRelease)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.imgLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About Tedori"
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAbout.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents llblSourceCode As System.Windows.Forms.LinkLabel
    Friend WithEvents llblDocumentation As System.Windows.Forms.LinkLabel
    Friend WithEvents llblProjectsite As System.Windows.Forms.LinkLabel
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblRelease As System.Windows.Forms.Label
    Friend WithEvents pnlAbout As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
