Public Class _Code_Templates
   Public Templates As Template() = Nothing

   Sub New()
      Dim tmp As New List(Of Template)
      '
      Dim [Date] As New Template() With {.TemplateName = "Date", .SampleValue = "Date"}
      Dim CrossLine As New Template() With {.TemplateName = "Crossline", .SampleValue = "CrossLine", .Type = Template.ENUM_TYPE.Line}
      Dim PayeeLine1 As New Template() With {.TemplateName = "Payee Line1", .SampleValue = "Payee Line1"}
      Dim PayeeLine2 As New Template() With {.TemplateName = "Payee Line2", .SampleValue = "Payee Line 2"}
      Dim Amount As New Template() With {.TemplateName = "Amount", .SampleValue = "Amount"}
      '
      tmp.Add([Date])
      tmp.Add(CrossLine)
      tmp.Add(PayeeLine1)
      tmp.Add(PayeeLine2)
      tmp.Add(Amount)
      '
      Templates = tmp.ToArray
   End Sub


   Public Overrides Function ToString() As String
      Return MyBase.ToString
   End Function
End Class
