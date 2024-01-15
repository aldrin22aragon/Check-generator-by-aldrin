Public Class _Code_Settings

   Dim selectedFSC As FileSettingsCreator2(Of _Code_Templates) = Nothing
   Friend WithEvents PreviewPageTimer As New AOA_Timer(2)
   Friend WithEvents SaveTimer As New AOA_Timer(2)
   Private Sub _Code_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      CreateNeededFolders()
      ReloadCodes()
   End Sub

   Sub ReloadCodes()
      ComboBox1.Items.Clear()
      For Each file As String In GetCodeFiles()
         Dim fsc As New FileSettingsCreator2(Of _Code_Templates)(file, New _Code_Templates())
         ComboBox1.Items.Add(fsc)
      Next
      'If ComboBox1.Items.Count > 0 Then ComboBox1.SelectedIndex = 0
      ComboBox1.Select()
   End Sub

   Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
      If ComboBox1.SelectedItem IsNot Nothing Then
         selectedFSC = ComboBox1.SelectedItem
         CurrentCode = selectedFSC.GetSettings()
         LabelComponent.Text = "Component Name"
         DataGridView1_CurrentCellChanged(New Object, New EventArgs)
      End If
   End Sub

   Property CurrentCode As _Code_Templates
      Get
         If DataGridView1.Rows.Count > 0 Then
            Dim tmpList As New List(Of Template)
            For Each i As DataGridViewRow In DataGridView1.Rows
               Dim tmp As Template = i.Tag
               tmpList.Add(tmp)
            Next
            Return New _Code_Templates() With {.Templates = tmpList.ToArray}
         Else
            Return Nothing
         End If
      End Get
      Set(value As _Code_Templates)
         DataGridView1.Rows.Clear()
         For Each i As Template In value.Templates
            Dim r As Integer = DataGridView1.Rows.Add(i.TemplateName)
            DataGridView1.Rows(r).Tag = i
         Next
         PreviewPageTimer.RestartTimer()
      End Set
   End Property

   Sub PreviewPage()
      PrintChequeDocument.DefaultPageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
      PrintChequeDocument.DefaultPageSettings.Landscape = True
      PrintPreview.Document = PrintChequeDocument
      PrintPreview.InvalidatePreview() ' this will trigger 'PrintChequeDocument.PrintPage' event
      PrintPreview.Zoom = 0.8
   End Sub

   Private Sub PreviewPageTimer_Tick(e As AOA_Timer.TickEventInfo) Handles PreviewPageTimer.Tick
      If e.IsTimeReached Then PreviewPage()
   End Sub
   Private Sub PrintChequeDocument_PrintPage(sender As Object, e1 As Printing.PrintPageEventArgs) Handles PrintChequeDocument.PrintPage
      Dim codes As _Code_Templates = CurrentCode
      If CurrentCode IsNot Nothing Then
         Dim BrushColor As Brush = Brushes.Black
         Dim PenColor As Pen = Pens.Black
         For Each i As DataGridViewRow In DataGridView1.Rows
            Dim template As Template = i.Tag
            If template.Show Then
               Select Case template.Type
                  Case Template.ENUM_TYPE.Line
                     e1.Graphics.DrawLine(PenColor, 100, 570 - 280, 200, 520 - 280)
                     e1.Graphics.DrawLine(PenColor, 115, 570 - 280, 215, 520 - 280)
                  Case Template.ENUM_TYPE.String
                     e1.Graphics.DrawString(template.TmpValue, template.Font, BrushColor, New Point(template.X, template.Y))
               End Select
            End If
         Next

      End If
   End Sub

   Private Sub ButtonAddCode_Click(sender As Object, e As EventArgs) Handles ButtonAddCode.Click
      Dim tmp As New _Code_Templates()
      Dim name As String = InputBox("Name")
      Dim path As String = NewCodeFile(name)
      Dim fsc As New FileSettingsCreator2(Of _Code_Templates)(path, New _Code_Templates)
      fsc.SetSettings(tmp)
      ReloadCodes()
   End Sub

   Private Sub DataGridView1_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellChanged
      If DataGridView1.CurrentCell IsNot Nothing Then
         Dim index As Integer = DataGridView1.CurrentCell.RowIndex
         Dim template As Template = DataGridView1.Rows(index).Tag
         PropValues = template
      End If
   End Sub
   Property _propValues As Template = Nothing
   Property PropValues As Template
      Get
         Dim res As Template = IIf(_propValues IsNot Nothing, _propValues, New Template)
         res.Show = CbShow.Checked
         res.Font = ButtonFont.Tag
         res.X = XPos.Value
         res.Y = Ypos.Value
         res.RotateDegree = Degree.Value
         Return res
      End Get
      Set(value As Template)
         If value IsNot Nothing Then
            _propValues = value
            CbShow.Checked = value.Show
            ButtonFont.Tag = value.Font
            XPos.Value = value.X
            Ypos.Value = value.Y
            Degree.Value = value.RotateDegree
         End If
      End Set
   End Property

   Sub SaveCurrentTemplate()
      If DataGridView1.CurrentCell IsNot Nothing Then
         Dim index As Integer = DataGridView1.CurrentCell.RowIndex
         DataGridView1.Rows(index).Tag = PropValues
      End If
   End Sub

   Private Sub ButtonFont_Click(sender As Object, e As EventArgs) Handles ButtonFont.Click
      Dim d As DialogResult = DialogResult.Cancel
      Try
         d = FontDialog1.ShowDialog
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try
      If d = DialogResult.OK Then
         Dim f As Font = FontDialog1.Font
         ButtonFont.Tag = f
         SaveTimer.RestartTimer()
         PreviewPageTimer.RestartTimer()
      End If
   End Sub

   Private Sub CbShow_CheckStateChanged(sender As Object, e As EventArgs) Handles CbShow.CheckStateChanged
      SaveTimer.RestartTimer()
      PreviewPageTimer.RestartTimer()
   End Sub

   Private Sub XPos_KeyUp(sender As Object, e As KeyEventArgs) Handles Ypos.KeyUp, XPos.KeyUp, Degree.KeyUp
      SaveTimer.RestartTimer()
      PreviewPageTimer.RestartTimer()
   End Sub

   Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
      selectedFSC.SetSettings(CurrentCode)
      MsgBox("saved")
   End Sub

   Private Sub SaveTimer_Tick(e As AOA_Timer.TickEventInfo) Handles SaveTimer.Tick
      SaveCurrentTemplate()
   End Sub
End Class