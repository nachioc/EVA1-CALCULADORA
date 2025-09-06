<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtDisplay = New TextBox()
        btnC = New Button()
        btnDiv = New Button()
        btnMult = New Button()
        btnResta = New Button()
        btnSuma = New Button()
        btnIgual = New Button()
        btn0 = New Button()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Location = New Point(28, 113)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.Size = New Size(238, 23)
        txtDisplay.TabIndex = 0
        ' 
        ' btnC
        ' 
        btnC.Location = New Point(28, 142)
        btnC.Name = "btnC"
        btnC.Size = New Size(156, 49)
        btnC.TabIndex = 1
        btnC.Text = "Borrar"
        btnC.UseVisualStyleBackColor = True
        ' 
        ' btnDiv
        ' 
        btnDiv.Location = New Point(190, 144)
        btnDiv.Name = "btnDiv"
        btnDiv.Size = New Size(76, 47)
        btnDiv.TabIndex = 2
        btnDiv.Text = "/"
        btnDiv.UseVisualStyleBackColor = True
        ' 
        ' btnMult
        ' 
        btnMult.Location = New Point(190, 197)
        btnMult.Name = "btnMult"
        btnMult.Size = New Size(76, 47)
        btnMult.TabIndex = 3
        btnMult.Text = "X"
        btnMult.UseVisualStyleBackColor = True
        ' 
        ' btnResta
        ' 
        btnResta.Location = New Point(190, 250)
        btnResta.Name = "btnResta"
        btnResta.Size = New Size(76, 47)
        btnResta.TabIndex = 4
        btnResta.Text = "-"
        btnResta.UseVisualStyleBackColor = True
        ' 
        ' btnSuma
        ' 
        btnSuma.Location = New Point(190, 303)
        btnSuma.Name = "btnSuma"
        btnSuma.Size = New Size(76, 47)
        btnSuma.TabIndex = 5
        btnSuma.Text = "+"
        btnSuma.UseVisualStyleBackColor = True
        ' 
        ' btnIgual
        ' 
        btnIgual.Location = New Point(147, 356)
        btnIgual.Name = "btnIgual"
        btnIgual.Size = New Size(119, 47)
        btnIgual.TabIndex = 6
        btnIgual.Text = "="
        btnIgual.UseVisualStyleBackColor = True
        ' 
        ' btn0
        ' 
        btn0.Location = New Point(28, 356)
        btn0.Name = "btn0"
        btn0.Size = New Size(120, 47)
        btn0.TabIndex = 7
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(28, 303)
        btn1.Name = "btn1"
        btn1.Size = New Size(48, 47)
        btn1.TabIndex = 8
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(82, 303)
        btn2.Name = "btn2"
        btn2.Size = New Size(48, 47)
        btn2.TabIndex = 9
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(136, 303)
        btn3.Name = "btn3"
        btn3.Size = New Size(48, 47)
        btn3.TabIndex = 10
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(28, 250)
        btn4.Name = "btn4"
        btn4.Size = New Size(48, 47)
        btn4.TabIndex = 11
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Location = New Point(82, 250)
        btn5.Name = "btn5"
        btn5.Size = New Size(48, 47)
        btn5.TabIndex = 12
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Location = New Point(136, 250)
        btn6.Name = "btn6"
        btn6.Size = New Size(48, 47)
        btn6.TabIndex = 13
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Location = New Point(28, 197)
        btn7.Name = "btn7"
        btn7.Size = New Size(48, 47)
        btn7.TabIndex = 14
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Location = New Point(82, 197)
        btn8.Name = "btn8"
        btn8.Size = New Size(48, 47)
        btn8.TabIndex = 15
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Location = New Point(136, 197)
        btn9.Name = "btn9"
        btn9.Size = New Size(48, 47)
        btn9.TabIndex = 16
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_IPCHILE
        PictureBox1.Location = New Point(28, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(238, 77)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(291, 432)
        Controls.Add(PictureBox1)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(btn0)
        Controls.Add(btnIgual)
        Controls.Add(btnSuma)
        Controls.Add(btnResta)
        Controls.Add(btnMult)
        Controls.Add(btnDiv)
        Controls.Add(btnC)
        Controls.Add(txtDisplay)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnC As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
