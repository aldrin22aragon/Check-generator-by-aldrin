Imports System.Drawing.Printing

Public Class Form1
   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      CreateNeededFolders()
      LoadCodes()
   End Sub
   Sub LoadCodes()
      dgvCodes.Rows.Clear()
      Dim codeFiles As String() = IO.Directory.GetFiles(CodesFolder)
      If codeFiles.Length > 0 Then
         For Each file As String In codeFiles
            Dim fileNameWOext = IO.Path.GetFileNameWithoutExtension(file)
            Dim FSC As New FileSettingsCreator2(Of Code)(file, New Code)
            Dim indx = dgvCodes.Rows.Add(fileNameWOext)
            dgvCodes.Rows(indx).Tag = FSC
         Next
      End If
      DataGridView1_CurrentCellChanged(New Object, New EventArgs)
      TemplateStructure.AppendTypes(CbTyp)
   End Sub
   Sub AddToDGVtemplates(template As TemplateStructure, Optional overwriteCurrentCell As Boolean = False)
      If overwriteCurrentCell Then
         Dim ndx As Integer = dgvTemplates.CurrentCell.RowIndex
         dgvTemplates.Rows(ndx).Tag = template
      Else
         Dim indx = dgvTemplates.Rows.Add(template.Name, template.SampleValue)
         dgvTemplates.Rows(indx).Tag = template
      End If
   End Sub
   Private Sub DataGridView1_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvCodes.CurrentCellChanged
      If dgvCodes.CurrentCell IsNot Nothing Then
         Dim fsc As FileSettingsCreator2(Of Code) = dgvCodes.Rows(dgvCodes.CurrentCell.RowIndex).Tag
         dgvTemplates.Rows.Clear()
         If fsc IsNot Nothing Then
            Dim code As Code = fsc.GetSettings()
            For Each template As TemplateStructure In code.Templates
               AddToDGVtemplates(template)
            Next
            dgvTemplates_CurrentCellChanged(New Object, New EventArgs)
         End If
      End If
   End Sub
   Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
      Dim aa As New Form_Add_Template(ListTemplateNames)
      If aa.ShowDialog = DialogResult.OK Then
         AddToDGVtemplates(aa.Response)
      End If
   End Sub
   Function ListTemplateNames() As List(Of TemplateStructure)
      Dim res As New List(Of TemplateStructure)
      For Each i As DataGridViewRow In dgvTemplates.Rows
         Dim tp As TemplateStructure = i.Tag
         res.Add(tp)
      Next
      Return res
   End Function

   Private Sub dgvTemplates_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvTemplates.CurrentCellChanged
      If dgvTemplates.CurrentCell IsNot Nothing Then
         Dim tp As TemplateStructure = dgvTemplates.Rows(dgvTemplates.CurrentCell.RowIndex).Tag
         If tp IsNot Nothing Then
            FormTemplateValue = tp
            PrintPage()
         End If
      End If
   End Sub

   Sub PrintPage()
      printCheque.DefaultPageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
      printCheque.DefaultPageSettings.Landscape = True
      PrintPreview.Document = printCheque
      PrintPreview.InvalidatePreview()
      PrintPreview.Zoom = 0.8
   End Sub

   Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
      If dgvCodes.CurrentCell IsNot Nothing Then
         Dim fsc As FileSettingsCreator2(Of Code) = dgvCodes.Rows(dgvCodes.CurrentCell.RowIndex).Tag
         Dim newCode As New Code
         For Each row As DataGridViewRow In dgvTemplates.Rows
            Dim tp As TemplateStructure = row.Tag
            newCode.Templates.Add(tp)
         Next
         fsc.setSettings(newCode)
         MsgBox("Saved")
      End If
   End Sub

   Private Sub Button7_Click(sender As Object, e As EventArgs) Handles UpdatePreview.Click
      If dgvTemplates.CurrentCell IsNot Nothing Then
         AddToDGVtemplates(FormTemplateValue, True)
      Else
         MsgBox("Please select template first.")
      End If
      PrintPage()
   End Sub

   Property FormTemplateValue As TemplateStructure
      Get
         Return New TemplateStructure With {
            .Name = TbName.Text.Trim,
            .Type = TemplateStructure.ConvertStringTypToEnumTyp(CbTyp.SelectedItem.ToString),
            .SampleValue = TbSample.Text.Trim,
            .[Property] = New Template(Template.ENUM_TYPE.THE_NUN) With {
               .Font = LblFont.Font,
               .RotateDegree = Degree.Value,
               .X = XPos.Value,
               .Y = Ypos.Value
            }
         }
      End Get
      Set(value As TemplateStructure)
         TbName.Text = value.Name
         CbTyp.SelectedItem = value.Type.ToString
         TbSample.Text = value.SampleValue
         ' propperties
         XPos.Value = value.Property.X
         Ypos.Value = value.Property.Y
         Degree.Value = value.Property.RotateDegree
         LblFont.Font = value.Property.Font
         LblFont.Text = value.Property.Font.ToString
      End Set
   End Property

   Private Sub printCheque_PrintPage(sender As Object, e1 As PrintPageEventArgs) Handles printCheque.PrintPage
      Dim CurCellRowIndex As Integer = -1
      If dgvTemplates.CurrentCell IsNot Nothing Then CurCellRowIndex = dgvTemplates.CurrentCell.RowIndex
      For Each row As DataGridViewRow In dgvTemplates.Rows
         Dim BrushColor As Brush = IIf(row.Index = CurCellRowIndex, Brushes.Red, Brushes.Black)
         Dim tp As TemplateStructure = row.Tag
         Select Case tp.Type
            Case TemplateStructure.EnumTemplateType.CROSS_CHECK
               e1.Graphics.DrawLine(Pens.Black, 100, 570 - 280, 200, 520 - 280)
               e1.Graphics.DrawLine(Pens.Black, 115, 570 - 280, 215, 520 - 280)
            Case TemplateStructure.EnumTemplateType.DATE
               e1.Graphics.DrawString(tp.SampleValue, tp.Property.Font, BrushColor, New Point(tp.Property.X, tp.Property.Y))
            Case TemplateStructure.EnumTemplateType.PARAGRAPH
               e1.Graphics.DrawString(tp.SampleValue, tp.Property.Font, BrushColor, New Point(tp.Property.X, tp.Property.Y))
         End Select
      Next
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
         f = f
      End If
   End Sub

End Class
