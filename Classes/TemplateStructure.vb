Public Class TemplateStructure
   Public Name As String = ""
   Public Type As EnumTemplateType = EnumTemplateType.NONE
   Public [Property] As Template
   Public SampleValue As String = ""
   Enum EnumTemplateType As Integer
      NONE = 0
      [DATE] = 1
      CROSS_CHECK = 2
      PARAGRAPH = 3
   End Enum

   Shared Sub AppendTypes(ComboBox1 As ComboBox)
      ComboBox1.Items.Clear()
      For i As Integer = 0 To 100
         Dim typ As TemplateStructure.EnumTemplateType = i
         If IsNumeric(typ.ToString) Then
            Exit For
         End If
         ComboBox1.Items.Add(typ.ToString)
      Next
   End Sub

   Shared Function ConvertStringTypToEnumTyp(str As String) As EnumTemplateType
      Dim res As EnumTemplateType = EnumTemplateType.NONE
      For i As Integer = 0 To 100
         Dim typ As TemplateStructure.EnumTemplateType = i
         Dim stringEnum As String = typ.ToString
         If Not IsNumeric(stringEnum) AndAlso str = stringEnum Then
            res = typ
            Exit For
         End If
      Next
      Return res
   End Function

   Function Clone() As TemplateStructure
      Return Me.MemberwiseClone
   End Function
End Class