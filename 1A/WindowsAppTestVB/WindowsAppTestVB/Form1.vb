Public Class Form1

    Private original_color As Color
    Private Sub button_hi_Click(sender As Object, e As EventArgs) Handles button_hi.Click
        Me.RichTextBox1.Text = "Pippo"

    End Sub

    Private Sub button_clear_Click(sender As Object, e As EventArgs) Handles button_clear.Click
        Me.RichTextBox1.Text = ""
    End Sub

    Private Sub RichTextBox1_MouseEnter(sender As Object, e As EventArgs) Handles RichTextBox1.MouseEnter
        original_color = Me.RichTextBox1.BackColor
        Me.RichTextBox1.BackColor = Color.Aquamarine
    End Sub

    Private Sub RichTextBox1_MouseLeave(sender As Object, e As EventArgs) Handles RichTextBox1.MouseLeave
        Me.RichTextBox1.BackColor = original_color
    End Sub
End Class
