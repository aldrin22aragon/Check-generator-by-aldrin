<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PrintPreview = New System.Windows.Forms.PrintPreviewControl()
        Me.dgvCodes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CbTyp = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbSample = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.LblFont = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Degree = New System.Windows.Forms.NumericUpDown()
        Me.UpdatePreview = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ypos = New System.Windows.Forms.NumericUpDown()
        Me.XPos = New System.Windows.Forms.NumericUpDown()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.dgvTemplates = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.printCheque = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        CType(Me.dgvCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Degree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ypos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTemplates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintPreview
        '
        Me.PrintPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintPreview.Location = New System.Drawing.Point(390, 40)
        Me.PrintPreview.Name = "PrintPreview"
        Me.PrintPreview.Size = New System.Drawing.Size(408, 566)
        Me.PrintPreview.TabIndex = 0
        '
        'dgvCodes
        '
        Me.dgvCodes.AllowUserToAddRows = False
        Me.dgvCodes.AllowUserToDeleteRows = False
        Me.dgvCodes.AllowUserToResizeColumns = False
        Me.dgvCodes.AllowUserToResizeRows = False
        Me.dgvCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCodes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvCodes.Location = New System.Drawing.Point(20, 15)
        Me.dgvCodes.MultiSelect = False
        Me.dgvCodes.Name = "dgvCodes"
        Me.dgvCodes.ReadOnly = True
        Me.dgvCodes.RowHeadersVisible = False
        Me.dgvCodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCodes.Size = New System.Drawing.Size(156, 69)
        Me.dgvCodes.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(20, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(101, 90)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvCodes)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 162)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Codes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.CbTyp)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TbSample)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TbName)
        Me.GroupBox2.Controls.Add(Me.LblFont)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Degree)
        Me.GroupBox2.Controls.Add(Me.UpdatePreview)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Ypos)
        Me.GroupBox2.Controls.Add(Me.XPos)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.dgvTemplates)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 426)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Code template"
        '
        'CbTyp
        '
        Me.CbTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTyp.FormattingEnabled = True
        Me.CbTyp.Location = New System.Drawing.Point(58, 51)
        Me.CbTyp.Name = "CbTyp"
        Me.CbTyp.Size = New System.Drawing.Size(139, 21)
        Me.CbTyp.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Sample"
        '
        'TbSample
        '
        Me.TbSample.Location = New System.Drawing.Point(58, 77)
        Me.TbSample.Name = "TbSample"
        Me.TbSample.Size = New System.Drawing.Size(139, 20)
        Me.TbSample.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Name"
        '
        'TbName
        '
        Me.TbName.Location = New System.Drawing.Point(58, 25)
        Me.TbName.Name = "TbName"
        Me.TbName.Size = New System.Drawing.Size(139, 20)
        Me.TbName.TabIndex = 33
        '
        'LblFont
        '
        Me.LblFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFont.Location = New System.Drawing.Point(17, 148)
        Me.LblFont.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFont.Name = "LblFont"
        Me.LblFont.Size = New System.Drawing.Size(246, 37)
        Me.LblFont.TabIndex = 25
        Me.LblFont.Text = "Font"
        Me.LblFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(20, 188)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(111, 23)
        Me.Button8.TabIndex = 22
        Me.Button8.Text = "Change Font"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Degree"
        '
        'Degree
        '
        Me.Degree.Location = New System.Drawing.Point(147, 125)
        Me.Degree.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.Degree.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.Degree.Name = "Degree"
        Me.Degree.Size = New System.Drawing.Size(50, 20)
        Me.Degree.TabIndex = 31
        '
        'UpdatePreview
        '
        Me.UpdatePreview.Location = New System.Drawing.Point(161, 188)
        Me.UpdatePreview.Name = "UpdatePreview"
        Me.UpdatePreview.Size = New System.Drawing.Size(102, 23)
        Me.UpdatePreview.TabIndex = 30
        Me.UpdatePreview.Text = "Update Preview"
        Me.UpdatePreview.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Y Position"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "X Position"
        '
        'Ypos
        '
        Me.Ypos.Location = New System.Drawing.Point(81, 125)
        Me.Ypos.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.Ypos.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.Ypos.Name = "Ypos"
        Me.Ypos.Size = New System.Drawing.Size(50, 20)
        Me.Ypos.TabIndex = 27
        '
        'XPos
        '
        Me.XPos.Location = New System.Drawing.Point(20, 125)
        Me.XPos.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.XPos.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.XPos.Name = "XPos"
        Me.XPos.Size = New System.Drawing.Size(50, 20)
        Me.XPos.TabIndex = 26
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(188, 390)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(11, 390)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Add"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(102, 390)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'dgvTemplates
        '
        Me.dgvTemplates.AllowUserToAddRows = False
        Me.dgvTemplates.AllowUserToDeleteRows = False
        Me.dgvTemplates.AllowUserToResizeColumns = False
        Me.dgvTemplates.AllowUserToResizeRows = False
        Me.dgvTemplates.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTemplates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column2})
        Me.dgvTemplates.Location = New System.Drawing.Point(11, 217)
        Me.dgvTemplates.MultiSelect = False
        Me.dgvTemplates.Name = "dgvTemplates"
        Me.dgvTemplates.ReadOnly = True
        Me.dgvTemplates.RowHeadersVisible = False
        Me.dgvTemplates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTemplates.Size = New System.Drawing.Size(255, 167)
        Me.dgvTemplates.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Template Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Sample Value"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(387, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Preview"
        '
        'printCheque
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 618)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PrintPreview)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvCodes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Degree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ypos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTemplates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintPreview As PrintPreviewControl
    Friend WithEvents dgvCodes As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents dgvTemplates As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Ypos As NumericUpDown
    Friend WithEvents XPos As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents printCheque As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents UpdatePreview As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Degree As NumericUpDown
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents LblFont As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TbName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbSample As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CbTyp As ComboBox
End Class
