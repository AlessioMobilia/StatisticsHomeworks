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
        Me.button_hi = New System.Windows.Forms.Button()
        Me.button_clear = New System.Windows.Forms.Button()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_hi
        '
        Me.button_hi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_hi.Location = New System.Drawing.Point(226, 33)
        Me.button_hi.Name = "button_hi"
        Me.button_hi.Size = New System.Drawing.Size(134, 52)
        Me.button_hi.TabIndex = 0
        Me.button_hi.Text = "Hi"
        Me.button_hi.UseVisualStyleBackColor = True
        '
        'button_clear
        '
        Me.button_clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.button_clear.Location = New System.Drawing.Point(340, 294)
        Me.button_clear.Name = "button_clear"
        Me.button_clear.Size = New System.Drawing.Size(96, 37)
        Me.button_clear.TabIndex = 2
        Me.button_clear.Text = "Clear"
        Me.button_clear.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.RichTextBox1)
        Me.GroupBox.Controls.Add(Me.button_hi)
        Me.GroupBox.Location = New System.Drawing.Point(87, 30)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(601, 226)
        Me.GroupBox.TabIndex = 3
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Hi Pippo"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextBox1.Location = New System.Drawing.Point(32, 124)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(525, 86)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 343)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.button_clear)
        Me.Name = "Form1"
        Me.Text = "1A VB.NET - Alessio Mobilia"
        Me.GroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_hi As Button
    Friend WithEvents button_clear As Button
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
