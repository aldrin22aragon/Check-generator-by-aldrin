Imports System.Drawing.Printing

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
      PropCurrentCode = Nothing
      PropValues = Nothing
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
         PropCurrentCode = selectedFSC.GetSettings()
         LabelComponent.Text = "Component Name"
         DataGridView1_CurrentCellChanged(New Object, New EventArgs)
      End If
   End Sub

   Property PropCurrentCode As _Code_Templates
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
         If value IsNot Nothing Then
            For Each i As Template In value.Templates
               Dim r As Integer = DataGridView1.Rows.Add(i.TemplateName)
               DataGridView1.Rows(r).Tag = i
            Next
         End If
         PreviewPageTimer.RestartTimer()
      End Set
   End Property

   Sub PreviewPage()
      PrintChequeDocument.DefaultPageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
      PrintChequeDocument.DefaultPageSettings.Landscape = True
      PrintPreview.Document = PrintChequeDocument
      PrintPreview.InvalidatePreview() ' this will trigger 'PrintChequeDocument.PrintPage' event
      'PrintPreview.Zoom = 0.8
   End Sub

   Private Sub PreviewPageTimer_Tick(e As AOA_Timer.TickEventInfo) Handles PreviewPageTimer.Tick
      If e.IsTimeReached Then PreviewPage()
   End Sub
   Private Sub PrintChequeDocument_PrintPage(sender As Object, e1 As Printing.PrintPageEventArgs) Handles PrintChequeDocument.PrintPage
      Dim codes As _Code_Templates = PropCurrentCode
      If PropCurrentCode IsNot Nothing Then
         Dim BrushColor As Brush = Brushes.Black
         Dim PenColor As Pen = Pens.Black
         For Each i As DataGridViewRow In DataGridView1.Rows
            Dim template As Template = i.Tag
            If template.Show Then
               Select Case template.Type
                  Case Template.ENUM_TYPE.Line
                     e1.Graphics.DrawLine(PenColor, template.X, template.Y, template.X + 100, template.Y - 50)
                     'x , y , x + 100 , y - 50
                     e1.Graphics.DrawLine(PenColor, template.X + 15, template.Y, template.X + 115, template.Y - 50)
                     ' x + 15 , y , x + 115 , y- 50, 
                  Case Template.ENUM_TYPE.String
                     e1.Graphics.DrawString(template.SampleValue, template.Font, BrushColor, New Point(template.X, template.Y))
               End Select
            End If
         Next
      End If
      If showLocations Then
         For x As Integer = 0 To 9000 Step +100
            For y As Integer = 0 To 9000 Step +100
               e1.Graphics.DrawString(String.Concat("|", x, "*", y), New Font(FontFamily.GenericSerif, 8), Brushes.Red, New Point(x, y))
            Next
         Next
      End If

   End Sub

   Private Sub ButtonAddCode_Click(sender As Object, e As EventArgs) Handles ButtonAddCode.Click
      Dim name As String = InputBox("Name")
      If name IsNot Nothing AndAlso name.Trim <> "" Then
         name = name.Trim
         Dim tmp As New _Code_Templates()
         Dim path As String = NewCodeFile(name)
         Dim fsc As New FileSettingsCreator2(Of _Code_Templates)(path, New _Code_Templates)
         fsc.SetSettings(tmp)
         ReloadCodes()
      End If
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
         res.SampleValue = TextBoxSampleValue.Text
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
            LabelComponent.Text = value.TemplateName
            TextBoxSampleValue.Text = value.SampleValue
         Else
            _propValues = Nothing
            CbShow.Checked = False
            ButtonFont.Tag = Nothing
            XPos.Value = 0
            Ypos.Value = 0
            Degree.Value = 0
            LabelComponent.Text = "Component Name"
            TextBoxSampleValue.Text = ""
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
      selectedFSC.SetSettings(PropCurrentCode)
      MsgBox("saved")
   End Sub

   Private Sub SaveTimer_Tick(e As AOA_Timer.TickEventInfo) Handles SaveTimer.Tick
      SaveCurrentTemplate()
   End Sub

   Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
      PrintPreview.Zoom += 0.3
   End Sub

   Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
      PrintPreview.Zoom -= 0.3
   End Sub

   Private Sub TextBoxSampleValue_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxSampleValue.KeyUp
      SaveTimer.RestartTimer()
      PreviewPageTimer.RestartTimer()
   End Sub

   Dim showLocations As Boolean = False
   Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
      showLocations = Not showLocations
      PreviewPage()
   End Sub

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

   End Sub

   Private Sub ButtonSampleValues_Click(sender As Object, e As EventArgs) Handles ButtonSampleValues.Click
      If ComboBox1.SelectedItem IsNot Nothing Then
         Dim i As String = InputBox("Please enter new Name", "Rename", IO.Path.GetFileNameWithoutExtension(selectedFSC.path))
         If i IsNot Nothing AndAlso i.Trim <> "" Then
            My.Computer.FileSystem.RenameFile(selectedFSC.path, i & extenstion)
            MsgBox("Renamed")
            ReloadCodes()
         End If
      End If
   End Sub
End Class