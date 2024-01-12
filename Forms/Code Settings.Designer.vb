<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Code_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Code_Settings))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonAddCode = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonAmount = New System.Windows.Forms.Button()
        Me.ButtonPayeeLine2 = New System.Windows.Forms.Button()
        Me.ButtonPayeeLine1 = New System.Windows.Forms.Button()
        Me.ButtonCrossLine = New System.Windows.Forms.Button()
        Me.ButtonDate = New System.Windows.Forms.Button()
        Me.PrintPreview = New System.Windows.Forms.PrintPreviewControl()
        Me.PrintChequeDocument = New System.Drawing.Printing.PrintDocument()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.CbShow = New System.Windows.Forms.CheckBox()
        Me.XPos = New System.Windows.Forms.NumericUpDown()
        Me.Ypos = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Degree = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonFont = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.XPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ypos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Degree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(17, 25)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(184, 25)
        Me.ComboBox1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonAddCode)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 98)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Code"
        '
        'ButtonAddCode
        '
        Me.ButtonAddCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAddCode.Location = New System.Drawing.Point(147, 57)
        Me.ButtonAddCode.Name = "ButtonAddCode"
        Me.ButtonAddCode.Size = New System.Drawing.Size(54, 29)
        Me.ButtonAddCode.TabIndex = 6
        Me.ButtonAddCode.Text = "Add"
        Me.ButtonAddCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAddCode.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonAddCode.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(17, 57)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(124, 29)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Edit Template"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonSave)
        Me.GroupBox2.Controls.Add(Me.ButtonAmount)
        Me.GroupBox2.Controls.Add(Me.ButtonPayeeLine2)
        Me.GroupBox2.Controls.Add(Me.ButtonPayeeLine1)
        Me.GroupBox2.Controls.Add(Me.ButtonCrossLine)
        Me.GroupBox2.Controls.Add(Me.ButtonDate)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 315)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Components"
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSave.Location = New System.Drawing.Point(17, 268)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(184, 29)
        Me.ButtonSave.TabIndex = 5
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonAmount
        '
        Me.ButtonAmount.Image = CType(resources.GetObject("ButtonAmount.Image"), System.Drawing.Image)
        Me.ButtonAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAmount.Location = New System.Drawing.Point(17, 210)
        Me.ButtonAmount.Name = "ButtonAmount"
        Me.ButtonAmount.Size = New System.Drawing.Size(184, 29)
        Me.ButtonAmount.TabIndex = 4
        Me.ButtonAmount.Text = "Amount"
        Me.ButtonAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAmount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonAmount.UseVisualStyleBackColor = True
        '
        'ButtonPayeeLine2
        '
        Me.ButtonPayeeLine2.Image = CType(resources.GetObject("ButtonPayeeLine2.Image"), System.Drawing.Image)
        Me.ButtonPayeeLine2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonPayeeLine2.Location = New System.Drawing.Point(17, 165)
        Me.ButtonPayeeLine2.Name = "ButtonPayeeLine2"
        Me.ButtonPayeeLine2.Size = New System.Drawing.Size(184, 29)
        Me.ButtonPayeeLine2.TabIndex = 3
        Me.ButtonPayeeLine2.Text = "Payee Line 2"
        Me.ButtonPayeeLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPayeeLine2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonPayeeLine2.UseVisualStyleBackColor = True
        '
        'ButtonPayeeLine1
        '
        Me.ButtonPayeeLine1.Image = CType(resources.GetObject("ButtonPayeeLine1.Image"), System.Drawing.Image)
        Me.ButtonPayeeLine1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonPayeeLine1.Location = New System.Drawing.Point(17, 120)
        Me.ButtonPayeeLine1.Name = "ButtonPayeeLine1"
        Me.ButtonPayeeLine1.Size = New System.Drawing.Size(184, 29)
        Me.ButtonPayeeLine1.TabIndex = 2
        Me.ButtonPayeeLine1.Text = "Payee Line 1"
        Me.ButtonPayeeLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPayeeLine1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonPayeeLine1.UseVisualStyleBackColor = True
        '
        'ButtonCrossLine
        '
        Me.ButtonCrossLine.Image = CType(resources.GetObject("ButtonCrossLine.Image"), System.Drawing.Image)
        Me.ButtonCrossLine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCrossLine.Location = New System.Drawing.Point(17, 75)
        Me.ButtonCrossLine.Name = "ButtonCrossLine"
        Me.ButtonCrossLine.Size = New System.Drawing.Size(184, 29)
        Me.ButtonCrossLine.TabIndex = 1
        Me.ButtonCrossLine.Text = "Cross Check"
        Me.ButtonCrossLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCrossLine.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonCrossLine.UseVisualStyleBackColor = True
        '
        'ButtonDate
        '
        Me.ButtonDate.Image = CType(resources.GetObject("ButtonDate.Image"), System.Drawing.Image)
        Me.ButtonDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDate.Location = New System.Drawing.Point(17, 30)
        Me.ButtonDate.Name = "ButtonDate"
        Me.ButtonDate.Size = New System.Drawing.Size(184, 29)
        Me.ButtonDate.TabIndex = 0
        Me.ButtonDate.Text = "Date"
        Me.ButtonDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonDate.UseVisualStyleBackColor = True
        '
        'PrintPreview
        '
        Me.PrintPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintPreview.Location = New System.Drawing.Point(248, 43)
        Me.PrintPreview.Name = "PrintPreview"
        Me.PrintPreview.Size = New System.Drawing.Size(638, 388)
        Me.PrintPreview.TabIndex = 4
        '
        'PrintChequeDocument
        '
        '
        'CbShow
        '
        Me.CbShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbShow.AutoSize = True
        Me.CbShow.Location = New System.Drawing.Point(418, 13)
        Me.CbShow.Name = "CbShow"
        Me.CbShow.Size = New System.Drawing.Size(63, 23)
        Me.CbShow.TabIndex = 60
        Me.CbShow.Text = "Show"
        Me.CbShow.UseVisualStyleBackColor = True
        '
        'XPos
        '
        Me.XPos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XPos.Location = New System.Drawing.Point(611, 12)
        Me.XPos.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.XPos.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.XPos.Name = "XPos"
        Me.XPos.Size = New System.Drawing.Size(50, 25)
        Me.XPos.TabIndex = 54
        Me.XPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ypos
        '
        Me.Ypos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ypos.Location = New System.Drawing.Point(733, 12)
        Me.Ypos.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.Ypos.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.Ypos.Name = "Ypos"
        Me.Ypos.Size = New System.Drawing.Size(50, 25)
        Me.Ypos.TabIndex = 55
        Me.Ypos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(538, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "X Position"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(661, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Y Position"
        '
        'Degree
        '
        Me.Degree.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Degree.Location = New System.Drawing.Point(836, 12)
        Me.Degree.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.Degree.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.Degree.Name = "Degree"
        Me.Degree.Size = New System.Drawing.Size(50, 25)
        Me.Degree.TabIndex = 58
        Me.Degree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(783, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Degree"
        '
        'ButtonFont
        '
        Me.ButtonFont.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFont.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFont.Location = New System.Drawing.Point(487, 9)
        Me.ButtonFont.Name = "ButtonFont"
        Me.ButtonFont.Size = New System.Drawing.Size(45, 29)
        Me.ButtonFont.TabIndex = 6
        Me.ButtonFont.Text = "Font"
        Me.ButtonFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonFont.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonFont.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.SystemColors.MenuText
        Me.Label3.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Location = New System.Drawing.Point(248, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(4)
        Me.Label3.Size = New System.Drawing.Size(164, 30)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Component Name"
        '
        'Code_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 443)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonFont)
        Me.Controls.Add(Me.CbShow)
        Me.Controls.Add(Me.XPos)
        Me.Controls.Add(Me.Ypos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Degree)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PrintPreview)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Code_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code_Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.XPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ypos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Degree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonCrossLine As Button
    Friend WithEvents ButtonDate As Button
    Friend WithEvents ButtonPayeeLine2 As Button
    Friend WithEvents ButtonPayeeLine1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ButtonAmount As Button
    Friend WithEvents PrintPreview As PrintPreviewControl
    Friend WithEvents ButtonSave As Button
    Friend WithEvents PrintChequeDocument As Printing.PrintDocument
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents CbShow As CheckBox
    Friend WithEvents XPos As NumericUpDown
    Friend WithEvents Ypos As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Degree As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonFont As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonAddCode As Button
End Class
