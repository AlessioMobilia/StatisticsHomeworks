Imports System
Imports System.Collections.Generic
Imports System.Drawing.Text
Imports System.Text
Imports System.Windows.Forms.VisualStyles

Class Statistics
        Public Property avg As Double = 0.0
        Public Property count As Integer = 0
        Public Property distribution As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()

        Public Sub OnlineArithmeticMean(ByVal number As Double)
            Me.count += 1
            Me.avg = (Me.avg * (count - 1) + number) / count
        End Sub

        Public Sub OnlineDistribution(ByVal key As String, ByVal value As Integer)
            If distribution.ContainsKey(key) Then
                distribution(key) += value
            Else
                distribution.Add(key, value)
            End If
        End Sub
End Class