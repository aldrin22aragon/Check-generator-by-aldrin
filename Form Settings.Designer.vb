<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Settings
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.dgvTemplates = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbSample = New System.Windows.Forms.TextBox()
        Me.LblFont = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Degree = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ypos = New System.Windows.Forms.NumericUpDown()
        Me.XPos = New System.Windows.Forms.NumericUpDown()
        Me.PrintPreview = New System.Windows.Forms.PrintPreviewControl()
        Me.PrintChequeDocument = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.CbShow = New System.Windows.Forms.CheckBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        CType(Me.dgvTemplates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Degree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ypos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XPos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(28, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'dgvTemplates
        '
        Me.dgvTemplates.AllowUserToAddRows = False
        Me.dgvTemplates.AllowUserToDeleteRows = False
        Me.dgvTemplates.AllowUserToResizeColumns = False
        Me.dgvTemplates.AllowUserToResizeRows = False
        Me.dgvTemplates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTemplates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvTemplates.Location = New System.Drawing.Point(28, 62)
        Me.dgvTemplates.MultiSelect = False
        Me.dgvTemplates.Name = "dgvTemplates"
        Me.dgvTemplates.ReadOnly = True
        Me.dgvTemplates.RowHeadersVisible = False
        Me.dgvTemplates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTemplates.Size = New System.Drawing.Size(104, 294)
        Me.dgvTemplates.TabIndex = 19
        '
        'Column1
        '
        Me.Column1.HeaderText = "Template"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Sample"
        '
        'TbSample
        '
        Me.TbSample.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbSample.Location = New System.Drawing.Point(67, 31)
        Me.TbSample.Name = "TbSample"
        Me.TbSample.Size = New System.Drawing.Size(375, 22)
        Me.TbSample.TabIndex = 51
        '
        'LblFont
        '
        Me.LblFont.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFont.Location = New System.Drawing.Point(19, 61)
        Me.LblFont.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFont.Name = "LblFont"
        Me.LblFont.Size = New System.Drawing.Size(558, 37)
        Me.LblFont.TabIndex = 41
        Me.LblFont.Text = "Font"
        Me.LblFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.Location = New System.Drawing.Point(576, 60)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(37, 39)
        Me.Button8.TabIndex = 40
        Me.Button8.Text = ". . ."
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(631, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Degree"
        '
        'Degree
        '
        Me.Degree.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Degree.Location = New System.Drawing.Point(634, 32)
        Me.Degree.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.Degree.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.Degree.Name = "Degree"
        Me.Degree.Size = New System.Drawing.Size(50, 22)
        Me.Degree.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(564, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Y Position"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(504, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "X Position"
        '
        'Ypos
        '
        Me.Ypos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ypos.Location = New System.Drawing.Point(568, 32)
        Me.Ypos.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.Ypos.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.Ypos.Name = "Ypos"
        Me.Ypos.Size = New System.Drawing.Size(50, 22)
        Me.Ypos.TabIndex = 43
        '
        'XPos
        '
        Me.XPos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XPos.Location = New System.Drawing.Point(507, 32)
        Me.XPos.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.XPos.Minimum = New Decimal(New Integer() {1215752192, 23, 0, -2147483648})
        Me.XPos.Name = "XPos"
        Me.XPos.Size = New System.Drawing.Size(50, 22)
        Me.XPos.TabIndex = 42
        '
        'PrintPreview
        '
        Me.PrintPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintPreview.Location = New System.Drawing.Point(143, 127)
        Me.PrintPreview.Name = "PrintPreview"
        Me.PrintPreview.Size = New System.Drawing.Size(692, 229)
        Me.PrintPreview.TabIndex = 53
        '
        'PrintChequeDocument
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.CbShow)
        Me.GroupBox1.Controls.Add(Me.XPos)
        Me.GroupBox1.Controls.Add(Me.Ypos)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TbSample)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblFont)
        Me.GroupBox1.Controls.Add(Me.Degree)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(143, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 109)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Template Property"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.Color.Chartreuse
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(634, 68)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(50, 23)
        Me.BtnSave.TabIndex = 54
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'CbShow
        '
        Me.CbShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbShow.AutoSize = True
        Me.CbShow.Location = New System.Drawing.Point(448, 34)
        Me.CbShow.Name = "CbShow"
        Me.CbShow.Size = New System.Drawing.Size(53, 17)
        Me.CbShow.TabIndex = 53
        Me.CbShow.Text = "Show"
        Me.CbShow.UseVisualStyleBackColor = True
        '
        'Form_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 368)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PrintPreview)
        Me.Controls.Add(Me.dgvTemplates)
        Me.Controls.Add(Me.ComboBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form_Settings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvTemplates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Degree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ypos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XPos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents dgvTemplates As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents TbSample As TextBox
    Friend WithEvents LblFont As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Degree As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Ypos As NumericUpDown
    Friend WithEvents XPos As NumericUpDown
    Friend WithEvents PrintPreview As PrintPreviewControl
    Friend WithEvents PrintChequeDocument As Printing.PrintDocument
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbShow As CheckBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents FontDialog1 As FontDialog
End Class
