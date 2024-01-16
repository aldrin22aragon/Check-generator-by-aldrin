Public Class Template
   Public TemplateName As String = ""
   Public SampleValue As String = ""
   '

   Public Show As Boolean = True
   Public X As Integer = 0
   Public Y As Integer = 0
   Public Font As New Font("Segoe UI", 12)
   Public RotateDegree As Integer
   Public Type As ENUM_TYPE = ENUM_TYPE.String
   Enum ENUM_TYPE As Integer
      [String] = 1
      Line = 2
   End Enum
End Class
