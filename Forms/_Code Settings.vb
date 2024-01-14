Public Class _Code_Settings

   Dim selectedFSC As FileSettingsCreator2(Of CodeTemplates) = Nothing
   Friend WithEvents PreviewPageTimer As New AOA_Timer(1)
   Private Sub _Code_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class