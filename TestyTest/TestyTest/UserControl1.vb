Public Class UserControl1
    Public Property beans As Image
    Public Property correctAnswer As Integer
    Public Property Quostion As String

    Public Sub SetThings()
        Picture.Image = beans
        Question.Text = Quostion
    End Sub

    Public Function Check(answer As Integer)
        If answer = correctAnswer Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
