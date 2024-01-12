Public Class Form_Settings
   Event PropertyChange()
   Friend WithEvents PreviewPageTimer As AOA_Timer

   Private Sub Form_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      'Dim fl As String = IO.Path.Combine(CodesFolder, "Txt.drihnz")
      'Dim f As New FileSettingsCreator2(Of CodeTemplates)(fl, New CodeTemplates())
      'f.setSettings(New CodeTemplates())

      CreateNeededFolders()
      ComboBox1.Items.Clear()
      For Each file As String In GetCodeFiles()
         Dim fsc As New FileSettingsCreator2(Of CodeTemplates)(file, New CodeTemplates())
         ComboBox1.Items.Add(fsc)
      Next
      If ComboBox1.Items.Count > 0 Then ComboBox1.SelectedIndex = 0
   End Sub

   Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
      dgvTemplates.Rows.Clear()
      Dim fsc As FileSettingsCreator2(Of CodeTemplates) = ComboBox1.SelectedItem
      Dim code As CodeTemplates = fsc.GetSettings
      dgvTemplates.Rows(dgvTemplates.Rows.Add("Date")).Tag = code.Date
      dgvTemplates.Rows(dgvTemplates.Rows.Add("Cross Check")).Tag = code.CrossLine
      dgvTemplates.Rows(dgvTemplates.Rows.Add("Payee Line1")).Tag = code.PayeeLine1
      dgvTemplates.Rows(dgvTemplates.Rows.Add("Payee Line2")).Tag = code.PayeeLine2
      dgvTemplates.Rows(dgvTemplates.Rows.Add("Amount")).Tag = code.Amount
      dgvTemplates.CurrentCell = dgvTemplates.Item(0, 0)
      DgvTemplates_CurrentCellChanged(New Object, New EventArgs)
   End Sub

   Sub PreviewPage()
      PrintChequeDocument.DefaultPageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
      PrintChequeDocument.DefaultPageSettings.Landscape = True
      PrintPreview.Document = PrintChequeDocument ' this will trigger 'PrintChequeDocument.PrintPage' event
      PrintPreview.InvalidatePreview()
      PrintPreview.Zoom = 0.8
   End Sub

   Private Sub DgvTemplates_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvTemplates.CurrentCellChanged
      If dgvTemplates.CurrentCell IsNot Nothing Then
         Dim tp As Template = dgvTemplates.Rows(dgvTemplates.CurrentCell.RowIndex).Tag
         If tp IsNot Nothing Then
            FormTemplateProperty = tp
            PreviewPage()
         End If
      End If
   End Sub

   Property FormTemplateProperty As Template
      Get
         Dim tp As Template = GroupBox1.Tag
         Return New Template() With {
            .Font = LblFont.Font,
            .X = XPos.Value,
            .Y = Ypos.Value,
            .Type = tp.Type,
            .RotateDegree = Degree.Value,
            .SampleValue = TbSample.Text.Trim,
            .Show = CbShow.Checked
         }
      End Get
      Set(value As Template)
         GroupBox1.Tag = value
         LblFont.Text = value.Font.ToString
         '
         LblFont.Font = value.Font
         XPos.Value = value.X
         Ypos.Value = value.Y
         Degree.Value = value.RotateDegree
         TbSample.Text = value.SampleValue
         CbShow.Checked = value.Show
      End Set
   End Property

   Private Sub PrintChequeDocument_PrintPage(sender As Object, e1 As Printing.PrintPageEventArgs) Handles PrintChequeDocument.PrintPage
      Dim CurCellRowIndex As Integer = -1
      If dgvTemplates.CurrentCell IsNot Nothing Then CurCellRowIndex = dgvTemplates.CurrentCell.RowIndex
      For Each row As DataGridViewRow In dgvTemplates.Rows
         Dim BrushColor As Brush = IIf(row.Index = CurCellRowIndex, Brushes.Red, Brushes.Black)
         Dim PenColor As Pen = IIf(row.Index = CurCellRowIndex, Pens.Red, Pens.Black)
         Dim tp As Template = row.Tag
         Select Case tp.Type
            Case Template.ENUM_TYPE.CROSS_CHECK
               e1.Graphics.DrawLine(PenColor, 100, 570 - 280, 200, 520 - 280)
               e1.Graphics.DrawLine(PenColor, 115, 570 - 280, 215, 520 - 280)
            Case Template.ENUM_TYPE.DATE
               e1.Graphics.DrawString(tp.SampleValue, tp.Font, BrushColor, New Point(tp.X, tp.Y))
            Case Template.ENUM_TYPE.PAYEELINE1
               e1.Graphics.DrawString(tp.SampleValue, tp.Font, BrushColor, New Point(tp.X, tp.Y))
            Case Template.ENUM_TYPE.PAYEELINE2
               e1.Graphics.DrawString(tp.SampleValue, tp.Font, BrushColor, New Point(tp.X, tp.Y))
            Case Template.ENUM_TYPE.AMOUNT
               e1.Graphics.DrawString(tp.SampleValue, tp.Font, BrushColor, New Point(tp.X, tp.Y))
         End Select
      Next
   End Sub

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

   End Sub

   Private Sub XPos_ValueChanged(sender As Object, e As EventArgs) Handles Ypos.ValueChanged, XPos.ValueChanged, Degree.ValueChanged, CbShow.CheckedChanged, TbSample.TextChanged
      RaiseEvent PropertyChange()
   End Sub

   Private Sub Form_Settings_PropertyChange() Handles Me.PropertyChange
      BtnSave.Enabled = True
      PreviewPageTimer = New AOA_Timer(2) ' this will Trigger event 'PreviewPageTimer.Tick' after 2 seconds delay
   End Sub

   Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
      Dim d As DialogResult = DialogResult.Cancel
      Try
         d = FontDialog1.ShowDialog
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try
      If d = DialogResult.OK Then
         Dim f As Font = FontDialog1.Font
         Dim fontString As String = f.ToString
         LblFont.Text = fontString
         LblFont.Font = f
         RaiseEvent PropertyChange()
      End If
   End Sub

   Private Sub PreviewPageTimer_Tick() Handles PreviewPageTimer.Tick
      If ComboBox1.SelectedItem IsNot Nothing Then
         If dgvTemplates.CurrentCell IsNot Nothing Then
            Dim fsc As FileSettingsCreator2(Of CodeTemplates) = ComboBox1.SelectedItem
            Dim c As New CodeTemplates()
            dgvTemplates.Rows(dgvTemplates.CurrentCell.RowIndex).Tag = FormTemplateProperty
            For Each i As DataGridViewRow In dgvTemplates.Rows
               Dim tp As Template = i.Tag
               Select Case tp.Type
                  Case Template.ENUM_TYPE.AMOUNT
                     c.Amount = tp
                  Case Template.ENUM_TYPE.CROSS_CHECK
                     c.CrossLine = tp
                  Case Template.ENUM_TYPE.DATE
                     c.Date = tp
                  Case Template.ENUM_TYPE.PAYEELINE1
                     c.PayeeLine1 = tp
                  Case Template.ENUM_TYPE.PAYEELINE2
                     c.PayeeLine2 = tp
               End Select
            Next
            fsc.setSettings(c)
         End If
         PreviewPage()
      End If
   End Sub
End Class