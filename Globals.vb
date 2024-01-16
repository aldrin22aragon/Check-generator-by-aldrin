Module Globals
   Public extenstion As String = ".drihnz"

   Public SettingsFolder As String = IO.Path.Combine(Application.StartupPath, "Settings")
   Public CodesFolder As String = IO.Path.Combine(SettingsFolder, "Codes")

   Public Sub CreateNeededFolders()
      If Not IO.Directory.Exists(SettingsFolder) Then MkDir(SettingsFolder)
      If Not IO.Directory.Exists(CodesFolder) Then MkDir(CodesFolder)
   End Sub
   Public Function GetCodeFiles() As String()
      Return IO.Directory.GetFiles(CodesFolder, "*" & extenstion)
   End Function
   Public Function NewCodeFile(fileName As String) As String
      Return IO.Path.Combine(CodesFolder, fileName & extenstion)
   End Function

End Module
