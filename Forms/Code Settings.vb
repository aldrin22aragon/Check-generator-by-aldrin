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
         PropSelectedCode = selectedFSC.GetSettings()
         PropFormValues = Nothing
         PreviewPageTimer.RestartTimer()
         LabelComponent.Text = "Component Name"
      End If
   End Sub
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
      If PropSelectedCode IsNot Nothing Then
         PropSelectedCode(e1) = PropSelectedCode
      End If
   End Sub

   Property PropSelectedCode(Optional e1 As Printing.PrintPageEventArgs = Nothing) As CodeTemplates
      Get
         Return New CodeTemplates() With {
                .Amount = ButtonAmount.Tag,
                .CrossLine = ButtonCrossLine.Tag,
                .[Date] = ButtonDate.Tag,
                .PayeeLine1 = ButtonPayeeLine1.Tag,
                .PayeeLine2 = ButtonPayeeLine2.Tag,
                .SampleValues = ButtonSampleValues.Tag
            }
      End Get
      Set(value As CodeTemplates)
         Dim amount As Template = value.Amount
         Dim crossline As Template = value.CrossLine
         Dim _date As Template = value.Date
         Dim payeeLine1 As Template = value.PayeeLine1
         Dim payeeLine2 As Template = value.PayeeLine2
         ButtonAmount.Tag = amount
         ButtonCrossLine.Tag = crossline
         ButtonDate.Tag = _date
         ButtonPayeeLine1.Tag = payeeLine1
         ButtonPayeeLine2.Tag = payeeLine2
         ButtonSampleValues.Tag = value.SampleValues
         If e1 IsNot Nothing Then
            Dim BrushColor As Brush = Brushes.Black
            Dim PenColor As Pen = Pens.Black
            'amount
            If amount.Show Then
               e1.Graphics.DrawString(value.SampleValues.Amount, amount.Font, BrushColor, New Point(amount.X, amount.Y))
            End If
            'crosslines
            If crossline.Show Then
               e1.Graphics.DrawLine(PenColor, 100, 570 - 280, 200, 520 - 280)
               e1.Graphics.DrawLine(PenColor, 115, 570 - 280, 215, 520 - 280)
            End If
            'date
            If _date.Show Then
               e1.Graphics.DrawString(value.SampleValues.Date, _date.Font, BrushColor, New Point(_date.X, _date.Y))
            End If
            'payee line 1
            If payeeLine1.Show Then
               e1.Graphics.DrawString(value.SampleValues.PayeeLine1, payeeLine1.Font, BrushColor, New Point(payeeLine1.X, payeeLine1.Y))
            End If
            'payee line 2
            If payeeLine2.Show Then
               e1.Graphics.DrawString(value.SampleValues.PayeeLine2, payeeLine2.Font, BrushColor, New Point(payeeLine2.X, payeeLine2.Y))
            End If
            'sample values
         Else
            e1 = e1
         End If
      End Set
   End Property

   Property PropFormValues() As Template
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
         If value IsNot Nothing Then
            CbShow.Checked = value.Show
            ButtonFont.Tag = value.Font
            XPos.Value = value.X
            Ypos.Value = value.Y
            Degree.Value = value.RotateDegree
         Else
            CbShow.Checked = False
            ButtonFont.Tag = Nothing
            XPos.Value = 0
            Ypos.Value = 0
            Degree.Value = 0
         End If
      End Set
   End Property


   Private Sub ButtonAddCode_Click(sender As Object, e As EventArgs) Handles ButtonAddCode.Click
      Dim input As String = InputBox("Please enter code")
      Dim file As String = IO.Path.Combine(CodesFolder, input & ".drihnz")
      Dim fsc As New FileSettingsCreator2(Of CodeTemplates)(file, New CodeTemplates())
      fsc.setSettings(New CodeTemplates)
      ComboBox1.Items.Add(fsc)
   End Sub

   Private Sub ButtonDate_Click(sender As Object, e As EventArgs) Handles ButtonDate.Click
      If selectedFSC Is Nothing Then MsgBox("Please select code first") : Exit Sub
      PropFormValues = ButtonDate.Tag
      LabelComponent.Text = "Date Component"
      LabelComponent.Tag = ButtonDate.Name
   End Sub

   Private Sub ButtonCrossLine_Click(sender As Object, e As EventArgs) Handles ButtonCrossLine.Click
      If selectedFSC Is Nothing Then MsgBox("Please select code first") : Exit Sub
      PropFormValues = ButtonCrossLine.Tag
      LabelComponent.Text = "Cross Line Component"
      LabelComponent.Tag = ButtonCrossLine.Name
   End Sub

   Private Sub ButtonPayeeLine1_Click(sender As Object, e As EventArgs) Handles ButtonPayeeLine1.Click
      If selectedFSC Is Nothing Then MsgBox("Please select code first") : Exit Sub
      PropFormValues = ButtonPayeeLine1.Tag
      LabelComponent.Text = "Payee Line1 Component"
      LabelComponent.Tag = ButtonPayeeLine1.Name
   End Sub

   Private Sub ButtonPayeeLine2_Click(sender As Object, e As EventArgs) Handles ButtonPayeeLine2.Click
      If selectedFSC Is Nothing Then MsgBox("Please select code first") : Exit Sub
      PropFormValues = ButtonPayeeLine2.Tag
      LabelComponent.Text = "Payee Line2 Component"
      LabelComponent.Tag = ButtonPayeeLine2.Name
   End Sub

   Private Sub ButtonAmount_Click(sender As Object, e As EventArgs) Handles ButtonAmount.Click
      If selectedFSC Is Nothing Then MsgBox("Please select code first") : Exit Sub
      PropFormValues = ButtonAmount.Tag
      LabelComponent.Text = "Amount Component"
      LabelComponent.Tag = ButtonAmount.Name
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
         If AutoSaveForm() = True Then PreviewPageTimer.RestartTimer()
      End If
   End Sub

   Private Sub CbShow_CheckStateChanged(sender As Object, e As EventArgs) Handles CbShow.CheckStateChanged
      If AutoSaveForm() = True Then PreviewPageTimer.RestartTimer()
   End Sub

   Private Sub XPos_KeyUp(sender As Object, e As KeyEventArgs) Handles Ypos.KeyUp, XPos.KeyUp, Degree.KeyUp
      If AutoSaveForm() = True Then PreviewPageTimer.RestartTimer()
   End Sub
   Function AutoSaveForm() As Boolean
      If LabelComponent.Tag IsNot Nothing Then
         Dim nm As String = LabelComponent.Tag
         ButtonSave.BackColor = Color.Tomato
         ButtonSave.Text = "Save !!!!"
         Select Case nm
            Case ButtonDate.Name
               ButtonDate.Tag = PropFormValues
            Case ButtonCrossLine.Name
               ButtonCrossLine.Tag = PropFormValues
            Case ButtonPayeeLine1.Name
               ButtonPayeeLine1.Tag = PropFormValues
            Case ButtonPayeeLine2.Name
               ButtonPayeeLine2.Tag = PropFormValues
            Case ButtonAmount.Name
               ButtonAmount.Tag = PropFormValues
         End Select
         Return True
      Else
         MsgBox("Please select component")
         Return False
      End If
   End Function

   Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
      If selectedFSC IsNot Nothing Then
         selectedFSC.setSettings(PropSelectedCode)
         ButtonSave.BackColor = Color.MediumAquamarine
         ButtonSave.Text = "Saved"
         MsgBox("Saved")
      End If
   End Sub

   Private Sub ButtonSampleValues_Click(sender As Object, e As EventArgs) Handles ButtonSampleValues.Click

   End Sub

   Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




   End Sub

   Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

   End Sub
End Class