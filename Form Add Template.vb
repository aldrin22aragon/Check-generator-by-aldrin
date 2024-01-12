Public Class Form_Add_Template
   Public Response As TemplateStructure
   Public ExeptionListNames As New List(Of TemplateStructure)
   Private Sub Form_Add_Template_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      TextBox1.Clear()
      TextBox2.Clear()
      TemplateStructure.AppendTypes(ComboBox1)
      TextBox1.Select()
   End Sub



   Sub New(exeptions As List(Of TemplateStructure))

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      Me.ExeptionListNames = exeptions
   End Sub

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      Dim aa As TemplateStructure = ExeptionListNames.Find(Function(tmp)
                                                              Return tmp.Name = TextBox1.Text.Trim
                                                           End Function)
      If aa IsNot Nothing Then
         MsgBox("Name is already in the Template list. Please try different name.")
      Else
         Response = New TemplateStructure() With {
            .Name = TextBox1.Text.Trim,
            .SampleValue = TextBox2.Text.Trim,
            .Type = TemplateStructure.ConvertStringTypToEnumTyp(ComboBox1.SelectedItem.ToString),
            .[Property] = New Template(Template.ENUM_TYPE.THE_NUN) With {
               .RotateDegree = 0,
               .X = 50,
               .Y = 50
            }
         }
         DialogResult = DialogResult.OK
      End If
   End Sub
End Class