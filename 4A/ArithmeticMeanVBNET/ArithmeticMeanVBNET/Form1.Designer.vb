<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.buttonGemerate = New System.Windows.Forms.Button()
        Me.buttonClear = New System.Windows.Forms.Button()
        Me.PeapleNumber = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxAvg = New System.Windows.Forms.RichTextBox()
        Me.TextBoxDistribution = New System.Windows.Forms.RichTextBox()
        Me.TextBoxPeapleInfo = New System.Windows.Forms.RichTextBox()
        CType(Me.PeapleNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonGemerate
        '
        Me.buttonGemerate.BackColor = System.Drawing.SystemColors.HotTrack
        Me.buttonGemerate.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonGemerate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buttonGemerate.Location = New System.Drawing.Point(12, 20)
        Me.buttonGemerate.Name = "buttonGemerate"
        Me.buttonGemerate.Size = New System.Drawing.Size(103, 39)
        Me.buttonGemerate.TabIndex = 0
        Me.buttonGemerate.Text = "Generate"
        Me.buttonGemerate.UseVisualStyleBackColor = False
        '
        'buttonClear
        '
        Me.buttonClear.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClear.Location = New System.Drawing.Point(699, 20)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(89, 39)
        Me.buttonClear.TabIndex = 1
        Me.buttonClear.Text = "Clear"
        Me.buttonClear.UseVisualStyleBackColor = True
        '
        'PeapleNumber
        '
        Me.PeapleNumber.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeapleNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PeapleNumber.Location = New System.Drawing.Point(121, 39)
        Me.PeapleNumber.Name = "PeapleNumber"
        Me.PeapleNumber.Size = New System.Drawing.Size(120, 18)
        Me.PeapleNumber.TabIndex = 2
        Me.PeapleNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(118, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "N. of People"
        '
        'TextBoxAvg
        '
        Me.TextBoxAvg.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAvg.Location = New System.Drawing.Point(12, 65)
        Me.TextBoxAvg.Name = "TextBoxAvg"
        Me.TextBoxAvg.Size = New System.Drawing.Size(776, 26)
        Me.TextBoxAvg.TabIndex = 4
        Me.TextBoxAvg.Text = ""
        '
        'TextBoxDistribution
        '
        Me.TextBoxDistribution.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDistribution.Location = New System.Drawing.Point(421, 97)
        Me.TextBoxDistribution.Name = "TextBoxDistribution"
        Me.TextBoxDistribution.Size = New System.Drawing.Size(367, 315)
        Me.TextBoxDistribution.TabIndex = 5
        Me.TextBoxDistribution.Text = "RELIGION  |  N. PEOPLES" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBoxPeapleInfo
        '
        Me.TextBoxPeapleInfo.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPeapleInfo.Location = New System.Drawing.Point(12, 97)
        Me.TextBoxPeapleInfo.Name = "TextBoxPeapleInfo"
        Me.TextBoxPeapleInfo.Size = New System.Drawing.Size(403, 315)
        Me.TextBoxPeapleInfo.TabIndex = 6
        Me.TextBoxPeapleInfo.Text = "NAME      | AGE | RELIGION" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(800, 431)
        Me.Controls.Add(Me.TextBoxPeapleInfo)
        Me.Controls.Add(Me.TextBoxDistribution)
        Me.Controls.Add(Me.TextBoxAvg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PeapleNumber)
        Me.Controls.Add(Me.buttonClear)
        Me.Controls.Add(Me.buttonGemerate)
        Me.Name = "Form1"
        Me.Text = "4_A - Alessio Mobilia"
        CType(Me.PeapleNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonGemerate As Button
    Friend WithEvents buttonClear As Button
    Friend WithEvents PeapleNumber As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxAvg As RichTextBox
    Friend WithEvents TextBoxDistribution As RichTextBox
    Friend WithEvents TextBoxPeapleInfo As RichTextBox
End Class
