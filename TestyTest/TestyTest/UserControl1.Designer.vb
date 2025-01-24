<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Picture = New PictureBox()
        Question = New TextBox()
        Answer = New TextBox()
        CType(Picture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Picture
        ' 
        Picture.Location = New Point(47, 3)
        Picture.Name = "Picture"
        Picture.Size = New Size(175, 127)
        Picture.SizeMode = PictureBoxSizeMode.Zoom
        Picture.TabIndex = 0
        Picture.TabStop = False
        ' 
        ' Question
        ' 
        Question.Location = New Point(47, 136)
        Question.Multiline = True
        Question.Name = "Question"
        Question.ReadOnly = True
        Question.Size = New Size(100, 23)
        Question.TabIndex = 1
        ' 
        ' Answer
        ' 
        Answer.Location = New Point(47, 165)
        Answer.Name = "Answer"
        Answer.Size = New Size(100, 23)
        Answer.TabIndex = 2
        ' 
        ' UserControl1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Answer)
        Controls.Add(Question)
        Controls.Add(Picture)
        Name = "UserControl1"
        Size = New Size(268, 262)
        CType(Picture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Picture As PictureBox
    Friend WithEvents Question As TextBox
    Friend WithEvents Answer As TextBox

End Class
