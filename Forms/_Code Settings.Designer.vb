<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _Code_Settings
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonAddCode = New System.Windows.Forms.Button()
        Me.ButtonSampleValues = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintPreview = New System.Windows.Forms.PrintPreviewControl()
        Me.LabelComponent = New System.Windows.Forms.Label()
        Me.ButtonFont = New System.Windows.Forms.Button()
        Me.Degree = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbShow = New System.Windows.Forms.CheckBox()
        Me.Ypos = New System.Windows.Forms.NumericUpDown()
        Me.XPos = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Degree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ypos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XPos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(185, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ButtonFont)
        Me.Panel1.Controls.Add(Me.Degree)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CbShow)
        Me.Panel1.Controls.Add(Me.Ypos)
        Me.Panel1.Controls.Add(Me.XPos)
        Me.Panel1.Controls.Add(Me.LabelComponent)
        Me.Panel1.Controls.Add(Me.PrintPreview)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 514)
        Me.Panel1.TabIndex = 1
        '
        'ButtonAddCode
        '
        Me.ButtonAddCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAddCode.Location = New System.Drawing.Point(376, 7)
        Me.ButtonAddCode.Name = "ButtonAddCode"
        Me.ButtonAddCode.Size = New System.Drawing.Size(54, 29)
        Me.ButtonAddCode.TabIndex = 8
        Me.ButtonAddCode.Text = "Add"
        Me.ButtonAddCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAddCode.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonAddCode.UseVisualStyleBackColor = True
        '
        'ButtonSampleValues
        '
        Me.ButtonSampleValues.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSampleValues.Location = New System.Drawing.Point(212, 7)
        Me.ButtonSampleValues.Name = "ButtonSampleValues"
        Me.ButtonSampleValues.Size = New System.Drawing.Size(158, 29)
        Me.ButtonSampleValues.TabIndex = 7
        Me.ButtonSampleValues.Text = "Edit Code"
        Me.ButtonSampleValues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSampleValues.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonSampleValues.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(240, 426)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Component"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'PrintPreview
        '
        Me.PrintPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintPreview.Location = New System.Drawing.Point(273, 71)
        Me.PrintPreview.Name = "PrintPreview"
        Me.PrintPreview.Size = New System.Drawing.Size(715, 369)
        Me.PrintPreview.TabIndex = 5
        '
        'LabelComponent
        '
        Me.LabelComponent.BackColor = System.Drawing.SystemColors.MenuText
        Me.LabelComponent.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.LabelComponent.Location = New System.Drawing.Point(270, 14)
        Me.LabelComponent.Name = "LabelComponent"
        Me.LabelComponent.Padding = New System.Windows.Forms.Padding(4)
        Me.LabelComponent.Size = New System.Drawing.Size(210, 40)
        Me.LabelComponent.TabIndex = 62
        Me.LabelComponent.Text = "Component Name"
        Me.LabelComponent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonFont
        '
        Me.ButtonFont.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFont.Location = New System.Drawing.Point(589, 25)
        Me.ButtonFont.Name = "ButtonFont"
        Me.ButtonFont.Size = New System.Drawing.Size(45, 29)
        Me.ButtonFont.TabIndex = 63
        Me.ButtonFont.Text = "Font"
        Me.ButtonFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonFont.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonFont.UseVisualStyleBackColor = True
        '
        'Degree
        '
        Me.Degree.Location = New System.Drawing.Point(938, 28)
        Me.Degree.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.Degree.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.Degree.Name = "Degree"
        Me.Degree.Size = New System.Drawing.Size(50, 20)
        Me.Degree.TabIndex = 68
        Me.Degree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(763, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Y Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(885, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Degree"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(640, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "X Position"
        '
        'CbShow
        '
        Me.CbShow.AutoSize = True
        Me.CbShow.Location = New System.Drawing.Point(520, 29)
        Me.CbShow.Name = "CbShow"
        Me.CbShow.Size = New System.Drawing.Size(53, 17)
        Me.CbShow.TabIndex = 70
        Me.CbShow.Text = "Show"
        Me.CbShow.UseVisualStyleBackColor = True
        '
        'Ypos
        '
        Me.Ypos.Location = New System.Drawing.Point(835, 28)
        Me.Ypos.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.Ypos.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.Ypos.Name = "Ypos"
        Me.Ypos.Size = New System.Drawing.Size(50, 20)
        Me.Ypos.TabIndex = 65
        Me.Ypos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'XPos
        '
        Me.XPos.Location = New System.Drawing.Point(713, 28)
        Me.XPos.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.XPos.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.XPos.Name = "XPos"
        Me.XPos.Size = New System.Drawing.Size(50, 20)
        Me.XPos.TabIndex = 64
        Me.XPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(14, 464)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 29)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "Location"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(142, 464)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 29)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Print"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(792, 464)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 29)
        Me.Button3.TabIndex = 73
        Me.Button3.Text = "Edit"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(895, 464)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 29)
        Me.Button4.TabIndex = 74
        Me.Button4.Text = "Save"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button4.UseVisualStyleBackColor = True
        '
        '_Code_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 574)
        Me.Controls.Add(Me.ButtonAddCode)
        Me.Controls.Add(Me.ButtonSampleValues)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "_Code_Settings"
        Me.Text = "_Code_Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Degree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ypos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XPos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonAddCode As Button
    Friend WithEvents ButtonSampleValues As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents PrintPreview As PrintPreviewControl
    Friend WithEvents LabelComponent As Label
    Friend WithEvents ButtonFont As Button
    Friend WithEvents Degree As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbShow As CheckBox
    Friend WithEvents Ypos As NumericUpDown
    Friend WithEvents XPos As NumericUpDown
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
