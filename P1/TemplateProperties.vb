Public Class Template
   Public Show As Boolean = False
   Public X As Integer = 0
   Public Y As Integer = 0
   Public Font As Font = New Font("Segoew UI", 12)
   Public RotateDegree As Integer
   Public Type As ENUM_TYPE = ENUM_TYPE.THE_NUN
   Public SampleValue As String = ""
   Sub New(typ As ENUM_TYPE)
      Me.Type = typ
   End Sub
   Sub New()
   End Sub
   Enum ENUM_TYPE As Integer
      THE_NUN = 0
      [DATE] = 1
      PAYEELINE1 = 2
      PAYEELINE2 = 2
      CROSS_CHECK = 3
      AMOUNT = 4
   End Enum
End Class
