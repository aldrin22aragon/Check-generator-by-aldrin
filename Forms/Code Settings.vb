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
            e1.Graphics.DrawString(codeTemplate.SampleValues.Date, _date.Font, BrushColor, New Point(_date.X, _date.Y))
            'payee line 1
            Dim payeeLine1 As Template = codeTemplate.PayeeLine1
            e1.Graphics.DrawString(codeTemplate.SampleValues.PayeeLine1, payeeLine1.Font, BrushColor, New Point(payeeLine1.X, payeeLine1.Y))
            'payee line 2
            Dim payeeLine2 As Template = codeTemplate.PayeeLine2
            e1.Graphics.DrawString(codeTemplate.SampleValues.PayeeLine2, payeeLine2.Font, BrushColor, New Point(payeeLine2.X, payeeLine2.Y))
            'amount
            Dim amount As Template = codeTemplate.Amount
            e1.Graphics.DrawString(codeTemplate.SampleValues.Amount, amount.Font, BrushColor, New Point(amount.X, amount.Y))
        End If
    End Sub

    Property PropInputValues As Template
        Get
            Return New Template() With {
                .Show = CbShow.Checked,
                .Font = ButtonFont.Tag,
                .X = XPos.Value,
                .Y = Ypos.Value,
                .RotateDegree = Degree.Value
            }
        End Get
        Set(value As Template)
            CbShow.Checked = value.Show
            ButtonFont.Tag = value.Font
            XPos.Value = value.X
            Ypos.Value = value.Y
            Degree.Value = value.RotateDegree
        End Set
    End Property


    Private Sub PreviewPageTimer_Tick(e As AOA_Timer.TickEventInfo) Handles PreviewPageTimer.Tick
        If e.IsTimeReached Then PreviewPage()
    End Sub

    Private Sub ButtonAddCode_Click(sender As Object, e As EventArgs) Handles ButtonAddCode.Click
        Dim input As String = InputBox("Please enter code")
        Dim file As String = IO.Path.Combine(CodesFolder, input & ".drihnz")
        Dim fsc As New FileSettingsCreator2(Of CodeTemplates)(file, New CodeTemplates())
        fsc.setSettings(New CodeTemplates)
        ComboBox1.Items.Add(fsc)
    End Sub

    Private Sub ButtonDate_Click(sender As Object, e As EventArgs) Handles ButtonDate.Click
        PropInputValues = selectedFSC.GetSettings.Date
    End Sub

    Private Sub ButtonCrossLine_Click(sender As Object, e As EventArgs) Handles ButtonCrossLine.Click
        PropInputValues = selectedFSC.GetSettings.CrossLine
    End Sub

    Private Sub ButtonPayeeLine1_Click(sender As Object, e As EventArgs) Handles ButtonPayeeLine1.Click
        PropInputValues = selectedFSC.GetSettings.PayeeLine1
    End Sub

    Private Sub ButtonPayeeLine2_Click(sender As Object, e As EventArgs) Handles ButtonPayeeLine2.Click
        PropInputValues = selectedFSC.GetSettings.PayeeLine2
    End Sub

    Private Sub ButtonAmount_Click(sender As Object, e As EventArgs) Handles ButtonAmount.Click
        PropInputValues = selectedFSC.GetSettings.Amount
    End Sub
End Class