Imports ArithmeticMeanVBNET.ArithmeticMeanCSharp

Public Class Form1

    Private stat As Statistics = New Statistics()


    Private Sub buttonGemerate_Click(sender As Object, e As EventArgs) Handles buttonGemerate.Click

        For i As Integer = 0 To Me.PeapleNumber.Value - 1

            Dim p As Person = RandomPerson.Generate()
            stat.OnlineArithmeticMean(p.personal.age)
            Me.TextBoxPeapleInfo.AppendText(p.personal.name.PadRight(10) & "| " + p.personal.age.ToString().PadRight(4) & "| " + p.personal.religion & vbLf)
            Me.TextBoxAvg.Text = " AVERAGE AGE:".PadRight(14) & stat.avg & vbLf & vbLf
            stat.OnlineDistribution(p.personal.religion, 1)
            Dim DistributionText As String = "RELIGION".PadRight(10) & "|".PadRight(3) & "N. PEOPLES" & vbLf & vbLf

            For Each d In stat.distribution
                DistributionText += d.Key.PadRight(10) & "|".PadRight(3) + d.Value.ToString & vbLf
            Next
            Me.TextBoxDistribution.Text = DistributionText

        Next
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        stat = New Statistics()
        Me.TextBoxAvg.Clear()
        Me.TextBoxPeapleInfo.Text = "NAME".PadRight(10) & "| AGE".PadRight(6) & "| Religion" & vbLf & vbLf
        Me.TextBoxDistribution.Text = "RELIGION".PadRight(10) & "|".PadRight(3) & "N. PEOPLES" & vbLf & vbLf
    End Sub
End Class


