Public Class Code_Settings
   Dim selectedFSC As FileSettingsCreator2(Of CodeTemplates) = Nothing
   Friend WithEvents PreviewPageTimer As New AOA_Timer(1)

   Private Sub Code_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      CreateNeededFolders()
      ComboBox1.Items.Clear()
      For Each file As String In GetCodeFiles()
         Dim fsc As New FileSettingsCreator2(Of CodeTemplates)(file, New CodeTemplates())
         ComboBox1.Items.Add(fsc)
      Next
      'If ComboBox1.Items.Count > 0 Then ComboBox1.SelectedIndex = 0
      ComboBox1.Select()
   End Sub
   Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
      If ComboBox1.SelectedItem IsNot Nothing Then
         selectedFSC = ComboBox1.SelectedItem
         PreviewPageTimer.RestartTimer()
      End If
   End Sub
   Sub PreviewPage()
      PrintChequeDocument.DefaultPageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
      PrintChequeDocument.DefaultPageSettings.Landscape = True
      PrintPreview.Document = PrintChequeDocument ' this will trigger 'PrintChequeDocument.PrintPage' event
      PrintPreview.InvalidatePreview()
      PrintPreview.Zoom = 0.8
   End Sub

   Private Sub PrintChequeDocument_PrintPage(sender As Object, e1 As Printing.PrintPageEventArgs) Handles PrintChequeDocument.PrintPage
      If selectedFSC IsNot Nothing Then
         Dim codeTemplate As CodeTemplates = selectedFSC.GetSettings()
         Dim BrushColor As Brush = Brushes.Black
         Dim PenColor As Pen = Pens.Black
         'crosslines
         Dim crossline As Template = codeTemplate.CrossLine
         e1.Graphics.DrawLine(PenColor, 100, 570 - 280, 200, 520 - 280)
         e1.Graphics.DrawLine(PenColor, 115, 570 - 280, 215, 520 - 280)
         'date
         Dim _date As Template = codeTemplate.Date
         e1.Graphics.DrawString(_date.SampleValue, _date.Font, BrushColor, New Point(_date.X, _date.Y))
         'payee line 1
         Dim payeeLine1 As Template = codeTemplate.PayeeLine1
         e1.Graphics.DrawString(payeeLine1.SampleValue, payeeLine1.Font, BrushColor, New Point(payeeLine1.X, payeeLine1.Y))
         'payee line 2
         Dim payeeLine2 As Template = codeTemplate.PayeeLine2
         e1.Graphics.DrawString(payeeLine2.SampleValue, payeeLine2.Font, BrushColor, New Point(payeeLine2.X, payeeLine2.Y))
         'amount
         Dim amount As Template = codeTemplate.Amount
         e1.Graphics.DrawString(amount.SampleValue, amount.Font, BrushColor, New Point(amount.X, amount.Y))
      End If
   End Sub

   Private Sub PreviewPageTimer_Tick(e As AOA_Timer.TickEventInfo) Handles PreviewPageTimer.Tick
      If e.IsTimeReached Then PreviewPage()
   End Sub
End Class