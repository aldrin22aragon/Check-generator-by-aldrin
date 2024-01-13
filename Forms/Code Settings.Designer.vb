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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonFont = New System.Windows.Forms.Button()
        Me.Degree = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbShow = New System.Windows.Forms.CheckBox()
        Me.Ypos = New System.Windows.Forms.NumericUpDown()
        Me.XPos = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonAmount = New System.Windows.Forms.Button()
        Me.ButtonPayeeLine2 = New System.Windows.Forms.Button()
        Me.ButtonPayeeLine1 = New System.Windows.Forms.Button()
        Me.ButtonCrossLine = New System.Windows.Forms.Button()
        Me.ButtonDate = New System.Windows.Forms.Button()
        Me.LabelComponent = New System.Windows.Forms.Label()
        Me.ButtonAddCode = New System.Windows.Forms.Button()
        Me.ButtonSampleValues = New System.Windows.Forms.Button()
        Me.PrintPreview = New System.Windows.Forms.PrintPreviewControl()
        Me.PrintChequeDocument = New System.Drawing.Printing.PrintDocument()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Degree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ypos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XPos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(17, 25)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(218, 25)
        Me.ComboBox1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.LabelComponent)
        Me.GroupBox1.Controls.Add(Me.ButtonAddCode)
        Me.GroupBox1.Controls.Add(Me.ButtonSampleValues)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.PrintPreview)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1004, 528)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Code"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(17, 487)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 29)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "Location"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(145, 487)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Print"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox3.Controls.Add(Me.ButtonFont)
        Me.GroupBox3.Controls.Add(Me.Degree)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.CbShow)
        Me.GroupBox3.Controls.Add(Me.Ypos)
        Me.GroupBox3.Controls.Add(Me.XPos)
        Me.GroupBox3.Location = New System.Drawing.Point(461, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(531, 69)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Property"
        '
        'ButtonFont
        '
        Me.ButtonFont.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFont.Location = New System.Drawing.Point(90, 21)
        Me.ButtonFont.Name = "ButtonFont"
        Me.ButtonFont.Size = New System.Drawing.Size(45, 29)
        Me.ButtonFont.TabIndex = 6
        Me.ButtonFont.Text = "Font"
        Me.ButtonFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonFont.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonFont.UseVisualStyleBackColor = True
        '
        'Degree
        '
        Me.Degree.Location = New System.Drawing.Point(439, 24)
        Me.Degree.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.Degree.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.Degree.Name = "Degree"
        Me.Degree.Size = New System.Drawing.Size(50, 25)
        Me.Degree.TabIndex = 58
        Me.Degree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Y Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(386, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Degree"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "X Position"
        '
        'CbShow
        '
        Me.CbShow.AutoSize = True
        Me.CbShow.Location = New System.Drawing.Point(21, 25)
        Me.CbShow.Name = "CbShow"
        Me.CbShow.Size = New System.Drawing.Size(63, 23)
        Me.CbShow.TabIndex = 60
        Me.CbShow.Text = "Show"
        Me.CbShow.UseVisualStyleBackColor = True
        '
        'Ypos
        '
        Me.Ypos.Location = New System.Drawing.Point(336, 24)
        Me.Ypos.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.Ypos.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.Ypos.Name = "Ypos"
        Me.Ypos.Size = New System.Drawing.Size(50, 25)
        Me.Ypos.TabIndex = 55
        Me.Ypos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'XPos
        '
        Me.XPos.Location = New System.Drawing.Point(214, 24)
        Me.XPos.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.XPos.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.XPos.Name = "XPos"
        Me.XPos.Size = New System.Drawing.Size(50, 25)
        Me.XPos.TabIndex = 54
        Me.XPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox2.Controls.Add(Me.ButtonSave)
        Me.GroupBox2.Controls.Add(Me.ButtonAmount)
        Me.GroupBox2.Controls.Add(Me.ButtonPayeeLine2)
        Me.GroupBox2.Controls.Add(Me.ButtonPayeeLine1)
        Me.GroupBox2.Controls.Add(Me.ButtonCrossLine)
        Me.GroupBox2.Controls.Add(Me.ButtonDate)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 326)
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
        Me.ButtonSave.Text = "Saved"
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
        'LabelComponent
        '
        Me.LabelComponent.BackColor = System.Drawing.SystemColors.MenuText
        Me.LabelComponent.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.LabelComponent.Location = New System.Drawing.Point(255, 17)
        Me.LabelComponent.Name = "LabelComponent"
        Me.LabelComponent.Padding = New System.Windows.Forms.Padding(4)
        Me.LabelComponent.Size = New System.Drawing.Size(210, 69)
        Me.LabelComponent.TabIndex = 61
        Me.LabelComponent.Text = "Component Name"
        Me.LabelComponent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonAddCode
        '
        Me.ButtonAddCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAddCode.Location = New System.Drawing.Point(181, 57)
        Me.ButtonAddCode.Name = "ButtonAddCode"
        Me.ButtonAddCode.Size = New System.Drawing.Size(54, 29)
        Me.ButtonAddCode.TabIndex = 6
        Me.ButtonAddCode.Text = "Add"
        Me.ButtonAddCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAddCode.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonAddCode.UseVisualStyleBackColor = True
        '
        'ButtonSampleValues
        '
        Me.ButtonSampleValues.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSampleValues.Location = New System.Drawing.Point(17, 57)
        Me.ButtonSampleValues.Name = "ButtonSampleValues"
        Me.ButtonSampleValues.Size = New System.Drawing.Size(158, 29)
        Me.ButtonSampleValues.TabIndex = 5
        Me.ButtonSampleValues.Text = "Edit Code"
        Me.ButtonSampleValues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSampleValues.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonSampleValues.UseVisualStyleBackColor = True
        '
        'PrintPreview
        '
        Me.PrintPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintPreview.Location = New System.Drawing.Point(255, 92)
        Me.PrintPreview.Name = "PrintPreview"
        Me.PrintPreview.Size = New System.Drawing.Size(737, 424)
        Me.PrintPreview.TabIndex = 4
        '
        'PrintChequeDocument
        '
        '
        'Code_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 528)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Code_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Code_Settings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Degree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ypos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XPos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonCrossLine As Button
    Friend WithEvents ButtonDate As Button
    Friend WithEvents ButtonPayeeLine2 As Button
    Friend WithEvents ButtonPayeeLine1 As Button
    Friend WithEvents ButtonSampleValues As Button
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
    Friend WithEvents LabelComponent As Label
    Friend WithEvents ButtonAddCode As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
