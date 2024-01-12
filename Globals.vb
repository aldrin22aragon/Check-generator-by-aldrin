Module Globals
   Public SettingsFolder As String = IO.Path.Combine(Application.StartupPath, "Settings")
   Public CodesFolder As String = IO.Path.Combine(SettingsFolder, "Codes")

   Public Sub CreateNeededFolders()
      If Not IO.Directory.Exists(SettingsFolder) Then MkDir(SettingsFolder)
      If Not IO.Directory.Exists(CodesFolder) Then MkDir(CodesFolder)
   End Sub
   Public Function GetCodeFiles() As String()
      Return IO.Directory.GetFiles(CodesFolder, "*.drihnz")
   End Function
End Module
