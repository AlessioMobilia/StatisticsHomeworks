Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer
        number = 1111111
        Overwirite(number)
        Me.RichTextBox1.AppendText(number.ToString() & vbLf)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Student = New Student()
        a.name = "Pippo"
        Overwirite(a)
        Me.RichTextBox1.AppendText(a.name & vbLf)
    End Sub

    Private Sub Overwirite(ByVal var As Integer)
        var = 999999999
    End Sub

    Private Shared Sub Overwirite(ByVal var As Student)
        var.name = "9999999"
    End Sub
    Private Class Student
        Public name As String
    End Class


End Class

