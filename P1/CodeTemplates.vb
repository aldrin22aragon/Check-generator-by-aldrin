Public Class CodeTemplates
   Public [Date] As Template
   Public CrossLine As Template
   Public PayeeLine1 As Template
   Public PayeeLine2 As Template
   Public Amount As Template

   Sub New()
      [Date] = New Template(Template.ENUM_TYPE.DATE)
      CrossLine = New Template(Template.ENUM_TYPE.CROSS_CHECK)
      PayeeLine1 = New Template(Template.ENUM_TYPE.PAYEELINE1)
      PayeeLine2 = New Template(Template.ENUM_TYPE.PAYEELINE2)
      Amount = New Template(Template.ENUM_TYPE.AMOUNT)
   End Sub

   Public Overrides Function ToString() As String
      Return MyBase.ToString
   End Function
End Class
